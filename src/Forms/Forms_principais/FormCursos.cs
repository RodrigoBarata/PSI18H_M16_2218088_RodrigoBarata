using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms
{
    public partial class Cursos : Form
    {
        DB db = new DB();
        public Cursos()
        {
            InitializeComponent();
            combobox_area();
            combobox_subarea();
            dataview();
        }
        void combobox_area()
        {
            string selectQuery = "SELECT * FROM area ORDER BY nome_area ASC;";
            using (MySqlCommand mysqlcommand = new MySqlCommand(selectQuery, db.connection))
            {
                MySqlDataReader myReader;
                try
                {
                    db.openConnection();
                    myReader = mysqlcommand.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(myReader);
                    cbxareas.DisplayMember = "nome_area";
                    cbxareas.ValueMember = "idarea";
                    cbxareas.DataSource = dt;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro:" + erro.Message);
                }
                finally
                {
                    db.closeConnection();
                }
            }
        }
        void combobox_subarea()
        {
            string selectQuery = "SELECT * FROM subarea WHERE area_idarea = " + cbxareas.SelectedValue;
            using (MySqlCommand mysqlcommand = new MySqlCommand(selectQuery, db.connection))
            {
                MySqlDataReader myReader;
                try
                {
                    db.openConnection();
                    myReader = mysqlcommand.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(myReader);
                    cbxsubarea.DisplayMember = "nome_subarea";
                    cbxsubarea.ValueMember = "idsubarea";
                    cbxsubarea.DataSource = dt;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro:" + erro.Message);
                }
                finally
                {
                    db.closeConnection();
                }
            }
        }
        public void dataview()
        {
            string selectQuery = "SELECT idcursos, nome_curso FROM curso WHERE subarea_idsubarea = " + cbxsubarea.SelectedValue;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, db.connection);
            adapter.Fill(table);
            dtcursos.DataSource = table;



        }

        private void cbxareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox_subarea();
        }

        private void cbxsubarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataview();
        }
        public Boolean checkTextBoxesValues()
        {
            if (txtcurso.Text.Equals("") || cbxareas.SelectedValue.Equals("") || cbxsubarea.SelectedValue.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean checkCurso()
        {
            DB db = new DB();

            String nome = txtcurso.Text;


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM curso WHERE nome_curso = @nome", db.getConnection());

            command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;

            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void dtcursos_MouseClick(object sender, MouseEventArgs e)
        {
            txtid.Text = dtcursos.CurrentRow.Cells[0].Value.ToString();
            txtcurso.Text = dtcursos.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            string insertquery = "INSERT INTO curso (nome_curso, subarea_area_idarea, subarea_idsubarea) VALUES(@param1, @param2, @param3)";
            using (MySqlCommand cmd = new MySqlCommand(insertquery, db.connection)) 
            {
                if(checkTextBoxesValues())
                {
                    if(checkCurso())
                    {
                        MessageBox.Show("Já existe este Curso");
                    }
                    else
                    {
                        try
                        {
                            db.openConnection();

                            cmd.Parameters.AddWithValue("@param1", txtcurso.Text);
                            cmd.Parameters.AddWithValue("@param2", cbxareas.SelectedValue);
                            cmd.Parameters.AddWithValue("@param3", cbxsubarea.SelectedValue);
                            cmd.ExecuteNonQuery();
                            dataview();
                            db.closeConnection();
                        }
                        catch
                        {

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE `curso` SET `nome_curso`='" + txtcurso.Text + "',`subarea_area_idarea`='" + cbxareas.SelectedValue + "',`subarea_idsubarea`='" + cbxsubarea.SelectedValue + "' WHERE idcursos =" + int.Parse(txtid.Text);
            using (MySqlCommand cmd = new MySqlCommand(updateQuery, db.connection))
            {
                if (checkTextBoxesValues())
                {
                    if (checkCurso())
                    {
                        MessageBox.Show("Já existe este Curso");
                    }
                    else
                    {
                        try
                        {
                            db.openConnection();


                            cmd.ExecuteNonQuery();
                            dataview();
                            db.closeConnection();
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("Erro:" + erro.Message);
                        }
                        finally
                        {
                            db.closeConnection();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos");
                }

            }
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            if (checkTextBoxesValues())
            {

                try
                {
                    string deleteQuery = "DELETE FROM curso WHERE idcursos = " + int.Parse(txtid.Text);
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, db.connection))
                    {
                        db.openConnection();


                        cmd.ExecuteNonQuery();
                        dataview();
                        db.closeConnection();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro:" + erro.Message);
                }
                finally
                {
                    db.closeConnection();
                }

            }
            else
            {
                MessageBox.Show("Preencha os campos");
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            MySqlDataReader mdr;
            MySqlCommand command;
            string select = "SELECT * FROM curso WHERE nome_curso like '%" + txtsearchcursos.Text + "%'";
            command = new MySqlCommand(select, db.connection);
            db.openConnection();
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {

                txtcurso.Text = mdr.GetString("nome_curso");
            }
            else
            {
                MessageBox.Show("Curso não encontrado");
            }
            db.closeConnection();
        }
    }
}

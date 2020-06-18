using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms.Forms_principais.Form_configuracoes.sub_area
{
    public partial class consultar_subarea : Form
    {
       
        public consultar_subarea()
        {
            InitializeComponent();
            checkArea();
            dataview();

            
            
        }
        DB db = new DB();


        public void dataview()
        {
            string selectQuery = "SELECT idsubarea, nome_subarea FROM subarea WHERE area_idarea = " + cbxareas.SelectedValue;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, db.connection);
            adapter.Fill(table);
            dtsubareas.DataSource = table;



        }
        public void cleanText()
        {
            txtid.Text = "";
            txtsubarea.Text = "";
        }

        void combobox_consultar()
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

        public Boolean checkTextBoxesValues()
        {
            if (txtsubarea.Text.Equals("") || cbxareas.SelectedValue.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean checkSubArea()
        {
            DB db = new DB();

            String nome = txtsubarea.Text;


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM subarea WHERE nome_subarea = @nome", db.getConnection());

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
        public void checkArea()
        {
            DB db = new DB();

           DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM area", db.getConnection());

            

            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count ==0)
            {
                EnableFalse();
            }
            else
            {
                combobox_consultar();
                dataview();
            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO subarea ( nome_subarea, area_idarea) VALUES ( @param1, @param2)";
            using (MySqlCommand cmd = new MySqlCommand(insertQuery, db.connection))
            {

                if (checkTextBoxesValues())
                {
                    if (checkSubArea())
                    {
                        MessageBox.Show("Já existe esta Subárea, escolha outra");
                    }
                    else
                    {
                        try
                        {
                            db.openConnection();

                            cmd.Parameters.AddWithValue("@param1", txtsubarea.Text);
                            cmd.Parameters.AddWithValue("@param2", cbxareas.SelectedValue);
                            cmd.ExecuteNonQuery();
                            dataview();
                            db.closeConnection();
                            cleanText();
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

        private void btneditar_Click(object sender, EventArgs e)
        {
            
                if (checkTextBoxesValues())
                {
                if (checkSubArea())
                {
                    MessageBox.Show("Já existe esta Subárea, escolha outra");
                }
                else
                {
                    string updateQuery = "UPDATE `subarea` SET `nome_subarea`='" + txtsubarea.Text + "',`area_idarea`='" + cbxareas.SelectedValue + "' WHERE idsubarea =" + int.Parse(txtid.Text);
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, db.connection))
                    {
                        try
                        {
                            db.openConnection();


                            cmd.ExecuteNonQuery();
                            dataview();
                            db.closeConnection();
                            cleanText();
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
                }
                else
                {
                    MessageBox.Show("Preencha os campos");
                }

            
        }

        private void dtsubareas_MouseClick(object sender, MouseEventArgs e)
        {
            txtid.Text = dtsubareas.CurrentRow.Cells[0].Value.ToString();
            txtsubarea.Text = dtsubareas.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM subarea WHERE idsubarea = " + int.Parse(txtid.Text);
            if (checkTextBoxesValues())
            {
                if (!checkSubArea())
                {
                    MessageBox.Show("Esta Suárea contém cursos\n Elimine primeiro os Cursos");
                }
                else
                {
                    try
                    {
                        
                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, db.connection))
                        {
                            db.openConnection();


                            cmd.ExecuteNonQuery();
                            dataview();
                            db.closeConnection();
                            cleanText();
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
            }
            else
            {
                MessageBox.Show("Preencha os campos");
            }

        }

        

        private void cbxareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataview();
        }

        public void EnableFalse()
        {
           
                MessageBox.Show("Tem de inserir uma Área");
                dtsubareas.Enabled = false;
                txtconsultararea.Enabled = false;
                txtsubarea.Enabled = false;
                btneditar.Enabled = false;
                btnnovo.Enabled = false;
                btnremover.Enabled = false;
               
               
            
        }

        private void txtconsultararea_TextChanged(object sender, EventArgs e)
        {
            search(txtconsultararea.Text);
        }
        public void search(string search)
        {
            DB db = new DB();
            {
                string pesquisarQuery = "SELECT * FROM subarea WHERE nome_subarea LIKE '%" + search + "%'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(pesquisarQuery, db.getConnection());
                DataTable table = new DataTable();
                adapter.Fill(table);
                dtsubareas.DataSource = table;
            }

        }
    }
}

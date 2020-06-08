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
        MySqlCommand command;
        public consultar_subarea()
        {
            InitializeComponent();
            combobox();
            combobox_consultar();
            dataview();
        }
        DB db = new DB();
        void combobox()
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
                    cbxarea.DisplayMember = "nome_area";
                    cbxarea.ValueMember = "idarea";
                    cbxarea.DataSource = dt;
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
            string selectQuery = "SELECT* FROM subarea WHERE area_idarea = " + cbxareas.SelectedValue;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, db.connection);
            adapter.Fill(table);
            dtsubareas.DataSource = table;
            
            

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

        private void btnnovo_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO subarea ( nome_subarea, area_idarea) VALUES ( @param1, @param2)";
            using (MySqlCommand cmd = new MySqlCommand(insertQuery, db.connection))
            {
               
                try
                {
                    db.openConnection();

                    cmd.Parameters.AddWithValue("@param1", txtsubarea.Text);
                    cmd.Parameters.AddWithValue("@param2", cbxarea.SelectedValue);
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

        private void btneditar_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE `subarea` SET `nome_subarea`='"+txtsubarea.Text+"',`area_idarea`='"+cbxarea.SelectedValue+ "' WHERE idsubarea =" + int.Parse(txtid.Text);
            using (MySqlCommand cmd = new MySqlCommand(updateQuery, db.connection))
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

        private void dtsubareas_MouseClick(object sender, MouseEventArgs e)
        {
            txtid.Text = dtsubareas.CurrentRow.Cells[0].Value.ToString();
            txtsubarea.Text = dtsubareas.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM subarea WHERE idsubarea = " + int.Parse(txtid.Text);
            using (MySqlCommand cmd = new MySqlCommand(deleteQuery, db.connection))
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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            MySqlDataReader mdr;
            
            string select = "SELECT * FROM area WHERE area = " + txtconsultararea.Text;
            command = new MySqlCommand(select, db.connection);
            db.openConnection();
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {

                txtsubarea.Text = mdr.GetString("nome_area");
            }
            else
            {
                MessageBox.Show("Área não encontrada");
            }
            db.closeConnection();
        }
    }
}

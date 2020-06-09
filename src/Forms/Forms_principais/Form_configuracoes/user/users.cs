using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms.Forms_principais.Form_configuracoes.user
{
    public partial class users : Form
    {
        DB db = new DB();
        public users()
        {
            InitializeComponent();
            dataview();
        }
        public void dataview()
        {
            string selectQuery = "SELECT * FROM utilizador";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, db.connection);
            adapter.Fill(table);
            dtareas.DataSource = table;
        }

        private void dtareas_MouseClick(object sender, MouseEventArgs e)
        {
            txtid.Text = dtareas.CurrentRow.Cells[0].Value.ToString();
            txtuser.Text = dtareas.CurrentRow.Cells[1].Value.ToString();
            txtnome.Text = dtareas.CurrentRow.Cells[2].Value.ToString();
            
        }
        public Boolean checkTextBoxesValues()
        {
            if (txtuser.Text.Equals("") || txtuser.Text.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE `utilizador` SET `nome`='" + txtnome.Text + "',`username`='" + txtuser.Text + "' WHERE idutilizador =" + int.Parse(txtid.Text);
            using (MySqlCommand cmd = new MySqlCommand(updateQuery, db.connection))
            {
                if (checkTextBoxesValues())
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
                string deleteQuery = "DELETE FROM utilizador WHERE idutilizador = " + int.Parse(txtid.Text);
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
            else
            {
                MessageBox.Show("Preencha os campos");
            }
        }
    }
}

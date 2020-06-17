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

namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms
{
    public partial class Formadores : Form
    {
        DB db = new DB();
        public Formadores()
        {
            InitializeComponent();
        }
        public Boolean CheckTextBoxes()
        {
            if (txtnome.Text.Equals("") || txtmorada.Text.Equals("") || txtcontri.Text.Equals("") || txttele.Text.Equals("") || cbxperfil.Text.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Boolean checkContribuinte()
        {
            DB db = new DB();

            String contri = txtcontri.Text;


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM formador WHERE contribuinte = @contri", db.getConnection());

            command.Parameters.Add("@contri", MySqlDbType.VarChar).Value = contri;

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
        public void dataview()
        {
            string selectQuery = "SELECT * FROM formador";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, db.connection);
            adapter.Fill(table);
            dt.DataSource = table;


        }

        private void Formadores_Load(object sender, EventArgs e)
        {
            checkData();
        }

        private void dtcliente_Click(object sender, EventArgs e)
        {
            txtid.Text = dt.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dt.CurrentRow.Cells[1].Value.ToString();
            txtmorada.Text = dt.CurrentRow.Cells[2].Value.ToString();
            txtcontri.Text = dt.CurrentRow.Cells[3].Value.ToString();
            txttele.Text = dt.CurrentRow.Cells[4].Value.ToString();
            cbxperfil.Text = dt.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO `formador`(`nome`, `morada`, `contribuinte`, `n_telefone`, `perfil_de_formador`)" +
                           " VALUES ('" + txtnome.Text + "','" + txtmorada.Text + "','" + txtcontri.Text + "','" + txttele.Text + "','" + cbxperfil.Text + "')";
            using (MySqlCommand cmd = new MySqlCommand(insertQuery, db.connection))
            {
                if (CheckTextBoxes())
                {
                    if (checkContribuinte())
                    {
                        MessageBox.Show("Já existe esta Número de Contribuinte, escolha outro");
                    }
                    else
                    {
                        try
                        {
                            db.openConnection();


                            cmd.ExecuteNonQuery();
                            checkData();
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

        private void txtcontri_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Só é valido números");
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {

                string updateQuery = "UPDATE `formador` SET `nome`='" + txtnome.Text + "',`morada`='" + txtmorada.Text + "',`contribuinte`='" + txtcontri.Text + "',`n_telefone`='" + txttele.Text + "',`perfil_de_formador`='" + cbxperfil.Text + "' WHERE idformador =" + int.Parse(txtid.Text);
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
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {


                try
                {
                    string deleteQuery = "DELETE FROM formador WHERE idformador = " + int.Parse(txtid.Text);
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, db.connection))
                    {
                        db.openConnection();


                        cmd.ExecuteNonQuery();
                        checkData();
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
        public void checkData()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM formador", db.getConnection());



            adapter.SelectCommand = command;

            adapter.Fill(table);
           if (table.Rows.Count == 0)
            {
                dt.Enabled = false;
                dataview();
                
            }
            else
            {
                dt.Enabled = true;
                dataview();
            }
        }
        public void search(string search)
        {
            
            {
                string pesquisarQuery = "SELECT * FROM cliente WHERE nome LIKE '%" + search + "%'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(pesquisarQuery, db.getConnection());
                DataTable table = new DataTable();
                adapter.Fill(table);
                dt.DataSource = table;
            }

        }

        private void txtconsultararea_TextChanged(object sender, EventArgs e)
        {
            search(txtconsultararea.Text);
        }
    }
}

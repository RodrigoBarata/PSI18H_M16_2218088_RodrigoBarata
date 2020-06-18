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

namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms
{
    public partial class Clientes : Form
    {
        DB db = new DB();
        public Clientes()
        {
            InitializeComponent();
        }

        public Boolean CheckTextBoxes()
        {
            if(txtnome.Text.Equals("") || txtmorada.Text.Equals("") || txtcontri.Text.Equals("") || txttele.Text.Equals("") || cbxperfil.Text.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Boolean CheckText()
        {
            if (txtnome.Text.Equals("") || txtmorada.Text.Equals("") || txtcontri.Text.Equals("") || txttele.Text.Equals("") )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void clean()
        {
            txtid.Text = "";
            txtmorada.Text = "";
            txtcontri.Text = "";
            txtnome.Text = "";
            txttele.Text = "";

        }
        public Boolean checkContribuinte()
        {
            DB db = new DB();

            String contri = txtcontri.Text;


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM cliente WHERE contribuinte = @contri", db.getConnection());

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
            string selectQuery = "SELECT * FROM cliente";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, db.connection);
            adapter.Fill(table);
            dtcliente.DataSource = table;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            
            checkData();
        }

        private void dtcliente_MouseClick(object sender, MouseEventArgs e)
        {
            txtid.Text = dtcliente.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dtcliente.CurrentRow.Cells[1].Value.ToString();
            txtmorada.Text = dtcliente.CurrentRow.Cells[2].Value.ToString();
            txtcontri.Text = dtcliente.CurrentRow.Cells[3].Value.ToString();
            txttele.Text = dtcliente.CurrentRow.Cells[4].Value.ToString();
            cbxperfil.Text = dtcliente.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO `cliente`(`nome`, `morada`, `contribuinte`, `n_telefone`, `perfil_de_cliente`)" +
                " VALUES ('"+txtnome.Text+"','"+txtmorada.Text+"','"+txtcontri.Text+"','"+txttele.Text+"','"+cbxperfil.Text+"')";
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
                            clean();
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
            if(!Char.IsDigit(chr) && chr !=8)
            {
                e.Handled = true;
                MessageBox.Show("Só é valido números");
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                
                    string updateQuery = "UPDATE `cliente` SET `nome`='"+txtnome.Text+"',`morada`='"+txtmorada.Text+"',`contribuinte`='"+txtcontri.Text+"',`n_telefone`='"+txttele.Text+"',`perfil_de_cliente`='"+cbxperfil.Text+"' WHERE idcliente =" + int.Parse(txtid.Text);
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, db.connection))
                    {
                        try
                        {
                            db.openConnection();


                            cmd.ExecuteNonQuery();
                            dataview();
                            db.closeConnection();
                            clean();
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
            if (CheckText())
            {
                

                    try
                    {
                        string deleteQuery = "DELETE FROM cliente WHERE idcliente = " + int.Parse(txtid.Text);
                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, db.connection))
                        {
                            db.openConnection();


                            cmd.ExecuteNonQuery();
                          
                            checkData();
                            db.closeConnection();
                            clean();
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

            MySqlCommand command = new MySqlCommand("SELECT * FROM cliente", db.getConnection());



            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                dtcliente.Enabled = false;
                dataview();
            }
            else
            {
                dtcliente.Enabled = true;
                dataview();
            }
        }
        public void search(string search)
        {
            DB db = new DB();
            {
                string pesquisarQuery = "SELECT * FROM cliente WHERE nome LIKE '%" + search + "%'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(pesquisarQuery, db.getConnection());
                DataTable table = new DataTable();
                adapter.Fill(table);
                dtcliente.DataSource = table;
            }

        }

        private void txtconsultararea_TextChanged(object sender, EventArgs e)
        {
            search(txtconsultararea.Text);
        }
    }
}

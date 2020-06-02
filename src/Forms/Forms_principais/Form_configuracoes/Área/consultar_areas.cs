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


namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms.Forms_principais.Form_configuracoes.Área
{
    public partial class consultar_areas : Form
    {
        
        DataTable dt = new DataTable();
        string strSQL;
        public consultar_areas()
        {
            InitializeComponent();
            DataGridView();



        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            try
            {
                
                MySqlCommand command = new MySqlCommand("INSERT INTO `area`(`nome_area`) VALUES (@nome)", db.getConnection());

                command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtarea.Text;
                

                db.openConnection();

                if (!checkTextBoxesValues())
                {
                    if (checkUsername())
                    {
                        MessageBox.Show("Já existe esta Área, escolha outra");
                    }
                    else
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Conta Criada");
                            
                        }
                        else
                        {
                            MessageBox.Show("Erro");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeConnection();

            }
        }
        public Boolean checkTextBoxesValues()
        {
            if (txtarea.Equals("") )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean checkUsername()
        {
            DB db = new DB();

            String nome = txtarea.Text;


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM area WHERE nome_area = @nome", db.getConnection());

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

        private void DataGridView()
        {
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd;

            strSQL = "SELECT * FROM area ";
            cmd = new MySqlCommand(strSQL, db.getConnection());
            adapter.SelectCommand = cmd;

            adapter.Fill(dt);

            dtareas.DataSource = dt;

            

        }
      

        private void txtconsultararea_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("nome_area LIKE '%{0}%'", txtconsultararea.Text);

            dtareas.DataSource = dv;
        }

        private void dtareas_MouseClick(object sender, MouseEventArgs e)
        {
            txtarea.Text = dtareas.CurrentRow.Cells[0].Value.ToString();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
             DB db = new DB();
            try
            {
                
                MySqlCommand command = new MySqlCommand("INSERT INTO `area`(`nome_area`) VALUES (@nome)", db.getConnection());

                command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtarea.Text;
                

                db.openConnection();

                if (!checkTextBoxesValues())
                {
                    if (checkUsername())
                    {
                        MessageBox.Show("Já existe esta Área, escolha outra");
                    }
                    else
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Conta Criada");
                            
                        }
                        else
                        {
                            MessageBox.Show("Erro");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeConnection();

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms
{
    public partial class Registar_Cliente : Form
    {
        public Registar_Cliente()
        {
            InitializeComponent();
        }

        string perfil_cliente;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void rbparticular_CheckedChanged(object sender, EventArgs e)
        {
            perfil_cliente = "Particular";
            lbltest.Text = perfil_cliente;
            lbltest.Hide();
        }

        private void rbempent_CheckedChanged(object sender, EventArgs e)
        {
            perfil_cliente = "Empresa/Entidade";
            lbltest.Text = perfil_cliente;
            lbltest.Hide();
        }
        private void btncriar_Click(object sender, EventArgs e)
        {
            
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO cliente (nome, morada, contribuinte,  n_telefone, perfil_de_cliente) VALUES (@nome, @morada, @contri, @telefone, @pfcliente)", db.getConnection());

            
            
            command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtnome.Text;
            command.Parameters.Add("@morada", MySqlDbType.VarChar).Value = txtmorada.Text;
            command.Parameters.Add("@contri", MySqlDbType.VarChar).Value = txtcontribuinte.Text;
            command.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = txttelefone.Text;
            command.Parameters.Add("pfcliente", MySqlDbType.VarChar).Value = lbltest.Text;            

            db.openConnection();

            if (!checkTextBoxesValues())
            {
                if(checkContribuinte())
                {
                    MessageBox.Show("Esse numero de contribuinte já esta a ser usado");
                }
                else
                {
                    if(command.ExecuteNonQuery() == 1)
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

            db.closeConnection();
        }
        public Boolean checkContribuinte()
        {
            DB db = new DB();

            String contri = txtcontribuinte.Text;


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
        public Boolean checkTextBoxesValues()
        {
            if (txtnome.Equals("") || txtmorada.Equals("") || txttelefone.Equals("") || txtcontribuinte.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}

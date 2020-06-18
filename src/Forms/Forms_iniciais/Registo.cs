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
    public partial class Registo : Form
    {
      public Registo()
        {
            InitializeComponent();
        }

      //Insere os Dados do Utlizador na Base de Dados
        private void btnregistar_Click(object sender, EventArgs e)
        {
            
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO `utilizador`(`nome`, `username`, `password`) VALUES (@nome, @username, @password)", db.getConnection());

                command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNome.Text;
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtUsername.Text;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtPassword.Text.Trim();
                

                db.openConnection();

                if(checkTextBoxesValues())
                {
                    if(txtPassword.Text.Equals(txtpassworcheck.Text))
                    {
                         if(checkUsername())
                         {
                            MessageBox.Show("Já existe este Username, escolha outra");
                         }
                         else
                         {
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Conta Criada");
                            this.Hide();
                            Login log = new Login();
                            log.Show();
                            }
                            else
                            {
                                MessageBox.Show("Erro");
                            }
                         }
                    }
                    else
                    {
                    MessageBox.Show("As passwords não sao iguais");
                    }
                }      
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }

                db.closeConnection();
        }

        public Boolean checkUsername()
        {
            DB db = new DB();

            String username = txtUsername.Text;
            

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM utilizador WHERE username = @username", db.getConnection());

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;

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
        //Vê se temos algum campo vazio
        public Boolean checkTextBoxesValues()
        {
            if (txtNome.Text.Equals("") || txtUsername.Text.Equals("") || txtPassword.Text.Equals("") || txtpassworcheck.Text.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

      //Sai da Aplicação
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //permite ao user mover o aplicativo para qualque lado da tela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelregisto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Registar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }
    }
}

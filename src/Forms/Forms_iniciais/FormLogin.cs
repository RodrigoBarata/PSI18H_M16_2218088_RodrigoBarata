using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        
        //Procura o User na Base de Dados
        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String username = txtusername.Text;
            String password = txtpassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("select * from utilizador where(username collate utf8_bin) = @username and(password collate utf8_bin) =@password; ", db.getConnection());

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password.Trim();

            adapter.SelectCommand = command;
            
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    DBViewer main = new DBViewer();
                    main.Show();
                }
                else
                {
                    if (username.Trim().Equals(""))
                    {
                        MessageBox.Show("Insere o teu nome para efetuares o Login");
                    }
                    else if (password.Trim().Equals(""))
                    {
                        MessageBox.Show("Insere a password para efetuares os Login");
                    }
                    else
                    {
                        MessageBox.Show("Username ou Password errados");
                    }
                }
           

        }
        //permite ao user pegar no panel e transportar a aplicação para qualquer lugar do ecrã
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Sai da Aplicação
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Vai para a página de registo
        private void Registar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registo registo = new Registo();
            registo.Show();
        }
    }
}

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

        private void btnregistar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registo registo = new Registo();
            registo.ShowDialog();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String username = txtusername.Text;
            String password = txtpassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM utilizador WHERE username = @username and password = @password", db.getConnection());

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Yes");
            }
            else
            {
                MessageBox.Show("NO");
            }
        }

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
            Application.Exit();
        }
    }
}

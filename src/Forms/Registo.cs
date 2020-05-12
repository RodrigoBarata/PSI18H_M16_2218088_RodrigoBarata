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
    public partial class Registo : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=base_de_dados/proposta;");
        public Registo()
        {
            InitializeComponent();
        }

        private void btnregistar_Click(object sender, EventArgs e)
        {
            string sql = ("INSERT INTO utilizador(nome, username, email, password) VALUES(@nome, @username, @email, @password)");
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                if (txtPassword.Text == txtpassworcheck.Text) ;
                {
                    conn.Open();
                    cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 15).Value = txtNome.Text;
                    cmd.Parameters.Add("@username", MySqlDbType.VarChar, 15).Value = txtUsername.Text;
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar, 15).Value = txtEmail.Text;
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar, 15).Value = txtPassword.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            this.Close();
            Login Log = new Login();
            Log.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login Log = new Login();
            Log.Show();
        }
    }
}

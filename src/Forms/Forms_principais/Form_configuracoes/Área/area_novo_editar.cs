using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms.Forms_principais.Form_configuracoes.Área
{
    public partial class area_novo_editar : Form
    {
        public area_novo_editar()
        {
            InitializeComponent();
        }

        private void btnrsalvar_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `area`(`nome_area`) VALUES (@nome)", db.getConnection());

            command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtnomearea.Text;

            db.openConnection();

            if (!checkTextBoxesValues())
            {
                if(checknomearea())
                {
                    MessageBox.Show("Já existe esta área");
                }
                else
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Área Criada");
                        this.Hide();
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

        public Boolean checknomearea()
        {
            DB db = new DB();

            String nome = txtnomearea.Text;


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
        public Boolean checkTextBoxesValues()
        {
            if (txtnomearea.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
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
    }
}

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
        public Boolean checkArea()
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
            dataview();
        }

        private void dtcliente_MouseClick(object sender, MouseEventArgs e)
        {
            txtnome.Text = dtcliente.CurrentRow.Cells[1].Value.ToString();
            txtmorada.Text = dtcliente.CurrentRow.Cells[2].Value.ToString();
            txtcontri.Text = dtcliente.CurrentRow.Cells[3].Value.ToString();
            txttele.Text = dtcliente.CurrentRow.Cells[4].Value.ToString();
            cbxperfil.Text = dtcliente.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {

        }
    }
}

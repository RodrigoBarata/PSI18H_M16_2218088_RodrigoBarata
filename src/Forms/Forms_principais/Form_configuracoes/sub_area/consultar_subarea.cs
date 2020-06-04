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

namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms.Forms_principais.Form_configuracoes.sub_area
{
    public partial class consultar_subarea : Form
    {
        public consultar_subarea()
        {
            InitializeComponent();
        }
        DB db = new DB();
        private void consultar_subarea_Load(object sender, EventArgs e)
        {
            try
            {
                string selectQuery = "SELECT * FROM area";
                db.openConnection();
                MySqlCommand command = new MySqlCommand(selectQuery, db.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    cbxarea.Items.Add(reader.GetString("nome_area"));
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

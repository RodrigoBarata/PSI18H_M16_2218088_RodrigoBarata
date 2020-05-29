using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms
{
    public partial class login_admin : UserControl
    {
        public login_admin()
        {
            InitializeComponent();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            if(txtuser.Text.Equals("Admin") || txtpass.Text.Equals("Admin"))
            {
                this.Hide();
              
            }
        }
    }
}

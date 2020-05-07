using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms;

namespace PSI18H_M16_Projeto_2218088_RodrigoBarata
{
    public partial class DBViewer : Form
    {
        
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public DBViewer()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 56);
            panelMenu.Controls.Add(leftBorderBtn);
            OpenChildForm(new Login());
            lblTitleChildForm.Text = "Login";

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
      
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(72, 90, 150);
            public static Color color2 = Color.FromArgb(189, 102, 34);
            public static Color color3 = Color.FromArgb(145, 87, 61);
            public static Color color4 = Color.FromArgb(118, 101, 91);
            public static Color color5 = Color.FromArgb(180, 180, 180);

        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(70, 0, 0);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = Color.White;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(64, 0, 0);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesketop.Controls.Add(childForm);
            panelDesketop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text; 
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Clientes());
            lblTitleChildForm.Text = "Clientes";
        }

        private void btncursos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Cursos());
            lblTitleChildForm.Text = "Cursos";
        }

        private void btnformadores_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Formadores());
            lblTitleChildForm.Text = "Formadores";
        }

        private void btnformacoes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Formacao());
            lblTitleChildForm.Text = "Formações";

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
            currentChildForm.Close();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.White;
            lblTitleChildForm.Text = "Home";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnshutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaxime_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void DBViewer_Load(object sender, EventArgs e)
        {
            timer1.Start();
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnconfig_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            lblTitleChildForm.Text = "Configurações";
        }
    }
}

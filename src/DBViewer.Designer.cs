namespace PSI18H_M16_Projeto_2218088_RodrigoBarata
{
    partial class DBViewer
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBViewer));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnconfig = new FontAwesome.Sharp.IconButton();
            this.btnformacoes = new FontAwesome.Sharp.IconButton();
            this.btnformadores = new FontAwesome.Sharp.IconButton();
            this.btncursos = new FontAwesome.Sharp.IconButton();
            this.btnclientes = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnminimize = new FontAwesome.Sharp.IconButton();
            this.btnmaxime = new FontAwesome.Sharp.IconButton();
            this.btnshutdown = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesketop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesketop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelMenu.Controls.Add(this.btnconfig);
            this.panelMenu.Controls.Add(this.btnformacoes);
            this.panelMenu.Controls.Add(this.btnformadores);
            this.panelMenu.Controls.Add(this.btncursos);
            this.panelMenu.Controls.Add(this.btnclientes);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(193, 515);
            this.panelMenu.TabIndex = 0;
            // 
            // btnconfig
            // 
            this.btnconfig.FlatAppearance.BorderSize = 0;
            this.btnconfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfig.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnconfig.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfig.ForeColor = System.Drawing.Color.White;
            this.btnconfig.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnconfig.IconColor = System.Drawing.Color.White;
            this.btnconfig.IconSize = 30;
            this.btnconfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconfig.Location = new System.Drawing.Point(0, 459);
            this.btnconfig.Name = "btnconfig";
            this.btnconfig.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnconfig.Rotation = 0D;
            this.btnconfig.Size = new System.Drawing.Size(193, 56);
            this.btnconfig.TabIndex = 8;
            this.btnconfig.Text = "Configurações";
            this.btnconfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnconfig.UseVisualStyleBackColor = true;
            this.btnconfig.Click += new System.EventHandler(this.btnconfig_Click);
            // 
            // btnformacoes
            // 
            this.btnformacoes.FlatAppearance.BorderSize = 0;
            this.btnformacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnformacoes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnformacoes.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnformacoes.ForeColor = System.Drawing.Color.White;
            this.btnformacoes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnformacoes.IconColor = System.Drawing.Color.White;
            this.btnformacoes.IconSize = 30;
            this.btnformacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnformacoes.Location = new System.Drawing.Point(0, 332);
            this.btnformacoes.Name = "btnformacoes";
            this.btnformacoes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnformacoes.Rotation = 0D;
            this.btnformacoes.Size = new System.Drawing.Size(193, 56);
            this.btnformacoes.TabIndex = 7;
            this.btnformacoes.Text = "Formações";
            this.btnformacoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnformacoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnformacoes.UseVisualStyleBackColor = true;
            this.btnformacoes.Click += new System.EventHandler(this.btnformacoes_Click);
            // 
            // btnformadores
            // 
            this.btnformadores.FlatAppearance.BorderSize = 0;
            this.btnformadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnformadores.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnformadores.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnformadores.ForeColor = System.Drawing.Color.White;
            this.btnformadores.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnformadores.IconColor = System.Drawing.Color.White;
            this.btnformadores.IconSize = 30;
            this.btnformadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnformadores.Location = new System.Drawing.Point(0, 270);
            this.btnformadores.Name = "btnformadores";
            this.btnformadores.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnformadores.Rotation = 0D;
            this.btnformadores.Size = new System.Drawing.Size(193, 56);
            this.btnformadores.TabIndex = 6;
            this.btnformadores.Text = "Formadores";
            this.btnformadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnformadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnformadores.UseVisualStyleBackColor = true;
            this.btnformadores.Click += new System.EventHandler(this.btnformadores_Click);
            // 
            // btncursos
            // 
            this.btncursos.FlatAppearance.BorderSize = 0;
            this.btncursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncursos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btncursos.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncursos.ForeColor = System.Drawing.Color.White;
            this.btncursos.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.btncursos.IconColor = System.Drawing.Color.White;
            this.btncursos.IconSize = 30;
            this.btncursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncursos.Location = new System.Drawing.Point(0, 208);
            this.btncursos.Name = "btncursos";
            this.btncursos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btncursos.Rotation = 0D;
            this.btncursos.Size = new System.Drawing.Size(193, 56);
            this.btncursos.TabIndex = 5;
            this.btncursos.Text = "Cursos";
            this.btncursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncursos.UseVisualStyleBackColor = true;
            this.btncursos.Click += new System.EventHandler(this.btncursos_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnclientes.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.ForeColor = System.Drawing.Color.White;
            this.btnclientes.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnclientes.IconColor = System.Drawing.Color.White;
            this.btnclientes.IconSize = 30;
            this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.Location = new System.Drawing.Point(0, 146);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnclientes.Rotation = 0D;
            this.btnclientes.Size = new System.Drawing.Size(193, 56);
            this.btnclientes.TabIndex = 4;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(187, 102);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 3;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btnminimize);
            this.panel2.Controls.Add(this.btnmaxime);
            this.panel2.Controls.Add(this.btnshutdown);
            this.panel2.Controls.Add(this.lblTitleChildForm);
            this.panel2.Controls.Add(this.iconCurrentChildForm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(193, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 68);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnminimize
            // 
            this.btnminimize.FlatAppearance.BorderSize = 0;
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnminimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnminimize.IconColor = System.Drawing.Color.White;
            this.btnminimize.IconSize = 30;
            this.btnminimize.Location = new System.Drawing.Point(694, 12);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Rotation = 0D;
            this.btnminimize.Size = new System.Drawing.Size(25, 23);
            this.btnminimize.TabIndex = 12;
            this.btnminimize.UseVisualStyleBackColor = true;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnmaxime
            // 
            this.btnmaxime.FlatAppearance.BorderSize = 0;
            this.btnmaxime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmaxime.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnmaxime.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnmaxime.IconColor = System.Drawing.Color.White;
            this.btnmaxime.IconSize = 30;
            this.btnmaxime.Location = new System.Drawing.Point(725, 12);
            this.btnmaxime.Name = "btnmaxime";
            this.btnmaxime.Rotation = 0D;
            this.btnmaxime.Size = new System.Drawing.Size(25, 23);
            this.btnmaxime.TabIndex = 11;
            this.btnmaxime.UseVisualStyleBackColor = true;
            this.btnmaxime.Click += new System.EventHandler(this.btnmaxime_Click);
            // 
            // btnshutdown
            // 
            this.btnshutdown.FlatAppearance.BorderSize = 0;
            this.btnshutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshutdown.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnshutdown.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnshutdown.IconColor = System.Drawing.Color.White;
            this.btnshutdown.IconSize = 30;
            this.btnshutdown.Location = new System.Drawing.Point(756, 12);
            this.btnshutdown.Name = "btnshutdown";
            this.btnshutdown.Rotation = 0D;
            this.btnshutdown.Size = new System.Drawing.Size(25, 23);
            this.btnshutdown.TabIndex = 10;
            this.btnshutdown.UseVisualStyleBackColor = true;
            this.btnshutdown.Click += new System.EventHandler(this.btnshutdown_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(44, 30);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(43, 17);
            this.lblTitleChildForm.TabIndex = 9;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 27);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 8;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesketop
            // 
            this.panelDesketop.Controls.Add(this.pictureBox1);
            this.panelDesketop.Controls.Add(this.date);
            this.panelDesketop.Controls.Add(this.time);
            this.panelDesketop.Location = new System.Drawing.Point(193, 65);
            this.panelDesketop.Name = "panelDesketop";
            this.panelDesketop.Size = new System.Drawing.Size(793, 450);
            this.panelDesketop.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(291, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(303, 229);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(57, 21);
            this.date.TabIndex = 1;
            this.date.Text = "label2";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(340, 205);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(74, 24);
            this.time.TabIndex = 0;
            this.time.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DBViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 515);
            this.Controls.Add(this.panelDesketop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DBViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBViewer";
            this.Load += new System.EventHandler(this.DBViewer_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesketop.ResumeLayout(false);
            this.panelDesketop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDesketop;
        private FontAwesome.Sharp.IconButton btnformacoes;
        private FontAwesome.Sharp.IconButton btnformadores;
        private FontAwesome.Sharp.IconButton btncursos;
        private FontAwesome.Sharp.IconButton btnclientes;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton btnshutdown;
        private FontAwesome.Sharp.IconButton btnmaxime;
        private FontAwesome.Sharp.IconButton btnminimize;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnconfig;
    }
}


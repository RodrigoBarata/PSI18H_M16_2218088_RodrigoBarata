namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms.Forms_principais.Form_configuracoes.user
{
    partial class users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsearch = new FontAwesome.Sharp.IconButton();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.txtconsultararea = new System.Windows.Forms.TextBox();
            this.dtareas = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btnremover = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtareas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnsearch.ForeColor = System.Drawing.Color.Black;
            this.btnsearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnsearch.IconColor = System.Drawing.Color.Black;
            this.btnsearch.IconSize = 16;
            this.btnsearch.Location = new System.Drawing.Point(218, 56);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Rotation = 0D;
            this.btnsearch.Size = new System.Drawing.Size(34, 23);
            this.btnsearch.TabIndex = 35;
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(439, 82);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(94, 20);
            this.txtid.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Digite o Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Procurar:";
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(487, 276);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(118, 37);
            this.btneditar.TabIndex = 24;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txtconsultararea
            // 
            this.txtconsultararea.Location = new System.Drawing.Point(82, 56);
            this.txtconsultararea.Name = "txtconsultararea";
            this.txtconsultararea.Size = new System.Drawing.Size(130, 20);
            this.txtconsultararea.TabIndex = 30;
            // 
            // dtareas
            // 
            this.dtareas.AllowUserToAddRows = false;
            this.dtareas.AllowUserToDeleteRows = false;
            this.dtareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtareas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtareas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtareas.Location = new System.Drawing.Point(82, 82);
            this.dtareas.Name = "dtareas";
            this.dtareas.ReadOnly = true;
            this.dtareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtareas.Size = new System.Drawing.Size(317, 359);
            this.dtareas.TabIndex = 25;
            this.dtareas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtareas_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(405, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 421);
            this.panel2.TabIndex = 29;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(439, 141);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(223, 20);
            this.txtuser.TabIndex = 28;
            // 
            // btnremover
            // 
            this.btnremover.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnremover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnremover.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremover.Location = new System.Drawing.Point(487, 333);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(118, 37);
            this.btnremover.TabIndex = 27;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = false;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Digite o Nome:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(439, 191);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(223, 20);
            this.txtnome.TabIndex = 38;
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 461);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.txtconsultararea);
            this.Controls.Add(this.dtareas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btnremover);
            this.Name = "users";
            this.Text = "users";
            ((System.ComponentModel.ISupportInitialize)(this.dtareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnsearch;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.TextBox txtconsultararea;
        private System.Windows.Forms.DataGridView dtareas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnome;
    }
}
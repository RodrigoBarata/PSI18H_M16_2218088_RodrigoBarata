namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms
{
    partial class Formadores
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxperfil = new System.Windows.Forms.ComboBox();
            this.txttele = new System.Windows.Forms.TextBox();
            this.txtcontri = new System.Windows.Forms.TextBox();
            this.txtmorada = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtconsultararea = new System.Windows.Forms.TextBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.dt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(612, 44);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(86, 20);
            this.txtid.TabIndex = 61;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(609, 28);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(21, 17);
            this.ID.TabIndex = 60;
            this.ID.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(609, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Perfil de Formador";
            // 
            // cbxperfil
            // 
            this.cbxperfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxperfil.Items.AddRange(new object[] {
            "Ativo",
            "Ausente",
            "Lista Negra"});
            this.cbxperfil.Location = new System.Drawing.Point(608, 342);
            this.cbxperfil.Name = "cbxperfil";
            this.cbxperfil.Size = new System.Drawing.Size(121, 21);
            this.cbxperfil.TabIndex = 58;
            // 
            // txttele
            // 
            this.txttele.Location = new System.Drawing.Point(608, 282);
            this.txttele.Name = "txttele";
            this.txttele.Size = new System.Drawing.Size(138, 20);
            this.txttele.TabIndex = 57;
            this.txttele.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontri_KeyPress);
            // 
            // txtcontri
            // 
            this.txtcontri.Location = new System.Drawing.Point(608, 220);
            this.txtcontri.Name = "txtcontri";
            this.txtcontri.Size = new System.Drawing.Size(138, 20);
            this.txtcontri.TabIndex = 56;
            this.txtcontri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontri_KeyPress);
            // 
            // txtmorada
            // 
            this.txtmorada.Location = new System.Drawing.Point(608, 155);
            this.txtmorada.Name = "txtmorada";
            this.txtmorada.Size = new System.Drawing.Size(274, 20);
            this.txtmorada.TabIndex = 55;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(612, 94);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(138, 20);
            this.txtnome.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(605, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "Nº de Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(609, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Nº de Contribuinte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(609, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Morada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(609, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(567, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 451);
            this.panel1.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Procurar:";
            // 
            // txtconsultararea
            // 
            this.txtconsultararea.Location = new System.Drawing.Point(7, 52);
            this.txtconsultararea.Name = "txtconsultararea";
            this.txtconsultararea.Size = new System.Drawing.Size(292, 20);
            this.txtconsultararea.TabIndex = 47;
            this.txtconsultararea.TextChanged += new System.EventHandler(this.txtconsultararea_TextChanged);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.Gray;
            this.btnexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexcluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.ForeColor = System.Drawing.Color.Black;
            this.btnexcluir.Location = new System.Drawing.Point(584, 398);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(114, 39);
            this.btnexcluir.TabIndex = 46;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.Gray;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.Black;
            this.btneditar.Location = new System.Drawing.Point(704, 398);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(114, 39);
            this.btneditar.TabIndex = 45;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.Color.Gray;
            this.btnnovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnovo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.ForeColor = System.Drawing.Color.Black;
            this.btnnovo.Location = new System.Drawing.Point(824, 398);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(114, 39);
            this.btnnovo.TabIndex = 44;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // dt
            // 
            this.dt.AllowUserToAddRows = false;
            this.dt.AllowUserToDeleteRows = false;
            this.dt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dt.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dt.Location = new System.Drawing.Point(7, 78);
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            this.dt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt.Size = new System.Drawing.Size(554, 314);
            this.dt.TabIndex = 43;
            this.dt.Click += new System.EventHandler(this.dtcliente_Click);
            // 
            // Formadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxperfil);
            this.Controls.Add(this.txttele);
            this.Controls.Add(this.txtcontri);
            this.Controls.Add(this.txtmorada);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtconsultararea);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.dt);
            this.Name = "Formadores";
            this.Text = "FormFormadores";
            this.Load += new System.EventHandler(this.Formadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxperfil;
        private System.Windows.Forms.TextBox txttele;
        private System.Windows.Forms.TextBox txtcontri;
        private System.Windows.Forms.TextBox txtmorada;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtconsultararea;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.DataGridView dt;
    }
}
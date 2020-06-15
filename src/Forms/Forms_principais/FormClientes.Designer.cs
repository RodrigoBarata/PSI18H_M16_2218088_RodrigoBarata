namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms
{
    partial class Clientes
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
            this.dtcliente = new System.Windows.Forms.DataGridView();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtconsultararea = new System.Windows.Forms.TextBox();
            this.idcliente = new System.Windows.Forms.Label();
            this.nomecliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtmorada = new System.Windows.Forms.TextBox();
            this.txtcontri = new System.Windows.Forms.TextBox();
            this.txttele = new System.Windows.Forms.TextBox();
            this.cbxperfil = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtcliente
            // 
            this.dtcliente.AllowUserToAddRows = false;
            this.dtcliente.AllowUserToDeleteRows = false;
            this.dtcliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtcliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtcliente.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtcliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtcliente.Location = new System.Drawing.Point(12, 79);
            this.dtcliente.Name = "dtcliente";
            this.dtcliente.ReadOnly = true;
            this.dtcliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtcliente.Size = new System.Drawing.Size(554, 314);
            this.dtcliente.TabIndex = 2;
            this.dtcliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtcliente_MouseClick);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.Color.Gray;
            this.btnnovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnovo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.ForeColor = System.Drawing.Color.Black;
            this.btnnovo.Location = new System.Drawing.Point(829, 399);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(114, 39);
            this.btnnovo.TabIndex = 3;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.Gray;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.Black;
            this.btneditar.Location = new System.Drawing.Point(709, 399);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(114, 39);
            this.btneditar.TabIndex = 4;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.Gray;
            this.btnexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexcluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.ForeColor = System.Drawing.Color.Black;
            this.btnexcluir.Location = new System.Drawing.Point(589, 399);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(114, 39);
            this.btnexcluir.TabIndex = 5;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Procurar:";
            // 
            // txtconsultararea
            // 
            this.txtconsultararea.Location = new System.Drawing.Point(12, 53);
            this.txtconsultararea.Name = "txtconsultararea";
            this.txtconsultararea.Size = new System.Drawing.Size(292, 20);
            this.txtconsultararea.TabIndex = 25;
            this.txtconsultararea.TextChanged += new System.EventHandler(this.txtconsultararea_TextChanged);
            // 
            // idcliente
            // 
            this.idcliente.AutoSize = true;
            this.idcliente.Enabled = false;
            this.idcliente.Location = new System.Drawing.Point(304, 417);
            this.idcliente.Name = "idcliente";
            this.idcliente.Size = new System.Drawing.Size(0, 13);
            this.idcliente.TabIndex = 28;
            // 
            // nomecliente
            // 
            this.nomecliente.AutoSize = true;
            this.nomecliente.Location = new System.Drawing.Point(381, 417);
            this.nomecliente.Name = "nomecliente";
            this.nomecliente.Size = new System.Drawing.Size(0, 13);
            this.nomecliente.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(572, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 451);
            this.panel1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(614, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(614, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Morada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(614, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nº de Contribuinte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(610, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Nº de Telefone";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(617, 95);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(138, 20);
            this.txtnome.TabIndex = 35;
            // 
            // txtmorada
            // 
            this.txtmorada.Location = new System.Drawing.Point(613, 156);
            this.txtmorada.Name = "txtmorada";
            this.txtmorada.Size = new System.Drawing.Size(274, 20);
            this.txtmorada.TabIndex = 36;
            // 
            // txtcontri
            // 
            this.txtcontri.Location = new System.Drawing.Point(613, 221);
            this.txtcontri.Name = "txtcontri";
            this.txtcontri.Size = new System.Drawing.Size(138, 20);
            this.txtcontri.TabIndex = 37;
            this.txtcontri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontri_KeyPress);
            // 
            // txttele
            // 
            this.txttele.Location = new System.Drawing.Point(613, 283);
            this.txttele.Name = "txttele";
            this.txttele.Size = new System.Drawing.Size(138, 20);
            this.txttele.TabIndex = 38;
            this.txttele.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontri_KeyPress);
            // 
            // cbxperfil
            // 
            this.cbxperfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxperfil.Items.AddRange(new object[] {
            "Entidade",
            "Particular"});
            this.cbxperfil.Location = new System.Drawing.Point(613, 343);
            this.cbxperfil.Name = "cbxperfil";
            this.cbxperfil.Size = new System.Drawing.Size(121, 21);
            this.cbxperfil.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(614, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Perfil de Cliente";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(617, 45);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(86, 20);
            this.txtid.TabIndex = 42;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(614, 29);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(21, 17);
            this.ID.TabIndex = 41;
            this.ID.Text = "ID";
            // 
            // Clientes
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
            this.Controls.Add(this.nomecliente);
            this.Controls.Add(this.idcliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtconsultararea);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.dtcliente);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtcliente;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtconsultararea;
        private System.Windows.Forms.Label idcliente;
        private System.Windows.Forms.Label nomecliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtmorada;
        private System.Windows.Forms.TextBox txtcontri;
        private System.Windows.Forms.TextBox txttele;
        private System.Windows.Forms.ComboBox cbxperfil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label ID;
    }
}
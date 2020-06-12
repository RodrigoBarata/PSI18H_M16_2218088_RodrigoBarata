namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms.Forms_principais.Form_configuracoes.sub_area
{
    partial class consultar_subarea
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.txtconsultararea = new System.Windows.Forms.TextBox();
            this.dtsubareas = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnnovo = new System.Windows.Forms.Button();
            this.txtsubarea = new System.Windows.Forms.TextBox();
            this.btnremover = new System.Windows.Forms.Button();
            this.cbxareas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtsubareas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(495, 77);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(94, 20);
            this.txtid.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(492, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Digite a subárea:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 27);
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
            this.btneditar.Location = new System.Drawing.Point(543, 274);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(118, 37);
            this.btneditar.TabIndex = 24;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txtconsultararea
            // 
            this.txtconsultararea.Location = new System.Drawing.Point(161, 51);
            this.txtconsultararea.Name = "txtconsultararea";
            this.txtconsultararea.Size = new System.Drawing.Size(130, 20);
            this.txtconsultararea.TabIndex = 30;
            this.txtconsultararea.TextChanged += new System.EventHandler(this.txtconsultararea_TextChanged);
            // 
            // dtsubareas
            // 
            this.dtsubareas.AllowUserToAddRows = false;
            this.dtsubareas.AllowUserToDeleteRows = false;
            this.dtsubareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtsubareas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtsubareas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtsubareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtsubareas.Location = new System.Drawing.Point(149, 77);
            this.dtsubareas.Name = "dtsubareas";
            this.dtsubareas.ReadOnly = true;
            this.dtsubareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtsubareas.Size = new System.Drawing.Size(306, 359);
            this.dtsubareas.TabIndex = 25;
            this.dtsubareas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtsubareas_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(461, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 421);
            this.panel2.TabIndex = 29;
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnnovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnovo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.Location = new System.Drawing.Point(543, 211);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(118, 37);
            this.btnnovo.TabIndex = 26;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // txtsubarea
            // 
            this.txtsubarea.Location = new System.Drawing.Point(495, 136);
            this.txtsubarea.Name = "txtsubarea";
            this.txtsubarea.Size = new System.Drawing.Size(223, 20);
            this.txtsubarea.TabIndex = 28;
            // 
            // btnremover
            // 
            this.btnremover.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnremover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnremover.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremover.Location = new System.Drawing.Point(543, 344);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(118, 37);
            this.btnremover.TabIndex = 27;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = false;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // cbxareas
            // 
            this.cbxareas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxareas.Location = new System.Drawing.Point(334, 53);
            this.cbxareas.Name = "cbxareas";
            this.cbxareas.Size = new System.Drawing.Size(121, 21);
            this.cbxareas.TabIndex = 37;
            this.cbxareas.SelectedIndexChanged += new System.EventHandler(this.cbxareas_SelectedIndexChanged);
            // 
            // consultar_subarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxareas);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.txtconsultararea);
            this.Controls.Add(this.dtsubareas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.txtsubarea);
            this.Controls.Add(this.btnremover);
            this.Name = "consultar_subarea";
            this.Text = "consultar_subarea";
            ((System.ComponentModel.ISupportInitialize)(this.dtsubareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.TextBox txtconsultararea;
        private System.Windows.Forms.DataGridView dtsubareas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.TextBox txtsubarea;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.ComboBox cbxareas;
    }
}
namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms.Forms_principais.Form_configuracoes.Área
{
    partial class consultar_areas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtconsultararea = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.btnremover = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.dtareas = new System.Windows.Forms.DataGridView();
            this.btneditar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtareas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtconsultararea);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtarea);
            this.panel1.Controls.Add(this.btnremover);
            this.panel1.Controls.Add(this.btnnovo);
            this.panel1.Controls.Add(this.dtareas);
            this.panel1.Controls.Add(this.btneditar);
            this.panel1.Location = new System.Drawing.Point(130, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 424);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Digite a área:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Procurar:";
            // 
            // txtconsultararea
            // 
            this.txtconsultararea.Location = new System.Drawing.Point(16, 36);
            this.txtconsultararea.Name = "txtconsultararea";
            this.txtconsultararea.Size = new System.Drawing.Size(130, 20);
            this.txtconsultararea.TabIndex = 17;
            this.txtconsultararea.TextChanged += new System.EventHandler(this.txtconsultararea_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(249, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 421);
            this.panel2.TabIndex = 16;
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(283, 121);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(223, 20);
            this.txtarea.TabIndex = 15;
            // 
            // btnremover
            // 
            this.btnremover.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnremover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnremover.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremover.Location = new System.Drawing.Point(331, 329);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(118, 37);
            this.btnremover.TabIndex = 14;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = false;
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnnovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnovo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.Location = new System.Drawing.Point(331, 196);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(118, 37);
            this.btnnovo.TabIndex = 13;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // dtareas
            // 
            this.dtareas.AllowUserToAddRows = false;
            this.dtareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtareas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtareas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtareas.Location = new System.Drawing.Point(3, 62);
            this.dtareas.Name = "dtareas";
            this.dtareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtareas.Size = new System.Drawing.Size(240, 359);
            this.dtareas.TabIndex = 10;
            this.dtareas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtareas_MouseClick);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(331, 259);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(118, 37);
            this.btneditar.TabIndex = 6;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // consultar_areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 448);
            this.Controls.Add(this.panel1);
            this.Name = "consultar_areas";
            this.Text = "consultar_areas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtareas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.DataGridView dtareas;
        private System.Windows.Forms.TextBox txtconsultararea;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
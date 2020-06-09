namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms
{
    partial class Cursos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearchcursos = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.dtcursos = new System.Windows.Forms.DataGridView();
            this.btnnovo = new System.Windows.Forms.Button();
            this.txtcurso = new System.Windows.Forms.TextBox();
            this.btnremover = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.cbxareas = new System.Windows.Forms.ComboBox();
            this.cbxsubarea = new System.Windows.Forms.ComboBox();
            this.Área = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtcursos)).BeginInit();
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
            this.btnsearch.Location = new System.Drawing.Point(148, 42);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Rotation = 0D;
            this.btnsearch.Size = new System.Drawing.Size(34, 23);
            this.btnsearch.TabIndex = 27;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Procurar:";
            // 
            // txtsearchcursos
            // 
            this.txtsearchcursos.Location = new System.Drawing.Point(12, 42);
            this.txtsearchcursos.Name = "txtsearchcursos";
            this.txtsearchcursos.Size = new System.Drawing.Size(130, 20);
            this.txtsearchcursos.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(612, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 421);
            this.panel2.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(628, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(625, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Digite o curso:";
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(715, 284);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(118, 37);
            this.btneditar.TabIndex = 28;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // dtcursos
            // 
            this.dtcursos.AllowUserToAddRows = false;
            this.dtcursos.AllowUserToDeleteRows = false;
            this.dtcursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtcursos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtcursos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtcursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtcursos.Location = new System.Drawing.Point(12, 71);
            this.dtcursos.Name = "dtcursos";
            this.dtcursos.ReadOnly = true;
            this.dtcursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtcursos.Size = new System.Drawing.Size(594, 359);
            this.dtcursos.TabIndex = 29;
            this.dtcursos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtcursos_MouseClick);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnnovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnovo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.Location = new System.Drawing.Point(715, 231);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(118, 37);
            this.btnnovo.TabIndex = 30;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // txtcurso
            // 
            this.txtcurso.Location = new System.Drawing.Point(631, 91);
            this.txtcurso.Multiline = true;
            this.txtcurso.Name = "txtcurso";
            this.txtcurso.Size = new System.Drawing.Size(300, 134);
            this.txtcurso.TabIndex = 32;
            // 
            // btnremover
            // 
            this.btnremover.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnremover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnremover.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremover.Location = new System.Drawing.Point(715, 345);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(118, 37);
            this.btnremover.TabIndex = 31;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = false;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(628, 44);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(94, 20);
            this.txtid.TabIndex = 37;
            // 
            // cbxareas
            // 
            this.cbxareas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxareas.Location = new System.Drawing.Point(297, 44);
            this.cbxareas.Name = "cbxareas";
            this.cbxareas.Size = new System.Drawing.Size(121, 21);
            this.cbxareas.TabIndex = 38;
            this.cbxareas.SelectedIndexChanged += new System.EventHandler(this.cbxareas_SelectedIndexChanged);
            // 
            // cbxsubarea
            // 
            this.cbxsubarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxsubarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxsubarea.Location = new System.Drawing.Point(437, 44);
            this.cbxsubarea.Name = "cbxsubarea";
            this.cbxsubarea.Size = new System.Drawing.Size(121, 21);
            this.cbxsubarea.TabIndex = 39;
            this.cbxsubarea.SelectedIndexChanged += new System.EventHandler(this.cbxsubarea_SelectedIndexChanged);
            // 
            // Área
            // 
            this.Área.AutoSize = true;
            this.Área.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Área.Location = new System.Drawing.Point(294, 24);
            this.Área.Name = "Área";
            this.Área.Size = new System.Drawing.Size(38, 17);
            this.Área.TabIndex = 40;
            this.Área.Text = "Área";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Subárea";
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Área);
            this.Controls.Add(this.cbxsubarea);
            this.Controls.Add(this.cbxareas);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.dtcursos);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.txtcurso);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsearchcursos);
            this.Controls.Add(this.panel2);
            this.Name = "Cursos";
            this.Text = "FormCursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtcursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearchcursos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.DataGridView dtcursos;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.TextBox txtcurso;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox cbxareas;
        private System.Windows.Forms.ComboBox cbxsubarea;
        private System.Windows.Forms.Label Área;
        private System.Windows.Forms.Label label5;
    }
}
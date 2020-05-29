namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms
{
    partial class confi
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnusers = new System.Windows.Forms.Button();
            this.btnsubarea = new System.Windows.Forms.Button();
            this.btnarea = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnusers);
            this.panel1.Controls.Add(this.btnsubarea);
            this.panel1.Controls.Add(this.btnarea);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 489);
            this.panel1.TabIndex = 1;
            // 
            // btnusers
            // 
            this.btnusers.FlatAppearance.BorderSize = 0;
            this.btnusers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusers.ForeColor = System.Drawing.Color.White;
            this.btnusers.Location = new System.Drawing.Point(-3, 262);
            this.btnusers.Name = "btnusers";
            this.btnusers.Size = new System.Drawing.Size(140, 36);
            this.btnusers.TabIndex = 2;
            this.btnusers.Text = "Utlilizadores";
            this.btnusers.UseVisualStyleBackColor = true;
            // 
            // btnsubarea
            // 
            this.btnsubarea.FlatAppearance.BorderSize = 0;
            this.btnsubarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubarea.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubarea.ForeColor = System.Drawing.Color.White;
            this.btnsubarea.Location = new System.Drawing.Point(0, 208);
            this.btnsubarea.Name = "btnsubarea";
            this.btnsubarea.Size = new System.Drawing.Size(140, 36);
            this.btnsubarea.TabIndex = 1;
            this.btnsubarea.Text = "Subáreas";
            this.btnsubarea.UseVisualStyleBackColor = true;
            // 
            // btnarea
            // 
            this.btnarea.FlatAppearance.BorderSize = 0;
            this.btnarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnarea.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnarea.ForeColor = System.Drawing.Color.White;
            this.btnarea.Location = new System.Drawing.Point(0, 157);
            this.btnarea.Name = "btnarea";
            this.btnarea.Size = new System.Drawing.Size(140, 36);
            this.btnarea.TabIndex = 0;
            this.btnarea.Text = "Áreas";
            this.btnarea.UseVisualStyleBackColor = true;
            this.btnarea.Click += new System.EventHandler(this.btnarea_Click);
            // 
            // confi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "confi";
            this.Size = new System.Drawing.Size(816, 489);
            this.Load += new System.EventHandler(this.confi_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnusers;
        private System.Windows.Forms.Button btnsubarea;
        private System.Windows.Forms.Button btnarea;
    }
}

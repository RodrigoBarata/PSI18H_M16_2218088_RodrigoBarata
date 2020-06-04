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
            this.cbxarea = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbxarea
            // 
            this.cbxarea.FormattingEnabled = true;
            this.cbxarea.Location = new System.Drawing.Point(377, 196);
            this.cbxarea.Name = "cbxarea";
            this.cbxarea.Size = new System.Drawing.Size(121, 21);
            this.cbxarea.TabIndex = 0;
            // 
            // consultar_subarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxarea);
            this.Name = "consultar_subarea";
            this.Text = "consultar_subarea";
            this.Load += new System.EventHandler(this.consultar_subarea_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxarea;
    }
}
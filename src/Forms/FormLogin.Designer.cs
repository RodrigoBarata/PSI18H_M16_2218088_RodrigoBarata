namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms
{
    partial class Login
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
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.btnregistar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(258, 115);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(92, 21);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Username:";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(258, 188);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(86, 21);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "Password:";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(262, 139);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(232, 20);
            this.txtusername.TabIndex = 2;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(262, 212);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(232, 20);
            this.txtpassword.TabIndex = 3;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnconfirmar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirmar.Location = new System.Drawing.Point(282, 247);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(191, 37);
            this.btnconfirmar.TabIndex = 4;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            // 
            // btnregistar
            // 
            this.btnregistar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnregistar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregistar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistar.Location = new System.Drawing.Point(308, 290);
            this.btnregistar.Name = "btnregistar";
            this.btnregistar.Size = new System.Drawing.Size(137, 37);
            this.btnregistar.TabIndex = 5;
            this.btnregistar.Text = "Registar";
            this.btnregistar.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnregistar);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Name = "Login";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Button btnregistar;
    }
}
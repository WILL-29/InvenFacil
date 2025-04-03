namespace InvenFacil
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.TbPass = new System.Windows.Forms.TextBox();
            this.LbPass = new System.Windows.Forms.Label();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.LbUsername = new System.Windows.Forms.Label();
            this.BtAcceder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbPass
            // 
            this.TbPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TbPass.Location = new System.Drawing.Point(126, 83);
            this.TbPass.Name = "TbPass";
            this.TbPass.PasswordChar = '*';
            this.TbPass.Size = new System.Drawing.Size(130, 20);
            this.TbPass.TabIndex = 56;
            // 
            // LbPass
            // 
            this.LbPass.AutoSize = true;
            this.LbPass.Location = new System.Drawing.Point(52, 86);
            this.LbPass.Name = "LbPass";
            this.LbPass.Size = new System.Drawing.Size(61, 13);
            this.LbPass.TabIndex = 55;
            this.LbPass.Text = "Contraseña";
            // 
            // TbUsername
            // 
            this.TbUsername.Location = new System.Drawing.Point(126, 46);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(130, 20);
            this.TbUsername.TabIndex = 54;
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.Location = new System.Drawing.Point(52, 49);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(43, 13);
            this.LbUsername.TabIndex = 53;
            this.LbUsername.Text = "Usuario";
            // 
            // BtAcceder
            // 
            this.BtAcceder.Location = new System.Drawing.Point(109, 132);
            this.BtAcceder.Name = "BtAcceder";
            this.BtAcceder.Size = new System.Drawing.Size(75, 23);
            this.BtAcceder.TabIndex = 57;
            this.BtAcceder.Text = "Acceder";
            this.BtAcceder.UseVisualStyleBackColor = true;
            this.BtAcceder.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(298, 193);
            this.Controls.Add(this.BtAcceder);
            this.Controls.Add(this.TbPass);
            this.Controls.Add(this.LbPass);
            this.Controls.Add(this.TbUsername);
            this.Controls.Add(this.LbUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbPass;
        private System.Windows.Forms.Label LbPass;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.Button BtAcceder;
    }
}
namespace Project.ClinicReception.Forms
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbResult = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.btExit = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(82, 49);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(166, 20);
            this.tbPassword.TabIndex = 24;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(82, 11);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(166, 20);
            this.tbLogin.TabIndex = 23;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(21, 51);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 22;
            this.lbPassword.Text = "Password";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(40, 13);
            this.lbLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(33, 13);
            this.lbLogin.TabIndex = 21;
            this.lbLogin.Text = "Login";
            // 
            // errorLabel
            // 
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(270, 91);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 13);
            this.lbResult.TabIndex = 28;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.errorLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 123);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip.Size = new System.Drawing.Size(417, 22);
            this.statusStrip.TabIndex = 27;
            // 
            // btExit
            // 
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.Location = new System.Drawing.Point(273, 48);
            this.btExit.Margin = new System.Windows.Forms.Padding(2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(79, 20);
            this.btExit.TabIndex = 26;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(273, 8);
            this.btLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(79, 20);
            this.btLogin.TabIndex = 25;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 145);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogin);
            this.Name = "LoginForm";
            this.Text = "Log In";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.ToolStripStatusLabel errorLabel;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btLogin;
    }
}
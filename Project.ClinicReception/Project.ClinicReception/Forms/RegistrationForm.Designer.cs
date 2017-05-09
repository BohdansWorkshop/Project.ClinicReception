namespace Project.ClinicReception.Forms
{
    partial class RegistrationForm
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
            this.lbResult = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(65, 59);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(166, 20);
            this.tbPassword.TabIndex = 32;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(65, 21);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(166, 20);
            this.tbLogin.TabIndex = 31;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(4, 61);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 30;
            this.lbPassword.Text = "Password";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(23, 23);
            this.lbLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(33, 13);
            this.lbLogin.TabIndex = 29;
            this.lbLogin.Text = "Login";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(253, 101);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 13);
            this.lbResult.TabIndex = 35;
            // 
            // btExit
            // 
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.Location = new System.Drawing.Point(152, 118);
            this.btExit.Margin = new System.Windows.Forms.Padding(2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(79, 20);
            this.btExit.TabIndex = 34;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(65, 118);
            this.btCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(79, 20);
            this.btCreate.TabIndex = 33;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 189);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCreate);
            this.Name = "RegistrationForm";
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btCreate;
    }
}
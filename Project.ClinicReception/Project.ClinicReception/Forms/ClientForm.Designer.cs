namespace Project.ClinicReception.Forms
{
    partial class ClientForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(45, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(224, 20);
            this.tbName.TabIndex = 1;
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.dtpCreateDate);
            this.gbGeneral.Controls.Add(this.lbDate);
            this.gbGeneral.Controls.Add(this.lbPhone);
            this.gbGeneral.Controls.Add(this.tbPhone);
            this.gbGeneral.Controls.Add(this.nudAge);
            this.gbGeneral.Controls.Add(this.label3);
            this.gbGeneral.Controls.Add(this.cbSex);
            this.gbGeneral.Controls.Add(this.label2);
            this.gbGeneral.Controls.Add(this.label1);
            this.gbGeneral.Controls.Add(this.tbName);
            this.gbGeneral.Location = new System.Drawing.Point(12, 12);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(318, 208);
            this.gbGeneral.TabIndex = 14;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "General information";
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCreateDate.Location = new System.Drawing.Point(38, 136);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.ShowUpDown = true;
            this.dtpCreateDate.Size = new System.Drawing.Size(84, 20);
            this.dtpCreateDate.TabIndex = 15;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(1, 140);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(30, 13);
            this.lbDate.TabIndex = 14;
            this.lbDate.Text = "Date";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(1, 80);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(38, 13);
            this.lbPhone.TabIndex = 9;
            this.lbPhone.Text = "Phone";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(49, 73);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(220, 20);
            this.tbPhone.TabIndex = 8;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(224, 46);
            this.nudAge.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(45, 20);
            this.nudAge.TabIndex = 5;
            this.nudAge.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age";
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(64, 46);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(97, 21);
            this.cbSex.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sex";
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(257, 251);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(73, 23);
            this.btCancel.TabIndex = 16;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(178, 251);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(73, 23);
            this.btOk.TabIndex = 15;
            this.btOk.Text = "Add";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(Project.ClinicReception.ReceptionReference.Doctor);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 285);
            this.Controls.Add(this.gbGeneral);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Name = "ClientForm";
            this.Text = "Add Client";
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.BindingSource doctorBindingSource;

        private System.Windows.Forms.BindingSource doctorsBindingSource;
    }
}
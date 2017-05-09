namespace Project.ClinicReception.Forms
{
    partial class OrderForm
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbCabinet = new System.Windows.Forms.TextBox();
            this.lbCabinet = new System.Windows.Forms.Label();
            this.lbDestination = new System.Windows.Forms.Label();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aRT2ProjectClinicReceptionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.gbGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRT2ProjectClinicReceptionDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(257, 251);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(73, 23);
            this.btCancel.TabIndex = 19;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(178, 251);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(73, 23);
            this.btOk.TabIndex = 18;
            this.btOk.Text = "Add";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCreateDate.Location = new System.Drawing.Point(59, 164);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.ShowUpDown = true;
            this.dtpCreateDate.Size = new System.Drawing.Size(84, 20);
            this.dtpCreateDate.TabIndex = 15;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(22, 168);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(30, 13);
            this.lbDate.TabIndex = 14;
            this.lbDate.Text = "Date";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(29, 131);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 13);
            this.lbPrice.TabIndex = 12;
            this.lbPrice.Text = "Price";
            // 
            // tbCabinet
            // 
            this.tbCabinet.Location = new System.Drawing.Point(66, 98);
            this.tbCabinet.Name = "tbCabinet";
            this.tbCabinet.Size = new System.Drawing.Size(97, 20);
            this.tbCabinet.TabIndex = 11;
            // 
            // lbCabinet
            // 
            this.lbCabinet.AutoSize = true;
            this.lbCabinet.Location = new System.Drawing.Point(17, 105);
            this.lbCabinet.Name = "lbCabinet";
            this.lbCabinet.Size = new System.Drawing.Size(43, 13);
            this.lbCabinet.TabIndex = 10;
            this.lbCabinet.Text = "Cabinet";
            // 
            // lbDestination
            // 
            this.lbDestination.AutoSize = true;
            this.lbDestination.Location = new System.Drawing.Point(17, 49);
            this.lbDestination.Name = "lbDestination";
            this.lbDestination.Size = new System.Drawing.Size(39, 13);
            this.lbDestination.TabIndex = 7;
            this.lbDestination.Text = "Doctor";
            // 
            // cbDoctor
            // 
            this.cbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(66, 45);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(97, 21);
            this.cbDoctor.TabIndex = 6;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(Project.ClinicReception.ReceptionReference.Doctor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.tbTime);
            this.gbGeneral.Controls.Add(this.label2);
            this.gbGeneral.Controls.Add(this.cbClient);
            this.gbGeneral.Controls.Add(this.dtpCreateDate);
            this.gbGeneral.Controls.Add(this.lbDate);
            this.gbGeneral.Controls.Add(this.nudPrice);
            this.gbGeneral.Controls.Add(this.lbPrice);
            this.gbGeneral.Controls.Add(this.tbCabinet);
            this.gbGeneral.Controls.Add(this.lbCabinet);
            this.gbGeneral.Controls.Add(this.lbDestination);
            this.gbGeneral.Controls.Add(this.cbDoctor);
            this.gbGeneral.Controls.Add(this.label1);
            this.gbGeneral.Location = new System.Drawing.Point(12, 12);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(318, 208);
            this.gbGeneral.TabIndex = 17;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "General information";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(66, 75);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(97, 20);
            this.tbTime.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Time";
            // 
            // cbClient
            // 
            this.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(66, 19);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(97, 21);
            this.cbClient.TabIndex = 16;
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(66, 129);
            this.nudPrice.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(45, 20);
            this.nudPrice.TabIndex = 13;
            this.nudPrice.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 281);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.gbGeneral);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRT2ProjectClinicReceptionDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox tbCabinet;
        private System.Windows.Forms.Label lbCabinet;
        private System.Windows.Forms.Label lbDestination;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource aRT2ProjectClinicReceptionDataSetBindingSource;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.TextBox tbTime;
    }
}
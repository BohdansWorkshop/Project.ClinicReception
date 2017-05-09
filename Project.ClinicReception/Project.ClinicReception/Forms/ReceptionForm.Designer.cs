namespace Project.ClinicReception
{
    partial class ReceptionForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.tabDoctors = new System.Windows.Forms.TabPage();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.addToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(764, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "File";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.addToolStripMenuItem1.Text = "Exit";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.addToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scMain.IsSplitterFixed = true;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Margin = new System.Windows.Forms.Padding(2);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.tabControl);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.statusStrip);
            this.scMain.Size = new System.Drawing.Size(764, 368);
            this.scMain.SplitterDistance = 340;
            this.scMain.SplitterWidth = 3;
            this.scMain.TabIndex = 5;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabClients);
            this.tabControl.Controls.Add(this.tabDoctors);
            this.tabControl.Controls.Add(this.tabOrders);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(764, 322);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabClients
            // 
            this.tabClients.Location = new System.Drawing.Point(4, 22);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(756, 296);
            this.tabClients.TabIndex = 1;
            this.tabClients.Text = "Clients";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // tabDoctors
            // 
            this.tabDoctors.Location = new System.Drawing.Point(4, 22);
            this.tabDoctors.Name = "tabDoctors";
            this.tabDoctors.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoctors.Size = new System.Drawing.Size(756, 296);
            this.tabDoctors.TabIndex = 2;
            this.tabDoctors.Text = "Doctors";
            this.tabDoctors.UseVisualStyleBackColor = true;
            // 
            // tabOrders
            // 
            this.tabOrders.Location = new System.Drawing.Point(4, 22);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(756, 296);
            this.tabOrders.TabIndex = 3;
            this.tabOrders.Text = "Orders";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 3);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip.Size = new System.Drawing.Size(764, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewAccountToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // createNewAccountToolStripMenuItem
            // 
            this.createNewAccountToolStripMenuItem.Name = "createNewAccountToolStripMenuItem";
            this.createNewAccountToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.createNewAccountToolStripMenuItem.Text = "Create new account";
            this.createNewAccountToolStripMenuItem.Click += new System.EventHandler(this.createNewAccountToolStripMenuItem_Click);
            // 
            // ReceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 368);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.scMain);
            this.Name = "ReceptionForm";
            this.Text = "Reception";
            this.Load += new System.EventHandler(this.ReceptionForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tabDoctors;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewAccountToolStripMenuItem;
    }
}


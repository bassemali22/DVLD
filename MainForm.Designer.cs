namespace First_project
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realesDetainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acoountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.drivesToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.acoountSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingToolStripMenuItem,
            this.manageAToolStripMenuItem,
            this.detainToolStripMenuItem,
            this.manageApplicationTypeToolStripMenuItem,
            this.manageTestTypeToolStripMenuItem});
            this.applicationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationsToolStripMenuItem.Image = global::First_project.Properties.Resources.Book;
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(134, 25);
            this.applicationsToolStripMenuItem.Text = "Applications";
            this.applicationsToolStripMenuItem.Click += new System.EventHandler(this.applicationsToolStripMenuItem_Click);
            // 
            // drivingToolStripMenuItem
            // 
            this.drivingToolStripMenuItem.Image = global::First_project.Properties.Resources.Pen;
            this.drivingToolStripMenuItem.Name = "drivingToolStripMenuItem";
            this.drivingToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.drivingToolStripMenuItem.Text = "Driving Licenss Local";
            this.drivingToolStripMenuItem.Click += new System.EventHandler(this.drivingToolStripMenuItem_Click);
            // 
            // manageAToolStripMenuItem
            // 
            this.manageAToolStripMenuItem.Name = "manageAToolStripMenuItem";
            this.manageAToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.manageAToolStripMenuItem.Text = "Manage Application";
            // 
            // detainToolStripMenuItem
            // 
            this.detainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainLicensesToolStripMenuItem,
            this.detainLicensesToolStripMenuItem,
            this.realesDetainLicensesToolStripMenuItem});
            this.detainToolStripMenuItem.Name = "detainToolStripMenuItem";
            this.detainToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.detainToolStripMenuItem.Text = "Detain Licenses";
            this.detainToolStripMenuItem.Click += new System.EventHandler(this.detainToolStripMenuItem_Click);
            // 
            // manageDetainLicensesToolStripMenuItem
            // 
            this.manageDetainLicensesToolStripMenuItem.Name = "manageDetainLicensesToolStripMenuItem";
            this.manageDetainLicensesToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.manageDetainLicensesToolStripMenuItem.Text = "Manage Detain Licenses";
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // realesDetainLicensesToolStripMenuItem
            // 
            this.realesDetainLicensesToolStripMenuItem.Name = "realesDetainLicensesToolStripMenuItem";
            this.realesDetainLicensesToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.realesDetainLicensesToolStripMenuItem.Text = "Reales Detain Licenses";
            // 
            // manageApplicationTypeToolStripMenuItem
            // 
            this.manageApplicationTypeToolStripMenuItem.Name = "manageApplicationTypeToolStripMenuItem";
            this.manageApplicationTypeToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.manageApplicationTypeToolStripMenuItem.Text = "Manage ApplicationType";
            // 
            // manageTestTypeToolStripMenuItem
            // 
            this.manageTestTypeToolStripMenuItem.Name = "manageTestTypeToolStripMenuItem";
            this.manageTestTypeToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.manageTestTypeToolStripMenuItem.Text = "Manage Test Type";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleToolStripMenuItem.Image = global::First_project.Properties.Resources.Boy;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // drivesToolStripMenuItem
            // 
            this.drivesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivesToolStripMenuItem.Image = global::First_project.Properties.Resources.Pen;
            this.drivesToolStripMenuItem.Name = "drivesToolStripMenuItem";
            this.drivesToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.drivesToolStripMenuItem.Text = "Drives";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Image = global::First_project.Properties.Resources.Girl;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // acoountSettingsToolStripMenuItem
            // 
            this.acoountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentToolStripMenuItem,
            this.changPasswordToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.acoountSettingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acoountSettingsToolStripMenuItem.Image = global::First_project.Properties.Resources.Pen;
            this.acoountSettingsToolStripMenuItem.Name = "acoountSettingsToolStripMenuItem";
            this.acoountSettingsToolStripMenuItem.Size = new System.Drawing.Size(169, 25);
            this.acoountSettingsToolStripMenuItem.Text = "Acoount Settings";
            // 
            // currentToolStripMenuItem
            // 
            this.currentToolStripMenuItem.Name = "currentToolStripMenuItem";
            this.currentToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.currentToolStripMenuItem.Text = "Current User Info";
            this.currentToolStripMenuItem.Click += new System.EventHandler(this.currentToolStripMenuItem_Click);
            // 
            // changPasswordToolStripMenuItem
            // 
            this.changPasswordToolStripMenuItem.Name = "changPasswordToolStripMenuItem";
            this.changPasswordToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.changPasswordToolStripMenuItem.Text = "Chang Password";
            this.changPasswordToolStripMenuItem.Click += new System.EventHandler(this.changPasswordToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acoountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realesDetainLicensesToolStripMenuItem;
    }
}


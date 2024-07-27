namespace First_project.Users
{
    partial class FrmUsersList
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
            this.dgvUserInfo = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtShowUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.callToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUserInfo
            // 
            this.dgvUserInfo.AllowUserToAddRows = false;
            this.dgvUserInfo.AllowUserToDeleteRows = false;
            this.dgvUserInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserInfo.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUserInfo.Location = new System.Drawing.Point(1, 217);
            this.dgvUserInfo.Name = "dgvUserInfo";
            this.dgvUserInfo.ReadOnly = true;
            this.dgvUserInfo.Size = new System.Drawing.Size(1435, 407);
            this.dgvUserInfo.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtShowUserInfo,
            this.txtEdit,
            this.txtDelete,
            this.callToolStripMenuItem,
            this.sendEmailToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 114);
            // 
            // txtShowUserInfo
            // 
            this.txtShowUserInfo.Name = "txtShowUserInfo";
            this.txtShowUserInfo.Size = new System.Drawing.Size(153, 22);
            this.txtShowUserInfo.Text = "Show User Info";
            this.txtShowUserInfo.Click += new System.EventHandler(this.txtShowUserInfo_Click);
            // 
            // txtEdit
            // 
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(153, 22);
            this.txtEdit.Text = "Edit";
            // 
            // txtDelete
            // 
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(153, 22);
            this.txtDelete.Text = "Delete";
            // 
            // callToolStripMenuItem
            // 
            this.callToolStripMenuItem.Name = "callToolStripMenuItem";
            this.callToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.callToolStripMenuItem.Text = "Call";
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(1212, 133);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(191, 60);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // FrmUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 622);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dgvUserInfo);
            this.Name = "FrmUsersList";
            this.Text = "FrmUsersList";
            this.Load += new System.EventHandler(this.FrmUsersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem txtShowUserInfo;
        private System.Windows.Forms.ToolStripMenuItem txtEdit;
        private System.Windows.Forms.ToolStripMenuItem txtDelete;
        private System.Windows.Forms.ToolStripMenuItem callToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.Button btnAddNew;
    }
}
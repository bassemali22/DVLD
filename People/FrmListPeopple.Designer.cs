namespace First_project.People
{
    partial class FrmListPeopple
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
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecordNumber = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlsmShowInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsmEditPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsmDeletePerons = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsmCallPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsmSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Location = new System.Drawing.Point(0, 275);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPeople.Size = new System.Drawing.Size(1391, 454);
            this.dgvPeople.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1235, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(560, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 169);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(579, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mange People";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 745);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "# Record:";
            // 
            // lblRecordNumber
            // 
            this.lblRecordNumber.AutoSize = true;
            this.lblRecordNumber.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordNumber.Location = new System.Drawing.Point(181, 745);
            this.lblRecordNumber.Name = "lblRecordNumber";
            this.lblRecordNumber.Size = new System.Drawing.Size(65, 32);
            this.lblRecordNumber.TabIndex = 5;
            this.lblRecordNumber.Text = "???";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsmShowInfo,
            this.tlsmEditPerson,
            this.tlsmDeletePerons,
            this.tlsmCallPerson,
            this.tlsmSendEmail});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 136);
            // 
            // tlsmShowInfo
            // 
            this.tlsmShowInfo.Name = "tlsmShowInfo";
            this.tlsmShowInfo.Size = new System.Drawing.Size(180, 22);
            this.tlsmShowInfo.Text = "Show Info";
            this.tlsmShowInfo.Click += new System.EventHandler(this.tlsmShowInfo_Click);
            // 
            // tlsmEditPerson
            // 
            this.tlsmEditPerson.Name = "tlsmEditPerson";
            this.tlsmEditPerson.Size = new System.Drawing.Size(180, 22);
            this.tlsmEditPerson.Text = "Edit";
            this.tlsmEditPerson.Click += new System.EventHandler(this.tlsmEditPerson_Click);
            // 
            // tlsmDeletePerons
            // 
            this.tlsmDeletePerons.Name = "tlsmDeletePerons";
            this.tlsmDeletePerons.Size = new System.Drawing.Size(180, 22);
            this.tlsmDeletePerons.Text = "Delete";
            this.tlsmDeletePerons.Click += new System.EventHandler(this.tlsmDeletePerons_Click);
            // 
            // tlsmCallPerson
            // 
            this.tlsmCallPerson.Name = "tlsmCallPerson";
            this.tlsmCallPerson.Size = new System.Drawing.Size(180, 22);
            this.tlsmCallPerson.Text = "Call";
            // 
            // tlsmSendEmail
            // 
            this.tlsmSendEmail.Name = "tlsmSendEmail";
            this.tlsmSendEmail.Size = new System.Drawing.Size(180, 22);
            this.tlsmSendEmail.Text = "Send Email";
            // 
            // FrmListPeopple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 797);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblRecordNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPeople);
            this.Name = "FrmListPeopple";
            this.Text = "ListPeopple";
            this.Load += new System.EventHandler(this.ListPeopple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecordNumber;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tlsmShowInfo;
        private System.Windows.Forms.ToolStripMenuItem tlsmEditPerson;
        private System.Windows.Forms.ToolStripMenuItem tlsmDeletePerons;
        private System.Windows.Forms.ToolStripMenuItem tlsmCallPerson;
        private System.Windows.Forms.ToolStripMenuItem tlsmSendEmail;
    }
}
namespace First_project.People.Controls
{
    partial class ctrlPersonCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ctrlPersonCard1 = new First_project.People.Controls.ctrlPersonCard();
            this.grbFillter = new System.Windows.Forms.GroupBox();
            this.grbFillter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter By";
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo"});
            this.cbFilter.Location = new System.Drawing.Point(76, 28);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(173, 21);
            this.cbFilter.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::First_project.Properties.Resources.Boy;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Location = new System.Drawing.Point(491, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(53, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Location = new System.Drawing.Point(263, 28);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(202, 20);
            this.txtFilterBy.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::First_project.Properties.Resources.Girl;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(551, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 39);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 86);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(657, 271);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // grbFillter
            // 
            this.grbFillter.Controls.Add(this.btnSave);
            this.grbFillter.Controls.Add(this.button2);
            this.grbFillter.Controls.Add(this.label1);
            this.grbFillter.Controls.Add(this.txtFilterBy);
            this.grbFillter.Controls.Add(this.cbFilter);
            this.grbFillter.Location = new System.Drawing.Point(0, 3);
            this.grbFillter.Name = "grbFillter";
            this.grbFillter.Size = new System.Drawing.Size(665, 80);
            this.grbFillter.TabIndex = 6;
            this.grbFillter.TabStop = false;
            this.grbFillter.Text = "groupBox1";
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbFillter);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "ctrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(668, 360);
            this.Load += new System.EventHandler(this.ctrlPersonCardWithFilter_Load);
            this.grbFillter.ResumeLayout(false);
            this.grbFillter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFilterBy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grbFillter;
    }
}

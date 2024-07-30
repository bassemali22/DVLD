using First_project.GlobalClasses;
using First_project.People;
using First_project.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace First_project
{
    public partial class frmMainForm : Form
    {
        private Form _Frm;
        public frmMainForm( frmloginScreen frm )
        {
            InitializeComponent();
            _Frm = frm; 
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmListPeopple();
            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.User = null;
            _Frm.ShowDialog();
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form frm = new FrmUsersList();
            frm.ShowDialog(); 
        }

        private void drivingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void detainToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChagePassword frm = new FrmChagePassword(clsGlobal.User.UserID);
            frm.ShowDialog();
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserInfo frm = new FrmUserInfo(1);
            frm.ShowDialog();   
        }
    }
}

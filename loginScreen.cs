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
    public partial class loginScreen : Form
    {
        public loginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new MainForm();
            frm .ShowDialog();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserName.Text)) 
            {
              e.Cancel = true;
              txtUserName.Focus();
                errorProvider1.SetError(txtUserName, "Please Enter the userName Right");
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(txtUserName, "");
            }
        }

        private void txtPassWord_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassWord.Text))
            {
                e.Cancel = true;
                txtPassWord.Focus();
                errorProvider1.SetError(txtUserName, "Please Enter the userName Right");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassWord, "");
            }
        }
    }
}

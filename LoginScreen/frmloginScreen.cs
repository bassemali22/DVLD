using Bissnus_Layer;
using First_project.GlobalClasses;
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
    public partial class frmloginScreen : Form
    {
        public frmloginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             clsUsers User = clsUsers.FindUserByUserNameAndPassword(txtUserName.Text.Trim(), txtPassWord.Text.Trim());
            {
                if(User!= null)
                {
                    clsGlobal.User = User;
                    this.Hide();
                    frmMainForm frm = new frmMainForm(this);
                    frm.ShowDialog();
                }
                if(!User.IsActive)
                {
                    txtUserName.Focus();
                    MessageBox.Show("Your Account Is Not Active, Contact Admin");
                    return;
                }
              
            }
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

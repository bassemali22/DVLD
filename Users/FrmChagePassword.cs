using Bissnus_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace First_project.Users
{
    public partial class FrmChagePassword : Form
    {
        private clsUsers _User;
        private int _UserID;
        public FrmChagePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;  

        }
        private void FrmChagePassword_Load(object sender, EventArgs e)
        {
            _RestDefaultValue();
            _User = clsUsers.FindUserByUserID (_UserID);
            if(_User == null)
            {
                
                MessageBox.Show("not user found");
                this.Close();   
                return;
            }
            ctrlUserCard1.LoadUserInfo(_UserID);
        }

        private void txtCuurentPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtCuurentPassword.Text.Trim())) 
            {
               e.Cancel = true;
                errorProvider1.SetError(txtCuurentPassword, "user cann,t be empty");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCuurentPassword,null);

            }
            if(_User.Password != txtCuurentPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCuurentPassword, "Current Password is Wrong");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCuurentPassword, null);

            }
        }
        private void _RestDefaultValue()
        {
            txtCuurentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            { 
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "New Password Cann,t Be Empty");
                return ;
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null) ;

            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password Cann,t Be Empty ");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);

            }
            if(txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel= true;
                errorProvider1.SetError(txtConfirmPassword, "Bhould Be the Same Password ");

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _User.Password= txtNewPassword.Text.Trim();
            if(_User.Save())
            {
                MessageBox.Show("Password Change Successfuly ");
                _RestDefaultValue();
            }
            else
            {
                MessageBox.Show("Password did not Chaneg  ");

            }
        }
    }
}

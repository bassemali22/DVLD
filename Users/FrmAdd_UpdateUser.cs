using Bissnus_Layer;
using First_project.People.Controls;
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
    public partial class FrmAdd_UpdateUser : Form
    {
        public enum enMode { AddUser = 0, UpdateUser = 1 };
        private enMode _Mode;
        private int _UserID;
        private clsUsers _User;
        public FrmAdd_UpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddUser;

        }
        public FrmAdd_UpdateUser(int UserID)
        {
            InitializeComponent();
            _Mode = enMode.UpdateUser;
            _UserID = UserID;   
        }

        private void _ResetDefaultValue()
        {
            if( _Mode == enMode.AddUser )
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUsers();
                tabUserInfo.Enabled = false;
                ctrlPersonCardWithFilter1.FillterEnable = true;
            }
            else
            {
                lblTitle.Text = "Update User";
                this.Text = "Add New User";
                tabPer.Enabled = true;
                btnSave.Enabled = true;
            }
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";

        }
       private void _LoadData()
        {
            _User = clsUsers.FindUserByUserID( _UserID );
            ctrlPersonCardWithFilter1.FillterEnable = false;

            if(_User == null)
            {
                MessageBox.Show("No User With ID " + _User);
                this.Close();
                return;
            }
            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            chActive.Checked = _User.IsActive;  
            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);
            btnNext.Enabled = true;    
        }

        private void FrmAdd_UpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();   

            if( _Mode == enMode.UpdateUser )
                _LoadData();    
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            int PresonID = obj;

            if (PresonID != 0)
            {
                ctrlPersonCardWithFilter1.FillterEnable = false;
                btnNext.Enabled = true;

            }

            MessageBox.Show($"we got the presonid from the control , the id is {PresonID}");



        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabUserInfo.Enabled = true;
            tabPer.SelectedTab = tabPer.TabPages["tabUserInfo"];
        }

        private void tabPersonInfo_Click(object sender, EventArgs e)
        {

        }

        private void ctrlPersonCardWithFilter1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

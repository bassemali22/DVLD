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
    public partial class FrmAdd_UpdateUser : Form
    {
        public enum enMode { AddUser = 0, UpdateUser = 1 };
        private enMode _Mode;
        private int _PersonID;
        private int _UserID;
        private clsUsers _User;
        public FrmAdd_UpdateUser()
        {
            InitializeComponent();
        }
        public FrmAdd_UpdateUser(int UserID)
        {
            InitializeComponent();
        }


        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void FrmAdd_UpdateUser_Load(object sender, EventArgs e)
        {

        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {

             
            if(obj!= -1)
            { 
                ctrlPersonCardWithFilter1.FillterEnable = false;
                btnNext.Enabled = true;
               
            }
            
           
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabUserInfo"];
        }
    }
}

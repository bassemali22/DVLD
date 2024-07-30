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
    public partial class FrmUsersList : Form
    {
        private static DataTable  _dtAllUser = clsUsers.GetAllUsers();
        private DataTable _dtUser = _dtAllUser.DefaultView.ToTable(false, "UserID", "PersonID", "FullName", "UserName", "IsActive");
        public FrmUsersList()
        {
            InitializeComponent();
        }

       private void _RefreshListUser()
        {
            _dtAllUser = clsUsers.GetAllUsers();
            _dtUser = _dtAllUser.DefaultView.ToTable(false, "UserID", "PersonID", "FullName", "UserName", "IsActive");
            dgvUserInfo.DataSource = _dtAllUser;
        }

        private void FrmUsersList_Load(object sender, EventArgs e)
        {
            _RefreshListUser();

        }

        private void txtShowUserInfo_Click(object sender, EventArgs e)
        {
            FrmUserInfo frm = new FrmUserInfo((int)dgvUserInfo.CurrentRow.Cells[0].Value);  
            frm .ShowDialog(); 
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form frm = new FrmAdd_UpdateUser();
            frm .ShowDialog();

            // Refreshing
            _RefreshListUser();
        }

        private void txtEdit_Click(object sender, EventArgs e)
        {
            FrmAdd_UpdateUser frm = new FrmAdd_UpdateUser((int)dgvUserInfo.CurrentRow.Cells[0].Value);  
            frm .ShowDialog();
            _RefreshListUser();
        }
    }
}

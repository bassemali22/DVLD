using Bissnus_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace First_project.Users.Consrols
{
    public partial class ctrlUserCard : UserControl
    {
        private clsUsers _User;
        private int _UserID;

        public int UserID
        {

            get { return _UserID; } 
         }
        public ctrlUserCard()
        {
            InitializeComponent();
        }
        public void LoadUserInfo(int UserID)
        {
            _UserID = UserID;
           _User = clsUsers.FindUserByUserID(UserID);
            if(_User == null) 
            {
               MessageBox.Show("No User with UserID = " + UserID.ToString(), " ");
                return;
            }
            _FillUserInfo(); 

        }
        private void _FillUserInfo()
        {
            ctrlPersonCard1.LoadData(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName;
            lblIsActive.Text = (_User.IsActive) ? "Yse" : "No"; 
            

        }
     
      

      
    }
}

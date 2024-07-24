using Bissnus_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace First_project.People.Controls
{
    public partial class ctrlPersonInfo : UserControl
    {
       private clsPerson _Person;
        private int _PersonID;
        public ctrlPersonInfo(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;   
        }

        public void LoadData()
        {
            _Person = clsPerson.Find(_PersonID);
            lblPersonID.Text = _Person.PersonID.ToString();
            lblName.Text = _Person.FullName;
            lblNationalNo .Text = _Person.NationalNo;
            lblPhone.Text = _Person.Phone;
            lblEmail.Text = _Person.Email;
            lblAddrees.Text = _Person.Address;
        }
        
        private void ctrlPersonInfo_Load(object sender, EventArgs e)
        {

        }
    }
}

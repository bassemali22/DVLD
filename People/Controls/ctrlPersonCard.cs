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
    public partial class ctrlPersonCard : UserControl
    {
        private clsPerson _Person;
        private int _PersonID;
      
        public ctrlPersonCard()
        {
            InitializeComponent(); 
        }
        public int PersonID
        {
            get { return _PersonID; }
        }
        public clsPerson selectPersonInfo
        {
            get { return _Person; }
        }
        public void LoadData(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            if(_Person == null)
            {
                MessageBox.Show($"Sorry we couldn't found Person wiht ID {PersonID}");
                return;
            }
            _FillPersonInfo();
         }

        public void LoadData(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);
            if (_Person == null)
            {
                MessageBox.Show($"Sorry we couldn't found Person wiht NationalNo {NationalNo}");
                return;
            }
            _FillPersonInfo();
        }

        private void _FillPersonInfo()
        {
            _PersonID = _Person.PersonID;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblName.Text = _Person.FullName;
            lblNationalNo.Text = _Person.NationalNo;
            lblPhone.Text = _Person.Phone;
            lblEmail.Text = _Person.Email;
            lblGendor.Text = (_Person.Gendor == 0) ? "Male" : "Female";
            lblAddrees.Text = _Person.Address;
            lblDateoFBirth.Text = _Person.DateOfBirth.ToString();
            lblCountry.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;
            
        }

       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdd_UpdatePerson frm = new frmAdd_UpdatePerson(_Person.PersonID);
            frm.DataBack+= RefreshData;
            frm.ShowDialog();

        }

        private void RefreshData(object sender, int PersonID)
        {
            _FillPersonInfo();
        }
    }
}

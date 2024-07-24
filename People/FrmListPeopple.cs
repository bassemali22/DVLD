using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Bissnus_Layer;

namespace First_project.People
{
    public partial class FrmListPeopple : Form
    {
        private static DataTable _dtAllPeople = clsPerson.GetAllPeople();
        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");

        public FrmListPeopple()
        {
            InitializeComponent();
        }

        private void _RefreshListPeople()
        {
            _dtAllPeople = clsPerson.GetAllPeople();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");

            dgvPeople.DataSource = _dtPeople;
            lblRecordNumber.Text = dgvPeople.RowCount.ToString();  


    }

        private void ListPeopple_Load(object sender, EventArgs e)
        {
            _RefreshListPeople();
        }

        private void tlsmShowInfo_Click(object sender, EventArgs e)
        {
            Form frm = new FrmShowPersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshListPeople();
        }
    }
}

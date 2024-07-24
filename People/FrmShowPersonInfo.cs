using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace First_project.People
{
    public partial class FrmShowPersonInfo : Form
    {

        private int PersonID;
        public FrmShowPersonInfo(int personID)
        {
            InitializeComponent();
            PersonID = personID;
        }

        private void FrmShowPersonInfo_Load(object sender, EventArgs e)
        {
            ctrlPersonCard1.LoadData(PersonID); 
        }
    }
}

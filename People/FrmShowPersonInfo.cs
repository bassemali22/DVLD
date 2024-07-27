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

        public FrmShowPersonInfo(int PersonID)
        {
            InitializeComponent();
            ctrlPersonCard1.LoadData(PersonID);

        }
        public FrmShowPersonInfo(string NationalNo)
        {
            InitializeComponent();
            ctrlPersonCard1.LoadData(NationalNo);

        }



    }
}

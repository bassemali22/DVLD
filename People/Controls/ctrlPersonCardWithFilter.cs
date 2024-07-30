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
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;
  
        protected virtual void PersonSelected(int personId)
        {
            Action <int> handler = OnPersonSelected;
            if(handler != null)
            {
                handler(personId);
            }
        }

        public clsPerson SelectPersonInfo
        {
            get { return ctrlPersonCard1.selectPersonInfo; }
        }
        public int PersonID
        {
            get { return ctrlPersonCard1.PersonID; }
        }

        private bool _FillterEnable= true;
        public bool FillterEnable
        {
            set {

                _FillterEnable = value;
                grbFillter.Enabled = _FillterEnable; 
            }
            get { return _FillterEnable; }
        }
        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        
        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0; 
        }
        public void LoadPersonInfo(int PersonID)
        {
            cbFilter.SelectedIndex = 0;
            txtFilterBy.Text = PersonID.ToString();
            _Findnow();

        }
        private void _Findnow()
        {

            switch (cbFilter.Text)
            {
                case "PersonID":
                    ctrlPersonCard1.LoadData(int.Parse(txtFilterBy.Text));
                    break;
                case "NationalNo":
                    ctrlPersonCard1.LoadData(txtFilterBy.Text);
                    break;


            }

            // onSelectdPerson

            if(OnPersonSelected != null && FillterEnable)
            {
               PersonSelected(PersonID);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Findnow();
        }

        private void grbFillter_Enter(object sender, EventArgs e)
        {

        }
    }
}

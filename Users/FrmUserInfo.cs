﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace First_project.Users
{
    public partial class FrmUserInfo : Form
    {
        public FrmUserInfo(int UserID)
        {
            InitializeComponent();
            ctrlUserCard1.LoadUserInfo(UserID);
        }

       
    }
}

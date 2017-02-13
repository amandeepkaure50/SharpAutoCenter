﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharp_Auto_Center
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            /// Instantiate the form
            SharpAutoCenterForm sharpAutoCenterForm = new SharpAutoCenterForm();
            this.SplashFormTimer.Enabled = false;
            sharpAutoCenterForm.Show();
            this.Hide();           
            
        }
    }
}

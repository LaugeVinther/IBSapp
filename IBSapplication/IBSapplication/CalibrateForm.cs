﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace PresentationLogic
{
    public partial class CalibrateForm : Form
    {
        private CalibrateLoginForm calibrateLogin_Form;
        private CalibrateLogin calibrateLoginLogic;
        private Calibrate calibrate;

        public bool LoginOK_ { get; set; }

        public CalibrateForm()
        {
            InitializeComponent();

            calibrate = new Calibrate();
            calibrateLoginLogic = new CalibrateLogin(); 
            this.Visible = false; //CalibrateForm skjules

            calibrateLogin_Form = new CalibrateLoginForm(calibrateLoginLogic, this);
            calibrateLogin_Form.ShowDialog();

            if (this.LoginOK_ == true)
            {
                this.Visible = true;
            }
            else
                this.Close();
        }

        private void CalibrationBT_Click(object sender, EventArgs e)
        {
            calibrate = new Calibrate();
            calibrate.Calibration();
        }

        private void CalibrationBT_Click_1(object sender, EventArgs e)
        {

        }
    }
}


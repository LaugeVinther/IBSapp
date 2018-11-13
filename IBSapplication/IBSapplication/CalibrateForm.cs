using System;
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
        private Calibrate calibrateLogic;

        public bool LoginOK_ { get; set; }

        public CalibrateForm()
        {
            InitializeComponent();

            this.Visible = false; //CalibrateForm skjules

            calibrateLogin_Form = new CalibrateLoginForm();
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
            calibrateLogic = new Calibrate();
            calibrateLogic.Calibration();
        }
    }
}


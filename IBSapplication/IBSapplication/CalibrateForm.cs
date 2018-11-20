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
        private CalibrateLoginForm _calibrateLoginForm;
        private CalibrateLogin calibrateLoginLogic;
        private Calibrate calibrate;
        private DataProcessing dataProcessing;

        public bool LoginOK_ { get; set; }

        public CalibrateForm()
        {
            InitializeComponent();

            calibrate = new Calibrate();
            calibrateLoginLogic = new CalibrateLogin(); 
            this.Visible = false; //CalibrateForm skjules

            _calibrateLoginForm = new CalibrateLoginForm(calibrateLoginLogic, this);
            _calibrateLoginForm.ShowDialog();

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
            this.Close();
        }

        private void Measure10mmHgBT_Click(object sender, EventArgs e)
        {
            dataProcessing = new DataProcessing();
            dataProcessing.GetCalibration(10);
            Measure10mmHgBT.Enabled = false;
        }

        private void Measure50mmHgBT_Click(object sender, EventArgs e)
        {
            dataProcessing = new DataProcessing();
            dataProcessing.GetCalibration(50);
            Measure50mmHgBT.Enabled = false;
        }

        private void Measure100mmHgBT_Click(object sender, EventArgs e)
        {
            dataProcessing = new DataProcessing();
            dataProcessing.GetCalibration(100);
            Measure100mmHgBT.Enabled = false;
        }
    }
}


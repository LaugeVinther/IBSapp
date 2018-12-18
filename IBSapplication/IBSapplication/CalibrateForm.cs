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
        private DataProcessing _dataProcessing;

        public bool LoginOK_ { get; set; }

        public CalibrateForm(DataProcessing dataProcessing)
        {
            InitializeComponent();
            _dataProcessing = dataProcessing;

            
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

        private void Measure10mmHgBT_Click(object sender, EventArgs e)
        {
            _dataProcessing.GetVoltageData(10);
            Measure10mmHgBT.Enabled = false;
            MessageBox.Show("10 mmHg is measured", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void Measure50mmHgBT_Click(object sender, EventArgs e)
        {
            _dataProcessing.GetVoltageData(50);
            Measure50mmHgBT.Enabled = false;
            MessageBox.Show("50 mmHg is measured", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);

        }

        private void Measure100mmHgBT_Click(object sender, EventArgs e)
        {
            _dataProcessing.GetVoltageData(100);
            Measure100mmHgBT.Enabled = false;
            MessageBox.Show("100 mmHg is measured", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);


            CalibrateBT.Enabled = true;
        }

        private void CalibrateBT_Click(object sender, EventArgs e)
        {
            _dataProcessing.GetCalibration();
            DialogResult result = MessageBox.Show("Calibration succeeded", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
            if (result == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void DateOfCalibration_Click(object sender, EventArgs e)
        {
            DateOfCalibration.Text = DateTime.Now.ToShortDateString();
        }

        private void CalibrateChart_Click(object sender, EventArgs e)
        {

        }
    }
}


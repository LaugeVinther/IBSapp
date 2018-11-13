using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;

namespace PresentationLogic
{
    public partial class PrimaryForm : Form
    {
        private BuisnessLogicIF currentBuisnessLogic;
        private CalibrateLoginForm _calibrateLoginForm;
        private SaveDataForm _saveDataForm;
        private ZeroPointAdjustmentForm _zeroPointAdjustmentForm;

        
        public PrimaryForm(BuisnessLogicIF buisnessLogic)
        {
            currentBuisnessLogic = buisnessLogic;
            InitializeComponent();

        }

        private void CalibrationBT_Click(object sender, EventArgs e)
        {

            _calibrateLoginForm = new CalibrateLoginForm();
            _calibrateLoginForm.ShowDialog();
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            _saveDataForm = new SaveDataForm();
            _saveDataForm.ShowDialog();
        }

        private void ZeroPointAdjustmentBT_Click(object sender, EventArgs e)
        {
            _zeroPointAdjustmentForm = new ZeroPointAdjustmentForm();
            _zeroPointAdjustmentForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

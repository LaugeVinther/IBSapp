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
    public partial class ZeroPointAdjustmentForm : Form
    {
        private DataProcessing _dataProcessing;
        public ZeroPointAdjustmentForm(DataProcessing dataprocessing)
        {
            InitializeComponent();
            _dataProcessing = dataprocessing;
        }


        private void zeroPointAdjustmentBT_Click(object sender, EventArgs e)
        {
            bool done = false;

            while (done == false)
            {
                bool abnormalValue = _dataProcessing.GetZeroPointAdjustment();

                if (abnormalValue == false)
                {
                    done = true;
                    MessageBox.Show("System has been zeropoint adjusted");
                }

                if (abnormalValue == true)
                {
                    MessageBox.Show(
                        "Error due to abnormal value.\n Check if the transducer is positioned correctly and try again.");
                }
            }
            this.Close();
        }
    }
}

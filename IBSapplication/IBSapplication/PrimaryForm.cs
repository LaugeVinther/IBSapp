using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Interfaces;
using BusinessLogic;

namespace PresentationLogic
{
    public partial class PrimaryForm : Form
    {
        private BuisnessLogicIF currentBuisnessLogic;
        private CalibrateForm _calibrateForm;
        private SaveDataForm _saveDataForm;
        private ZeroPointAdjustmentForm _zeroPointAdjustmentForm;
        private DataProcessing _dataProcessing;

        
        public PrimaryForm(BuisnessLogicIF buisnessLogic)
        {
            currentBuisnessLogic = buisnessLogic;
            _calibrateForm = new CalibrateForm(_dataProcessing);
             _dataProcessing = new DataProcessing();
            InitializeComponent();

        }

        private void graphSetting() // OBS! tallene skal laves om efter standarden!
        {
            //Major grid 
            chart1.Series["Bloodpressure signal"].IsXValueIndexed = false;
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = 60; 
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 10;
            chart1.ChartAreas["ChartArea1"].AxisY.Minimum = 0;
            chart1.ChartAreas["ChartArea1"].AxisY.Maximum = 200;
            chart1.ChartAreas["ChartArea1"].AxisY.Interval = 20;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 2;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 2;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.LightGreen;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.LightGreen;

            //Minor grid
            chart1.ChartAreas["ChartArea1"].AxisX.MinorGrid.Enabled = true;
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.Enabled = true;
            chart1.ChartAreas["ChartArea1"].AxisX.MinorGrid.LineColor = Color.LightGreen;
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.LineColor = Color.LightGreen;
            chart1.ChartAreas["ChartArea1"].AxisX.MinorGrid.Interval = 20;
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.Interval = 0.1;
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.LineDashStyle = ChartDashStyle.Dot;
            chart1.ChartAreas["ChartArea1"].AxisX.MinorGrid.LineDashStyle = ChartDashStyle.Dot;

            chart1.Invalidate();

        }

        private void CalibrationBT_Click(object sender, EventArgs e)
        {
            _calibrateForm = new CalibrateForm(_dataProcessing);
            _calibrateForm.ShowDialog();
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            _saveDataForm = new SaveDataForm(_dataProcessing);
            _saveDataForm.ShowDialog();
        }

        private void ZeroPointAdjustmentBT_Click(object sender, EventArgs e)
        {
            _zeroPointAdjustmentForm = new ZeroPointAdjustmentForm();
            _zeroPointAdjustmentForm.ShowDialog();
        }



        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void StartStopBT_Click(object sender, EventArgs e)
        {
            StartStopBT.BackColor = Color.Red;
            StartStopBT.Text = "STOP";

            _dataProcessing.Start();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

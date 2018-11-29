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
        private DataCalculation _dataCalculation;

        
        public PrimaryForm(BuisnessLogicIF buisnessLogic)
        {
            currentBuisnessLogic = buisnessLogic;
            _calibrateForm = new CalibrateForm(_dataProcessing);
             _dataProcessing = new DataProcessing();
            _dataCalculation = new DataCalculation(_dataProcessing);

            _dataCalculation.NewDataAvailableEvent += NewDataAvailableEventMethod;

            InitializeComponent();

        }

        public void NewDataAvailableEventMethod(List<double> list)
        {
            //Opdater graf-kode
        }

       //Denne metode skal hele tiden opdatere tal og grafer
       public void DoWork()
       {
          SysDiaTB.Text = (+_dataProcessing.CalculatedSystolicValue + "/" + _dataProcessing.CalculatedDiastolicValue);
          AverageBP_TB.Text = _dataProcessing.CalculatedAverageBPValue.ToString();
          PulseTB.Text = _dataProcessing.CalculatedPulseValue.ToString();
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

        private void StartStopBT_Click(object sender, EventArgs e)
        {
            StartStopBT.BackColor = Color.Red;
            StartStopBT.Text = "STOP";

            
        }

      private void SystolicMaxTB_TextChanged(object sender, EventArgs e)
      {
         int sysMax;
         try
         {
             sysMax=Convert.ToInt32(SystolicMaxTB.Text);
            if (sysMax > 0)
            {
               _dataProcessing.SystolicMaxThreshold = sysMax;
            }
            else
            {
               MessageBox.Show("Den indtastede værdi er ugyldig");
            }
         }
         catch (FormatException err)
         {
            MessageBox.Show("Den indtastede værdi er ugyldig");
         }
      }

      private void SystolicMinTB_TextChanged(object sender, EventArgs e)
      {
         int sysMin;
         try
         {
            sysMin = Convert.ToInt32(SystolicMinTB.Text);
            if (sysMin > 0)
            {
               _dataProcessing.SystolicMinThreshold = sysMin;
            }
            else
            {
               MessageBox.Show("Den indtastede værdi er ugyldig");
            }
         }
         catch (FormatException err)
         {
            MessageBox.Show("Den indtastede værdi er ugyldig");
         }
      }

      private void DiastolicMaxTB_TextChanged(object sender, EventArgs e)
      {
         int diaMax;
         try
         {
            diaMax = Convert.ToInt32(DiastolicMaxTB.Text);
            if (diaMax > 0)
            {
               _dataProcessing.DiastolicMaxThreshold = diaMax;
            }
            else
            {
               MessageBox.Show("Den indtastede værdi er ugyldig");
            }
         }
         catch (FormatException err)
         {
            MessageBox.Show("Den indtastede værdi er ugyldig");
         }
      }

      private void DiastolicMinTB_TextChanged(object sender, EventArgs e)
      {
         int diaMin;
         try
         {
            diaMin = Convert.ToInt32(DiastolicMinTB.Text);
            if (diaMin > 0)
            {
               _dataProcessing.DiastolicMinThreshold = diaMin;
            }
            else
            {
               MessageBox.Show("Den indtastede værdi er ugyldig");
            }
         }
         catch (FormatException err)
         {
            MessageBox.Show("Den indtastede værdi er ugyldig");
         }
      }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SystolicMaxTB.Enabled = true;
            SystolicMinTB.Enabled = true;
            DiastolicMaxTB.Enabled = true;
            DiastolicMinTB.Enabled = true;
        }
    }
}

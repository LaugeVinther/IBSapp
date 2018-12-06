using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
        //private BuisnessLogicIF currentBuisnessLogic;
        private CalibrateForm _calibrateForm;
        private SaveDataForm _saveDataForm;
        private ZeroPointAdjustmentForm _zeroPointAdjustmentForm;
        private DataProcessing _dataProcessing;
        private DataCalculation _dataCalculation;
        private SoundPlayer _player;

        
        public PrimaryForm(DataProcessing dataProcessing, DataCalculation dataCalculation)
        {
            InitializeComponent();


            //currentBuisnessLogic = buisnessLogic;
            graphSetting();
            //_dataProcessing = new DataProcessing();
            //_dataCalculation = new DataCalculation(_dataProcessing);

            _dataProcessing = dataProcessing;
            _dataCalculation = dataCalculation;


            _dataProcessing.filterSwitchedOn = true;
            

            _dataCalculation.NewDataAvailableEvent += NewDataAvailableEventMethod;

            _dataCalculation.AlarmActivatedEvent += AlarmActivatedEventMethod;
          
            _player = new System.Media.SoundPlayer(@"C:\Users\Esma\Documents\Sundhedsteknologi\3. semester\Semesterprojekt 3 - Udvikling af et blodtrykmålesystem\SW\IBSapp\IBSapplication\IBSapplication\bin\Debug\alarm_high_priority_5overtoner.wav"); //korrekt stinavn skal indsættes




        }

        public void NewDataAvailableEventMethod(List<double> list, int Pulse, int sysBP, int diaBP, int avgBP)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action) delegate
                {
                    PulseTB.Text = Pulse.ToString();
                    SysDiaTB.Text = (sysBP + "/" + diaBP);
                    AverageBP_TB.Text = avgBP.ToString();

                    foreach (var number in list)
                    {
                        chart1.Series["Blood Pressure"].Points.AddY(number);
                    }

                  
                }
                    
                    );
            }
        }

        public async void AlarmActivatedEventMethod(bool alarmActivated)//Brugt async for at bruge await - på denne måde kan label blinke
        {
            //Alarm skal igangsættes med lyd og lys
            //Afspil lyd
            _player.Play();

            //igangsæt lys
            while (true)
            {
                await Task.Delay(500);
                SysDiaTB.ForeColor = SysDiaTB.ForeColor == Color.Red ? Color.Lime : Color.Red; 
            }

        }

           private void graphSetting() // OBS! tallene skal laves om efter standarden!
        {
            //Major grid 
            chart1.Series["Blood Pressure"].IsXValueIndexed = false;
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
            _saveDataForm = new SaveDataForm(_dataCalculation);
            _saveDataForm.ShowDialog();
        }

        private void ZeroPointAdjustmentBT_Click(object sender, EventArgs e)
        {
            _zeroPointAdjustmentForm = new ZeroPointAdjustmentForm(_dataProcessing);
            _zeroPointAdjustmentForm.ShowDialog();
        }

        private void StartStopBT_Click(object sender, EventArgs e)
        {
            //når der trykkes på start-knappen skal den "aktivere" DataProcessing, som kan hente listen af Datapunkter fra DataCollection

           if (StartStopBT.Text == "START")
           {
            _dataProcessing.StartDataProcessingThread();
            _dataCalculation.StartCalcThread();

              StartStopBT.BackColor = Color.Red;
              StartStopBT.Text = "STOP";

              SystolicMaxTB.Enabled = true;
              SystolicMinTB.Enabled = true;
              DiastolicMaxTB.Enabled = true;
              DiastolicMinTB.Enabled = true;
           }

         if (StartStopBT.Text == "STOP")
         {
            StartStopBT.BackColor = Color.LawnGreen;
            StartStopBT.Text = "START";

            _dataCalculation.JoinCalcThread();
            _dataProcessing.JoinThreads();
         }

      }


   

      private void SystolicMaxTB_TextChanged(object sender, EventArgs e)
      {
         int sysMax;
         try
         {
             sysMax=Convert.ToInt32(SystolicMaxTB.Text);
            if (sysMax > 0)
            {
               _dataCalculation.SystolicMaxThreshold = sysMax;
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
               _dataCalculation.SystolicMinThreshold = sysMin;
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
               _dataCalculation.DiastolicMaxThreshold = diaMax;
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
               _dataCalculation.DiastolicMinThreshold = diaMin;
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

        private void AdaptThresholdsBT_Click(object sender, EventArgs e)
        {
            if (ThresholdCheckpoint.Checked == true)
            {
                SystolicMaxTB.Enabled = false;
                SystolicMinTB.Enabled = false;
                DiastolicMaxTB.Enabled = false;
                DiastolicMinTB.Enabled = false;
            }     
        }

        private void ThresholdCheckpoint_CheckedChanged(object sender, EventArgs e)
        {
            SystolicMaxTB.Enabled = true;
            SystolicMinTB.Enabled = true;
            DiastolicMaxTB.Enabled = true;
            DiastolicMinTB.Enabled = true;
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

      private void FilterB_Click(object sender, EventArgs e)
      {
         if (FilterB.Text == "ON")
         {
            FilterB.BackColor = Color.Red; //symbolizes light turned on

            FilterB.Text = "OFF";
            _dataProcessing.filterSwitchedOn = false;
         }

         else if (FilterB.Text == "OFF")
         {
            FilterB.BackColor = Color.LawnGreen; //symbolizes light turned off

            FilterB.Text = "ON";
            _dataProcessing.filterSwitchedOn = true;
         }
      }
   }
}

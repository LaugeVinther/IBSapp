using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
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
        private const int _windowSize = 520;
        private int _currentSample = 0;
        //public Thread AlarmThread;
        private bool AlarmIsStarted;
        private bool IsSaveEnabled;

        public PrimaryForm(DataProcessing dataProcessing, DataCalculation dataCalculation)
        {
            InitializeComponent();


            //currentBuisnessLogic = buisnessLogic;

            //_dataProcessing = new DataProcessing();
            //_dataCalculation = new DataCalculation(_dataProcessing);

            _dataProcessing = dataProcessing;
            _dataCalculation = dataCalculation;

            //AlarmThread = new Thread(Alarming);
            AlarmIsStarted = false;
            //_player = new System.Media.SoundPlayer(@"C:\Users\FridaH\Documents\ST\ST3\PRJ\alarm_high_priority_5overtoner.wav"); //korrekt stinavn skal indsættes

            SaveBT.Enabled = false;
            StartStopBT.Enabled = false;

        }

        public void PrimaryForm_Load(object sender, EventArgs e)
        {
            _dataCalculation.NewDataAvailableEvent += NewDataAvailableEventMethod;

            _dataCalculation.AlarmActivatedEvent += AlarmActivatedEventMethod;


            _dataProcessing.filterSwitchedOn = true;
            graphSetting();


        }

        public void NewDataAvailableEventMethod(List<double> list, int pulse, int sysBP, int diaBP, int avgBP)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)(() =>
                {
                    PulseTB.Text = pulse.ToString();
                    SysDiaTB.Text = (sysBP + "/" + diaBP);
                    AverageBP_TB.Text = avgBP.ToString();

                    foreach (var number in list)
                    {
                        //chart1.Series[0].Points.AddY(number);
                        chart1.Series[0].Points[_currentSample].SetValueY(number);
                        _currentSample = (_currentSample + 1) % _windowSize;
                    }
                    chart1.Refresh();

                    if (AlarmIsStarted == true)
                    {
                        Alarming();
                    }

                }

                    ));
                return;
            }
        }

        public void AlarmActivatedEventMethod(bool alarmActivated)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)(() =>
                      {
                          if (_dataCalculation._alarmActivated == true /*&& AlarmThreadIsStarted==false*/)
                          {
                          //AlarmThread.Start();
                          AlarmIsStarted = true;
                          }
                          else if (_dataCalculation._alarmActivated == false /*&& AlarmThreadIsStarted==true*/)
                          {
                          //AlarmThread.Join();
                          AlarmIsStarted = false;
                          }


                      }

                   ));
                return;
            }

        }

        public void Alarming()
        {
            if (SysDiaTB.ForeColor == Color.Red)
            {
                SysDiaTB.ForeColor = Color.Lime;
            }
            else
            {
                SysDiaTB.ForeColor = Color.Red;
            }
        }

        private void graphSetting() // OBS! tallene skal laves om efter standarden!
        {


            //Major grid 
            chart1.Series["Blood Pressure"].IsXValueIndexed = false;
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = 520;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 10;
            chart1.ChartAreas["ChartArea1"].AxisY.Minimum = 0;
            chart1.ChartAreas["ChartArea1"].AxisY.Maximum = 200;
            chart1.ChartAreas["ChartArea1"].AxisY.Interval = 20;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 2;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 2;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Black;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Black;

            //Minor grid
            chart1.ChartAreas["ChartArea1"].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisX.MinorGrid.LineColor = Color.Black;
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.LineColor = Color.Black;
            chart1.ChartAreas["ChartArea1"].AxisX.MinorGrid.Interval = 20;
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.Interval = 0.1;
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.LineDashStyle = ChartDashStyle.Dot;
            chart1.ChartAreas["ChartArea1"].AxisX.MinorGrid.LineDashStyle = ChartDashStyle.Dot;

            for (int i = 0; i < _windowSize; i++)
            {
                chart1.Series[0].Points.AddY(0);
            }

            chart1.Refresh();

        }

        private void CalibrationBT_Click(object sender, EventArgs e)
        {
            _calibrateForm = new CalibrateForm(_dataProcessing);
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
           
                SaveBT.Enabled = true;
                _saveDataForm = new SaveDataForm(_dataCalculation);
                _saveDataForm.ShowDialog();
            
        }

        private void ZeroPointAdjustmentBT_Click(object sender, EventArgs e)
        {
            _zeroPointAdjustmentForm = new ZeroPointAdjustmentForm(_dataProcessing);
            _zeroPointAdjustmentForm.ShowDialog();
            StartStopBT.Enabled = true;
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

                //SystolicMaxTB.Enabled = true;
                //SystolicMinTB.Enabled = true;
                //DiastolicMaxTB.Enabled = true;
                //DiastolicMinTB.Enabled = true;
            }

            else if (StartStopBT.Text == "STOP")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to stop measuring?", "Warning", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    StartStopBT.BackColor = Color.LawnGreen;
                    StartStopBT.Text = "START";

                    _dataCalculation.JoinCalcThread();
                    _dataProcessing.JoinThreads();
                    SaveBT.Enabled = true;
                }


                //chart1.Series[0].Points.Clear();
                //AverageBP_TB.Text = "";
                //PulseTB.Text = "";
                //SysDiaTB.Text = "" + "/" + "";
            }

        }

        private void AdaptThresholdsBT_Click(object sender, EventArgs e)
        {
            int diaMin;
            int diaMax;
            int sysMin;
            int sysMax;
            try
            {
                sysMin = Convert.ToInt32(SystolicMinTB.Text);
                diaMin = Convert.ToInt32(DiastolicMinTB.Text);
                diaMax = Convert.ToInt32(DiastolicMaxTB.Text);
                sysMax = Convert.ToInt32(SystolicMaxTB.Text);
                if (diaMin > 0 && diaMax > 0 && sysMin > 0 && sysMax > 0)
                {
                    _dataCalculation.DiastolicMinThreshold = diaMin;
                    _dataCalculation.DiastolicMaxThreshold = diaMax;
                    _dataCalculation.SystolicMinThreshold = sysMin;
                    _dataCalculation.SystolicMaxThreshold = sysMax;
                    SystolicMaxTB.Enabled = false;
                    SystolicMinTB.Enabled = false;
                    DiastolicMaxTB.Enabled = false;
                    DiastolicMinTB.Enabled = false;
                    AdaptThresholdsBT.Enabled = false;
                    ThresholdCheckpoint.Checked = false;
                    MessageBox.Show("De nye grænseværdier er sat");
                }
                else
                {
                    MessageBox.Show("En eller flere af de indtastede værdier er ugyldige");
                    SystolicMaxTB.Clear();
                    SystolicMinTB.Clear();
                    DiastolicMaxTB.Clear();
                    DiastolicMinTB.Clear();
                }
            }
            catch (FormatException err)
            {
                MessageBox.Show("En eller flere af de indtastede værdier er ugyldige");
                SystolicMaxTB.Clear();
                SystolicMinTB.Clear();
                DiastolicMaxTB.Clear();
                DiastolicMinTB.Clear();
            }
        }

        private void ThresholdCheckpoint_CheckedChanged(object sender, EventArgs e)
        {
            if (ThresholdCheckpoint.Checked == true)
            {
                SystolicMaxTB.Enabled = true;
                SystolicMinTB.Enabled = true;
                DiastolicMaxTB.Enabled = true;
                DiastolicMinTB.Enabled = true;
                AdaptThresholdsBT.Enabled = true;
            }
            else
            {
                SystolicMaxTB.Enabled = false;
                SystolicMinTB.Enabled = false;
                DiastolicMaxTB.Enabled = false;
                DiastolicMinTB.Enabled = false;
            }



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

        private void AverageBP_TB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

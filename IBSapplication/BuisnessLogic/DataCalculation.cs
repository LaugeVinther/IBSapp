using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DTOLogic;
using DataLogic;
using Interfaces;

namespace BusinessLogic
{
    public class DataCalculation
    {
        private DataProcessing _dataProcessing;
        private IPulse _pulse;
        private IBloodPressure _bloodPressure;
        private IAlarm _alarm;
        private IProcessedDataCollector _processedDataCollector;
        private IDatabaseSaver _databaseSaver;
        private IBinFormatter _binFormatter;

        private List<bool> _alarmList;


        //Events
        public event Action<List<double>, int, int, int, int> NewDataAvailableEvent;
        public event Action<bool> AlarmActivatedEvent;

      //Define variables
      public int CalculatedPulseValue { get; private set; }
        public int CalculatedSystolicValue { get; private set; }
        public int CalculatedDiastolicValue { get; private set; }
        public int CalculatedAverageBPValue { get; private set; }
        public int SystolicMaxThreshold { get; set; }
        public int SystolicMinThreshold { get; set; }
        public int DiastolicMaxThreshold { get; set; }
        public int DiastolicMinThreshold { get; set; }
        private int f_sample;
        private bool _alarmActivated;
        private List<double> _totalDataList;
        private List<double> _incomingDataList;
        private readonly BlockingCollection<List<double>> _dataQueue;
       public Thread DataCalculationThread;



        public DataCalculation(DataProcessing dataProcessing)
        {
            _dataProcessing = dataProcessing;
            _pulse = new Pulse();
            _bloodPressure = new BloodPressure();
            _processedDataCollector = new ProcessedDataCollector();
            _databaseSaver = new DatabaseSaver();
            _binFormatter = new BinFormatter();
            _alarm = new Alarm();
            _alarmList = new List<bool>(2);



            //create variables
            f_sample = 1000;
            CalculatedPulseValue = 0;
            CalculatedSystolicValue = 0;
            CalculatedDiastolicValue = 0;
            CalculatedAverageBPValue = 0;
            _dataQueue = _dataProcessing.GetDataQueueToCalculation();
           DataCalculationThread = new Thread(doDataCalculation);
        }

       public void StartCalcThread()
       {
          DataCalculationThread.Start();
       }

       public void JoinCalcThread()
       {
          DataCalculationThread.Join();
       }

        public void doDataCalculation()
        {
            while (!_dataQueue.IsCompleted)
            {
                try
                {
                    _incomingDataList = _dataQueue.Take();
                }
                catch
                {
                    //
                }
                _totalDataList = _processedDataCollector.getProcessedDataList(_incomingDataList);

                _pulse.CalculatePulse(_totalDataList.ToArray(), f_sample);
                CalculatedPulseValue = _pulse.Pulse;

                _bloodPressure.CalculateBP(_totalDataList.ToArray(), f_sample, CalculatedPulseValue);
                CalculatedSystolicValue = _bloodPressure._dtoBloodpressure.Systolic;
                CalculatedDiastolicValue = _bloodPressure._dtoBloodpressure.Diastolic;
                CalculatedAverageBPValue = _bloodPressure._dtoBloodpressure.AverageBP;


                _alarmActivated = _alarm.CheckAlarming(_bloodPressure._dtoBloodpressure);

                if (_alarmActivated == true)
                {
                    AlarmActivatedEvent?.Invoke(_alarmActivated);
                }


                NewDataAvailableEvent?.Invoke(_totalDataList, CalculatedPulseValue, CalculatedSystolicValue, CalculatedDiastolicValue, CalculatedAverageBPValue);
            }

        }
        //public void GetProcessedData()
        //{
        //   //Tænker om ikke det her skal op i i doDataCalculation og så skal alt ske inde i try?

        //}
        public void Safe(DTO_SaveData savedataDTO)
        {
            byte[] binArray = _binFormatter.ConvertToByteArray(_totalDataList);

            _databaseSaver.SaveToDatabase(savedataDTO, binArray);

        }
        public void SetThresholds()
        {
            _alarm.GetTresholds(SystolicMaxThreshold, SystolicMinThreshold, DiastolicMaxThreshold, DiastolicMinThreshold);
        }

    }



}


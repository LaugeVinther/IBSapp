using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLogic;
using Interfaces;
using DTOLogic;

namespace BusinessLogic
{
    public class DataProcessing
    {
       //Define relations
        private IProcessedDataCollector _processedDataCollector;
        private IDatabaseSaver _databaseSaver;
        private IBinFormatter _binFormatter;
        private DTO_SaveData _saveDataDTO;
        private List<double> _processedDataList;
        private DataCollection dataCollector;
        private BlockingCollection<DTO_mV> dataQueue;
        private Calibrate _calibrate;
        private IPulse _pulse;
        private IBloodPressure _bloodPressure;
        private int f_sample;

       //Define variables
       public int CalculatedPulseValue { get; private set; }
       public int CalculatedSystolicValue { get; private set; }
       public int CalculatedDiastolicValue { get; private set; }
       public int CalculatedAverageBPValue { get; private set; }

       


        private bool isRunning;
       



        //  List<double> ProcessedData = new List<double>();

        public DataProcessing()
        {
           //create relations 
            dataCollector = new DataCollection(dataQueue);
            _processedDataCollector = new ProcessedDataCollector();
            _databaseSaver = new DatabaseSaver();
            _calibrate = new Calibrate();
            _binFormatter = new BinFormatter();
            _pulse = new Pulse();
            _bloodPressure = new BloodPressure();

           //create variables
           f_sample = 1000;
           CalculatedPulseValue = 0;
           CalculatedSystolicValue = 0;
           CalculatedDiastolicValue = 0;
           CalculatedAverageBPValue = 0;


        }

        public void Start()
        {
           //Er der nogle ting der skal nulstilles inden nedenfor? 
           //Så vi ikke bare skriver oveni?
            while (isRunning = true)
            {
                _processedDataList = _processedDataCollector.getProcessedDataList();
               _pulse.CalculatePulse(_processedDataList.ToArray(),f_sample);
               CalculatedPulseValue = _pulse._dtoPulse.Pulse;
               _bloodPressure.CalculateBP(_processedDataList.ToArray(),f_sample, CalculatedPulseValue);
               CalculatedSystolicValue = _bloodPressure._dtoBloodpressure.Systolic;
               CalculatedDiastolicValue = _bloodPressure._dtoBloodpressure.Diastolic;
               CalculatedAverageBPValue = _bloodPressure._dtoBloodpressure.AverageBP;
            }
        }

        public void GetVoltageData(int pressureValue)
        {
            double oneDataPoint = dataCollector.GetOneDataPoint();
            _calibrate.AddVoltage(oneDataPoint, pressureValue);
        }

        public double GetCalibration()
        {

            return _calibrate.Calibration();
        }


        public void Safe(DTO_SaveData savedataDTO)
        {
            byte[] binArray = _binFormatter.ConvertToByteArray(_processedDataList);

            _databaseSaver.SaveToDatabase(savedataDTO, binArray);

        }
    }
}


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
        private IProcessedDataCollector _processedDataCollector;
        private IDatabaseSaver _databaseSaver;
        private DTO_SaveData _saveDataDTO;
        private List<double> _processedDataList;
        private DataCollection dataCollector;
        private BlockingCollection<DTO_mV> dataQueue;
        private Calibrate _calibrate;


        private bool isRunning;

        //  List<double> ProcessedData = new List<double>();

        public DataProcessing()
        {
            dataCollector = new DataCollection(dataQueue);
            _processedDataCollector = new ProcessedDataCollector();
            _databaseSaver = new DatabaseSaver();
            _calibrate = new Calibrate();
        }

        public void Start()
        {
            while (isRunning = true)
            {
                _processedDataList = _processedDataCollector.getProcessedDataList();
            }
        }

        public void GetVoltageData(int pressureValue)
        {
            double oneDataPoint = dataCollector.GetOneDataPoint();
            _calibrate.AddVoltage(oneDataPoint, pressureValue);
        }

        public void GetSlope(double slope)
        {
            _calibrate.Calibration(slope);
        }


        public void Safe(DTO_SaveData savedataDTO)
        {
            _saveDataDTO = savedataDTO;
            _databaseSaver.SaveToDatabase(_saveDataDTO, ProcessedDataList);

        }
    }
}

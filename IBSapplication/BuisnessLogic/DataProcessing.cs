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
        private IBinFormatter _binFormatter;
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
            _binFormatter = new BinFormatter();
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
            _saveDataDTO = savedataDTO;
            _databaseSaver.SaveToDatabase(_saveDataDTO, ProcessedDataList);

        }
    }
}

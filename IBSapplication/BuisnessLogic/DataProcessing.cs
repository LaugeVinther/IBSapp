﻿using System;
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
        private DataLogicIF _dataobject;
        private IProcessedDataCollector _processedDataCollector;
        private IDatabaseSaver _databaseSaver;
        private DTO_SaveData _saveDataDTO;
        private List<double> ProcessedDataList;
        private DataCollection dataCollector;
        private BlockingCollection<DTO_mV> dataQueue;
        private Calibrate calibrate;


        private bool isRunning;
       



        //  List<double> ProcessedData = new List<double>();

        public DataProcessing()
        {
            dataCollector = new DataCollection(dataQueue);
            _dataobject = new DataCollection();
            _processedDataCollector = new ProcessedDataCollector();
            _databaseSaver = new DatabaseSaver();
        }

        public void Start()
        {
            while (isRunning = true)
            {

            }
        }

        public void GetVoltageData (int pressureValue) // ændrer navn 
        {
            double oneDataPoint = dataCollector.GetOneDataPoint();
            calibrate.AddVoltage(oneDataPoint, pressureValue);
        }

        public void GeCalibration ()
        {
            calibrate.Calibration();
        }

        public void Safe()
        public void Safe(DTO_SaveData savedataDTO)
        {
            _saveDataDTO = savedataDTO;
            _databaseSaver.SaveToDatabase(_saveDataDTO, ProcessedDataList);
        }
    }
}

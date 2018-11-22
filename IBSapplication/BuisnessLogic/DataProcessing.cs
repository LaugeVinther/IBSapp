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
        private DataLogicIF _dataobject;
        private DataCollection dataCollector;
        private BlockingCollection<DTO_mV> dataQueue;
        private Calibrate calibrate;

        private bool isRunning;
        ProcessedDataCollector processedDataCollector_ = new ProcessedDataCollector();

        public DataProcessing()
        {
            dataCollector = new DataCollection(dataQueue);
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
        {
            
        }
    }
}

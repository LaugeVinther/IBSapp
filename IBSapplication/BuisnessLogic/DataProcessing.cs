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
        private DataCollection dataCollector;
        private BlockingCollection<DTO_mV> dataQueue;
        private ICalibrate _calibrate;

      private bool isRunning;
       
        
        public DataProcessing()
        {
           //create relations 
            dataCollector = new DataCollection(dataQueue);
            _calibrate = new Calibrate();
        }

        public void Start()
        {
           //Er der nogle ting der skal nulstilles inden nedenfor? 
           //Så vi ikke bare skriver oveni?
            while (isRunning = true)
            {
                
            }
        }

        public void GetVoltageData(int pressureValue)
        {
            List<double> dataPointList = new List<double>();
            dataPointList = dataCollector.GetSomeDataPoints();
       
            double sumOfDataPoints = 0;
            double averageOfDataPoints;

            for (int i = 0; i < dataPointList.Count; i++)
            {
                sumOfDataPoints += dataPointList[i];
            }

            averageOfDataPoints = sumOfDataPoints / dataPointList.Count;

            _calibrate.AddVoltage(averageOfDataPoints, pressureValue);
        }

        public double GetCalibration()
        {
            return _calibrate.Calibration();
        }

        public void GetZeroPointAdjustment()
        {
            List<double> zeroPointMeasurement = dataCollector.GetSomeDataPoints();

        }

   }
}


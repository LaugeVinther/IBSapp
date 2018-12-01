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
        private readonly BlockingCollection<List<double>> _dataQueue;
        private ICalibrate _calibrate;
        private List<double> rawDataList;

      private bool isRunning;
       
        
        public DataProcessing()
        {
            //create relations 
            dataCollector = new DataCollection(_dataQueue);
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

        public List<double> GetRawData ()
        {
            while (!_dataQueue.IsCompleted)
            {
                try
                {
                    rawDataList = _dataQueue.Take();
                }
                catch
                {

                }
            }
            return rawDataList;
        }

        public void GetVoltageData(int pressureValue) // sørger for at hente det rigtige punkt for knappen, der trykkes på GUI'en
        {
            List<double> dataPointList = dataCollector.GetSomeDataPoints();
       
            double sumOfDataPoints = 0;
            double averageOfDataPoints;

            for (int i = 0; i < dataPointList.Count; i++) // summen af alle datapunkterne i listen beregnes
            {
                sumOfDataPoints += dataPointList[i];
            }

            averageOfDataPoints = sumOfDataPoints / dataPointList.Count;

            _calibrate.AddVoltage(averageOfDataPoints, pressureValue);
        }

        public double GetCalibration() // UnitConverter henter hældningskoeffienten 
        {
             return _calibrate.Calibration();
        }

        public void GetZeroPointAdjustment()
        {
            List<double> zeroPointMeasurement = dataCollector.GetSomeDataPoints();

        }

   }
}


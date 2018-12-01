using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLogic;
using Interfaces;
using DTOLogic;
using System.Threading;

namespace BusinessLogic
{
    public class DataProcessing
    {
       //Define relations
        private DataCollection dataCollector;
        private readonly BlockingCollection<List<double>> _dataQueue;
        private ICalibrate _calibrate;
        private List<double> rawDataList;
        private UnitConverter _unitConverter;
        Thread dataProcessingThread;

      private bool isRunning;
       
        
        public DataProcessing()
        {
            //create relations 
            dataCollector = new DataCollection(_dataQueue);
            _calibrate = new Calibrate();
            _unitConverter = new UnitConverter();
            dataProcessingThread = new Thread(Start);
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

        public double GetSlope() // UnitConverter henter hældningskoeffienten 
        {
             return _calibrate.Slope;
        }

        public void GetCalibration ()
        {
            List<double> calibratedSampleList = _unitConverter.GetCalibratedSampleList();
        }

        public void GetZeroPointAdjustment()
        {
            List<double> zeroPointMeasurement = dataCollector.GetSomeDataPoints();

        }

   }
}


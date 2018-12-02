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
        private UnitConverter _unitConverter;
        Thread dataProcessingThread;
      private readonly BlockingCollection<List<double>> _dataQueueToProcessing;

       private IDigitalFilter _digitalFilter;

      //Define variables
      private bool isRunning;
       private List<double> rawDataList;
       private List<double> processedDataList;
       private bool filterSwitchedOn;



      public DataProcessing(BlockingCollection<List<double>> dataQueue)
        {
            //create relations 
            dataCollector = new DataCollection(_dataQueue);
            _calibrate = new Calibrate();
            _unitConverter = new UnitConverter();
            dataProcessingThread = new Thread(Start);
           _digitalFilter = new DigitalFilter();

         //create variables
           _dataQueueToProcessing = dataQueue;
           processedDataList = new List<double>();
           
           //Ved ikke lige hvordan denne skal kommer herned fra præsentationslaget, men det finder vi lige ud af
           filterSwitchedOn = true;
        }

        public void Start()
        {
           //Skal denne løkke være her? Skal alt være inde i denne? FHJ
            while (isRunning = true)
            {
               
            }

           //Kør først unitconverteren
           //gem resultatet i processedDataList
           if (filterSwitchedOn==true)
           {
              processedDataList=_digitalFilter.FilterOn(processedDataList);
           }
           else
           {
              processedDataList=_digitalFilter.FilterOff(processedDataList);
           }
           _dataQueueToProcessing.Add(processedDataList);

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


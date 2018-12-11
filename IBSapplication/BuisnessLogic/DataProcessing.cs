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
        private IDataCollection _dataCollector;
        private ICalibrate _calibrate;
        private IUnitConverter _unitConverter;
        private IDigitalFilter _digitalFilter;
        private IZeroPointAdjustment _zeroPointAdjustment;

        //Define variables
        private bool isRunning;
        private List<double> rawDataList;
        private List<double> processedDataList;
        public bool filterSwitchedOn { get; set; }
        private double slope = 1;

        //Tråde
        private readonly BlockingCollection<List<double>> _dataQueue;
        private readonly BlockingCollection<List<double>> _dataQueueToCalculation;
        public Thread dataProcessingThread;

        public DataProcessing(BlockingCollection<List<double>> dataQueue, BlockingCollection<List<double>> dataQueueToCalculation, DataCollection dataCollection)
        {
            //create variables
            _dataQueueToCalculation = dataQueueToCalculation;
            _dataQueue = dataQueue;
            

            //create relations 
            _dataCollector = dataCollection;
            _calibrate = new Calibrate();
            _unitConverter = new UnitConverter();
            _digitalFilter = new DigitalFilter();
            _zeroPointAdjustment = new ZeroPointAdjustment();

            slope = _calibrate.Load(@"C:\Users\Esma\Documents\Sundhedsteknologi\3. semester\Semesterprojekt 3 - Udvikling af et blodtrykmålesystem\SW\IBSapp\IBSapplication\BuisnessLogic\bin\Debug\Slope.txt");

        }

        public void Start()
        {

            _dataCollector.StartLoading();

            while (!_dataQueue.IsCompleted)
            {
                processedDataList = new List<double>();
                try
                {
                    rawDataList = _dataQueue.Take();
                }
                catch
                {

                }
                //Kør unitconverteren
                //slope = 50;
                processedDataList = _unitConverter.GetCalibratedSampleList(rawDataList, slope, _zeroPointAdjustment.zeroPoint);
                // Digital filter

                //gem resultatet i processedDataList
                if (filterSwitchedOn == true)
                {
                    processedDataList = _digitalFilter.FilterOn(processedDataList);
                }
                else
                {
                    processedDataList = _digitalFilter.FilterOff(processedDataList);
                }
                _dataQueueToCalculation.Add(processedDataList);
            }
        }

        public void GetVoltageData(int pressureValue) // sørger for at hente det rigtige punkt for knappen, der trykkes på GUI'en
        {
            List<double> dataPointList = _dataCollector.GetSomeDataPoints();

            double sumOfDataPoints = 0;
            double averageOfDataPoints;

            for (int i = 0; i < dataPointList.Count; i++) // summen af alle datapunkterne i listen beregnes
            {
                sumOfDataPoints += dataPointList[i];
            }

            averageOfDataPoints = sumOfDataPoints / dataPointList.Count;

            _calibrate.AddVoltage(averageOfDataPoints, pressureValue);
        }

        public bool GetZeroPointAdjustment()
        {
            List<double> zeroPointMeasurement = _dataCollector.GetSomeDataPoints();

            _zeroPointAdjustment.Adjust(zeroPointMeasurement);

            return _zeroPointAdjustment.AbnormalValue;
        }

        //public BlockingCollection<List<double>> GetDataQueueToCalculation()
        //{
        //    return _dataQueueToCalculation;
        //}

        public void GetCalibration()
        {
            slope = _calibrate.Calibration();
            _calibrate.SaveSlope(slope,
                @"C:\Users\Esma\Documents\Sundhedsteknologi\3. semester\Semesterprojekt 3 - Udvikling af et blodtrykmålesystem\SW\IBSapp\IBSapplication\BuisnessLogic\bin\Debug\Slope.txt");
        }

        public void StartDataProcessingThread ()
        {
            dataProcessingThread = new Thread(Start);
            dataProcessingThread.Start();
        }

       public void JoinThreads()
       {
          _dataCollector.StopLoading();
          dataProcessingThread.Join();
       }
    }
}


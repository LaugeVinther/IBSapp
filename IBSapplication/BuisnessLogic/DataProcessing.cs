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
        private readonly BlockingCollection<List<double>> _dataQueueToCalculation;
        private IDigitalFilter _digitalFilter;
        private IZeroPointAdjustment _zeroPointAdjustment;

        //Define variables
        private bool isRunning;
        private List<double> rawDataList;
        private List<double> processedDataList;
        private bool filterSwitchedOn;
        private double slope;

        public DataProcessing()
        {
            //create relations 
            dataCollector = new DataCollection(_dataQueue);
            _calibrate = new Calibrate();
            _unitConverter = new UnitConverter();
            dataProcessingThread = new Thread(Start);
            _digitalFilter = new DigitalFilter();

            //create variables
           _dataQueueToCalculation = new BlockingCollection<List<double>>();
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

            //Hent rå data
            GetRawData();
            //Kør unitconverteren
            processedDataList = _unitConverter.GetCalibratedSampleList(rawDataList, slope);
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

        public void GetRawData() // consumer
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

        public void GetZeroPointAdjustment()
        {
            List<double> zeroPointMeasurement = dataCollector.GetSomeDataPoints();

            _zeroPointAdjustment.Adjust(zeroPointMeasurement);

        }

        public BlockingCollection<List<double>> GetDataQueueToCalculation()
        {
            return _dataQueueToCalculation;
        }

        public void GetCalibration()
        {
            slope = _calibrate.Calibration();
        }
    }
}


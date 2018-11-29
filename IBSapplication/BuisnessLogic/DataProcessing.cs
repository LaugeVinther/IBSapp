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
        private BlockingCollection<List<double>> dataQueue;
        private Calibrate _calibrate;




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
            List<double> oneDataPoint = dataCollector.GetSomeDataPoints();
            // _calibrate.AddVoltage(oneDataPoint, pressureValue);}}
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


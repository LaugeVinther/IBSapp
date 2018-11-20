using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using DTOLogic;
using DataLogic;
using System.Collections.Concurrent;
using static alglib;

namespace BusinessLogic
{
    public class Calibrate : ICalibrate
    {
        private BlockingCollection<DTO_mV> _dataQueue;

        private DataLogicIF _dataObject;
        private DTO_mmHg _DTOmmHg; // skal gemmes i denne DTO

        public Calibrate (BlockingCollection<DTO_mV> dataQueue)
        {
            _dataQueue = dataQueue;
            _DTOmmHg = new DTO_mmHg();
        }

        public void Calibration()
        {

            double convertedDataPoint;

            while (true)
            {
                for (int i = 0; i < 3; i++)
                {
                    var OneDataPoint = _dataQueue.Take();


                }
                convertedDataPoint = _DTOmmHg.modifiedSamples;

            }
        }

        public void LinearRegression(double[] Volt, double[] measurementsMmHg) // x og y koordinator
        {
            Volt = new double[] { 1, 2, 3 };
            measurementsMmHg = new double[] { 3, 4, 5 };

            Tuple<double, double> p = Fit.Line(Volt, measurementsMmHg);
            double a = p.Item1;
            double b = p.Item2;


        }
    }
}

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
        private DTO_mmHg _DTOmmHg; // skal gemmes i denne DTO

        public Calibrate()
        {
            _DTOmmHg = new DTO_mmHg();
        }

        // Klassen skal snakke med DataProcessing 

        public void Calibration(double 10mmHgMeasurement, double 50mmHgMeasurement, double 100mmHgMeasurement) // disse tre doubles skal sendes videre i parameteren 
        {
            10mmHgMeasurement 

            for (int i = 0; i < 3; i++)
            {


            }
            convertedDataPoint = _DTOmmHg.modifiedSample;

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

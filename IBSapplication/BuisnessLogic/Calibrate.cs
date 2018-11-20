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
        private double[] array = new double[2];
        private int counter = 0;

        private DTO_mmHg _DTOmmHg; // skal gemmes i denne DTO

        public Calibrate()
        {
            _DTOmmHg = new DTO_mmHg();
        }

        // Klassen skal snakke med DataProcessing 

        public void Calibration(double VoltageMeasurement) // disse tre doubles skal sendes videre i parameteren 
        {
            for (int i = 0; i <= array.Length; i++)
            {
                if (counter != 3)
                {
                    array[counter] = VoltageMeasurement;

                }
                else if (counter == 3)
                {
                    counter = 0; 
                }
                VoltageMeasurement += array[i];
            }
        }

        public double LinearRegression(double[] Volt, double[] calibrateMmHg) // x og y koordinator
        {
            Volt = new double[] {array[0], array[1], array[2]};
            calibrateMmHg = new double[] { 10, 50, 100 };

            Tuple<double, double> p = Fit.Line(Volt, calibrateMmHg);
            double a = p.Item1;
            double b = p.Item2;

            return a;

        }
    }
}

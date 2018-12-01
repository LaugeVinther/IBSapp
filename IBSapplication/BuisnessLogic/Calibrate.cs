using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using DTOLogic;
using DataLogic;
using System.Collections.Concurrent;


namespace BusinessLogic
{
    public class Calibrate : ICalibrate
    {
        private double[] voltageArray;
        private double[] pressureArray;
        private int counter = 0;
        public double Slope { get; private set; }
        public double[] Volt { get; private set; }
        public double[] calibrateMmHg { get; private set; }

        public Calibrate()
        {
            voltageArray = new double[3];
            pressureArray = new double[3];
        }

        public void AddVoltage(double voltage, int pressure)
        {
            for (int i = 0; i <= voltageArray.Length; i++)
            {
                if (counter == 3)
                {
                    counter = 0;
                }
                voltageArray[i] = voltage;
                pressureArray[i] = pressure;
            }
        }

        public void Calibration()
        {
            // regression 
            Volt = new double[] { voltageArray[0], voltageArray[1], voltageArray[2] };
            calibrateMmHg = new double[] { pressureArray[0], pressureArray[1], pressureArray[2] };

            //double hældningskoefficient_a;
            //hældningskoefficient_a = (100 - voltageArray[2]) / (10 - voltageArray[0]); // y2 - y1 / x2 - x1 
            //return hældningskoefficient_a;

            double n = Volt.Length;
            double sumxy = 0, sumx = 0, sumy = 0, sumx2 = 0;
            for (int i = 0; i < Volt.Length; i++)
            {
                sumxy += Volt[i] * calibrateMmHg[i];
                sumx += Volt[i];
                sumy += calibrateMmHg[i];
                sumx2 += Volt[i] * Volt[i];
            }

            Slope = ((sumxy - sumx * sumy / n) / (sumx2 - sumx * sumx / n));

        }

    }
}




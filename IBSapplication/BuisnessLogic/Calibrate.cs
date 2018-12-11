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
        private double slope = 1;

        public Calibrate()
        {
            voltageArray = new double[3];
            pressureArray = new double[3];
        }

        public void AddVoltage(double voltage, int pressure)
        {
            if (pressure == 10)
            {
                voltageArray[0] = voltage;
                pressureArray[0] = pressure;
            }

            if (pressure == 50)
            {
                voltageArray[1] = voltage;
                pressureArray[1] = pressure;

            }

            if (pressure == 100)
            {
                voltageArray[2] = voltage;
                pressureArray[2] = pressure;

            }

            //int counter = 0;
            //for (int i = 0; i <= voltageArray.Length; i++)
            //{
            //    if (counter == 3)
            //    {
            //        counter = 0;
            //    }
            //    voltageArray[i] = voltage;
            //    pressureArray[i] = pressure;
            //    counter++;
            //}
        }

        public double Calibration()
        {
            //double hældningskoefficient_a;
            //hældningskoefficient_a = (100 - voltageArray[2]) / (10 - voltageArray[0]); // y2 - y1 / x2 - x1 
            //return hældningskoefficient_a;

            double n = voltageArray.Length;
            double sumxy = 0, sumx = 0, sumy = 0, sumx2 = 0;
            for (int i = 0; i < voltageArray.Length; i++)
            {
                sumxy += voltageArray[i] * pressureArray[i];
                sumx += voltageArray[i];
                sumy += pressureArray[i];
                sumx2 += voltageArray[i] * voltageArray[i];
            }

            slope = ((sumxy - sumx * sumy / n) / (sumx2 - sumx * sumx / n));

            //BAre lige til test
            slope = 50;

            return slope;

        }

    }
}




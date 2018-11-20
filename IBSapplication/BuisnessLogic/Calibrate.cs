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
        private double[] voltageArray = new double[2];
        private double[] pressureArray = new double[2];
        private int counter = 0;
        private DataProcessing _dataProcessing;

        //private DTO_mmHg _DTOmmHg; // skal gemmes i denne DTO

        public Calibrate()
        {
            // _DTOmmHg = new DTO_mmHg();
        }

        // Klassen skal snakke med DataProcessing 

        public void AddVoltage(double voltage, int pressure)
        {
            _dataProcessing = new DataProcessing();

            for (int i = 0; i <= voltageArray.Length; i++)
            {
                if (counter <= 3)
                {
                    voltageArray[i] = voltage;
                    pressureArray[i] = pressure;

                }
                else if (counter > 3)
                {
                    counter = 0;
                }
            }
        }

        public double Calibration() 
        {
            // regression 
            double[] Volt = new double[] { voltageArray[0], voltageArray[1], voltageArray[2] };
            double[] calibrateMmHg = new double[] { 10, 50, 100 };

            double hældningskoefficient_a;

            hældningskoefficient_a = (100 - voltageArray[2]) / (10 - voltageArray[0]); // y2 - y1 / x2 - x1 

            return hældningskoefficient_a;

        }
    }
}

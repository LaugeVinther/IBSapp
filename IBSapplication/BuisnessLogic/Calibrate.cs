﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using DTOLogic;
using DataLogic;
using System.Collections.Concurrent;
using System.IO;
using System.Xml.Serialization;

namespace BusinessLogic
{
    public class Calibrate : ICalibrate
    {
        private double[] voltageArray;
        private double[] pressureArray;
        private int counter = 0;
        public double slope { get; set; }

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
            //slope = 50;
            return slope;
             
        }

        public void SaveSlope(double slope, string path) // vi gemmer slopen som en XML
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(double));

            serializer.Serialize(fs, slope);
            fs.Close();
        }

        public double Load (string path) 
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(double));

            slope = (double)serializer.Deserialize(fs);
            fs.Close();
            return slope;
        }
            

    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using NUnit.Framework;


namespace UnitTest
{
   [TestFixture]
    public class PulseUnitTest
   {
      private Pulse uut;

      [SetUp]
      public void SetUp()
      {
         uut = new Pulse();
      }

      [Test]
      public void CalculatePulse_21PositivNumbers_ExpectPulseIs28()
      {

         //Fra Lars
         const int SIZE = 1000;
         const int SAMPLINGSRATE = 1000;
         const int FREQUENCY = 2;

         // Funktionsbeskrivelsen
         double[] sinus = new double[SIZE];
         List<Double> ampl = new List<Double>();

         for (int t = 0; t < SIZE; t++)
            sinus[t] = 5 * Math.Sin(2 * Math.PI * (t * ((1 * FREQUENCY) / (1.0 * SAMPLINGSRATE))));
         //Slut fra Lars

         //List<double> sinusList = new List<double>();

         //for (int i = 0; i < 50; i++)
         //{
         //   double f;
         //   f = 50*Math.Sin(2 * Math.PI * (i*0.02));
         //   sinusList.Add(f);
         //}


         //double[] positivMeasurements = sinusList.ToArray();
         double[] positivMeasurements = sinus.ToArray();
         //double fs=50;
         uut.CalculatePulse(positivMeasurements,SAMPLINGSRATE);
         Assert.That(uut._dtoPulse.Pulse, Is.EqualTo(60));
      }

      [Test]
      public void CalculatePulse_21NegativNumbers_ExpectPulseIs28()
      {
         double[] negativMeasurements = new double[] { -30, -100, -30, -100, -30, -100, -30, -100, -30, -100, -30, -100, -30, -100, -30, -100, -30, -100, -30, -100, -30 };
         double fs = 1;
         uut.CalculatePulse(negativMeasurements, fs);
         Assert.That(uut._dtoPulse.Pulse, Is.EqualTo(28));
      }

    }
}

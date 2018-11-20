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
      public void CalculatePulse_FS1000F1_ExpectPulseIs60()
      {
         int size = 1000;
         int f_sample = 1000;
         int frequency = 1;

         double[] sinus = new double[size];

         for (int t = 0; t < size; t++)
            sinus[t] = 5 * Math.Sin(2 * Math.PI * (t * ((1 * frequency) / (1.0 * f_sample))));

         uut.CalculatePulse(sinus,f_sample);
         Assert.That(uut._dtoPulse.Pulse, Is.EqualTo(60));
      }

      [Test]
      public void CalculatePulse_FS1000F1_ExpectPulseIs120()
      {

         int size = 1000;
         int f_sample = 1000;
         int frequency = 2;

         double[] sinus = new double[size];
         List<Double> ampl = new List<Double>();

         for (int t = 0; t < size; t++)
            sinus[t] = 5 * Math.Sin(2 * Math.PI * (t * ((1 * frequency) / (1.0 * f_sample))));

         uut.CalculatePulse(sinus, f_sample);
         Assert.That(uut._dtoPulse.Pulse, Is.EqualTo(120));
      }

      [Test]
      public void CalculatePulse_FS1000F4_ExpectPulseIs240()
      {

         const int size = 1000;
         const int f_sample = 1000;
         const int frequency = 4;

         // Funktionsbeskrivelsen
         double[] sinus = new double[size];
         List<Double> ampl = new List<Double>();

         for (int t = 0; t < size; t++)
            sinus[t] = 5 * Math.Sin(2 * Math.PI * (t * ((1 * frequency) / (1.0 * f_sample))));
         //Slut fra Lars

         uut.CalculatePulse(sinus, f_sample);
         Assert.That(uut._dtoPulse.Pulse, Is.EqualTo(240));
      }

      [Test]
      public void CalculatePulse_FS1000F1Size20000_ExpectPulseIs60()
      {
         int size = 20000;
         int f_sample = 1000;
         int frequency = 1;

         double[] sinus = new double[size];

         for (int t = 0; t < size; t++)
            sinus[t] = 5 * Math.Sin(2 * Math.PI * (t * ((1 * frequency) / (1.0 * f_sample))));

         uut.CalculatePulse(sinus, f_sample);
         Assert.That(uut._dtoPulse.Pulse, Is.EqualTo(60));
      }
   }
}

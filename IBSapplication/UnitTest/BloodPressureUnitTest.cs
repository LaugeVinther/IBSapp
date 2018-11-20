using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BusinessLogic;

namespace UnitTest
{
   [TestFixture]
   class BloodPressureUnitTest
   {
      private BloodPressure uut;

      [SetUp]
      public void SetUp()
      {
         uut = new BloodPressure();
      }

      [Test]
      public void CalculateBP_SinusSignalA5_ExpectedSysIs5()
      {
         int size = 1000;
         int f_sample = 1000;
         int frequency = 1;

         double[] sinus = new double[size];

         for (int t = 0; t < size; t++)
            sinus[t] = 5 * Math.Sin(2 * Math.PI * (t * ((1 * frequency) / (1.0 * f_sample))));

         uut.CalculateBP(sinus, f_sample,60);
         Assert.That(uut._dtoBloodpressure.Systolic, Is.EqualTo(5));
      }

      [Test]
      public void CalculateBP_SinusSignalA5_ExpectedDiaIsMinus5()
      {
         int size = 1000;
         int f_sample = 1000;
         int frequency = 1;

         double[] sinus = new double[size];

         for (int t = 0; t < size; t++)
            sinus[t] = 5 * Math.Sin(2 * Math.PI * (t * ((1 * frequency) / (1.0 * f_sample))));

         uut.CalculateBP(sinus, f_sample, 60);
         Assert.That(uut._dtoBloodpressure.Diastolic, Is.EqualTo(-5));
      }

      [TestCase(5)]
      [TestCase(10)]
      [TestCase(20)]
      public void CalculateBP_SinusSignalAmplitudeIsA_ExpectedAverageIs0(int A)
      {
         int size = 1000;
         int f_sample = 1000;
         int frequency = 1;

         double[] sinus = new double[size];

         for (int t = 0; t < size; t++)
            sinus[t] = A * Math.Sin(2 * Math.PI * (t * ((1 * frequency) / (1.0 * f_sample))));

         uut.CalculateBP(sinus, f_sample, 60);
         Assert.That(uut._dtoBloodpressure.AverageBP, Is.EqualTo(0));
      }
   }
}

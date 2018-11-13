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
         double [] positivMeasurements = new double[]{30,100,30,100,30,100,30,100,30,100,30, 100, 30, 100, 30, 100, 30, 100, 30,100,30};
         double fs=1;
         uut.CalculatePulse(positivMeasurements,fs);
         Assert.That(uut._dtoPulse.Pulse, Is.EqualTo(28));
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

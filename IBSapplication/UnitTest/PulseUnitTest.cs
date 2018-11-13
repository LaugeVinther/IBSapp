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
      public void CalculatePulse_PositivNumbers_ExpectPulseIsX()
      {
         double [] positivMeasurements = new double[]{30,100,30,100,30,100,30,100,30};
         int fs=2;
         uut.CalculatePulse(positivMeasurements,fs);
         Assert.That(uut._dtoPulse.Pulse, Is.EqualTo(90));
      }

    }
}

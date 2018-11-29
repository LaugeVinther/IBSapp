using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace UnitTest
{
    [TestFixture]
    public class CalibrateUnitTest
    {
        private Calibrate uut;

        [SetUp]
        public void SetUp()
        {
            uut = new Calibrate();
        }

        [Test]
        public void Calibrate_GetSlopeWithThreeDataPoints_SlopeEquals1()
        {
            // test calibration metoden

            double[] Volt = {1, 2, 3 };
            double[] calibrateMmHg = {1, 2, 3};

            double n = Volt.Length;
            double sumxy = 0, sumx = 0, sumy = 0, sumx2 = 0;
            for (int i = 0; i < Volt.Length; i++)
            {
                sumxy += Volt[i] * calibrateMmHg[i];
                sumx += Volt[i];
                sumy += calibrateMmHg[i];
                sumx2 += Volt[i] * Volt[i];
            }

            double A = ((sumxy - sumx * sumy / n) / (sumx2 - sumx * sumx / n));

            Assert.That(uut.Calibration(), Is.EqualTo(1));
        }

    }
}



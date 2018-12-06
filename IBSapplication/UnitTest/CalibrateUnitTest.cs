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
        public void Calibrate_GetSlopeForThreeDataPoints_SlopeEquals1()
        {
            double[] x = { 1, 2, 3 };
            double[] y = { 1, 2, 3 };

            double a = 0;
            a = y[2] - y[0] / (x[2] - x[0]); // y2-y1 / x2-x1

            Assert.That(uut.Calibration(x, y), Is.EqualTo(1));
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using DTOLogic;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class AlarmUnitTest
    {
        private Alarm uut;

        [SetUp]
        public void SetUp()
        {
            uut = new Alarm();
        }

        [TestCase(false, false, false, false)]
        [TestCase(false, false, true, false)]
        [TestCase(false, true, true, false)]
        [TestCase(false, true, false, false)]
        public void Alarming_ThreeBPMeasurementsInitiallyFalse_OutputIsFalse(bool s1, bool s2, bool s3, bool expectedResult)
        {
            uut.CheckAlarming(s1);
            uut.CheckAlarming(s2)
            bool result = uut.CheckAlarming(s3);
            Assert.That(result, Is.EqualTo(expectedResult));
        }


        [TestCase(true, true, false, true)]
        [TestCase(true, false, false, true)]
        [TestCase(false, false, false, false)]
        public void Alarming_ThreeBPMeasurementsInitiallyTrue_OutputIsFalse(bool s1, bool s2, bool s3, bool expectedResult)
        {
            uut.CheckAlarming(true);
            uut.CheckAlarming(true);
            uut.CheckAlarming(true);
            uut.CheckAlarming(s1);
            uut.CheckAlarming(s2);
            bool result = uut.CheckAlarming(s3);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

    }
}

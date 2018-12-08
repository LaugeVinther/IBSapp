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
        private DTO_Bloodpressure dtoBloodpressure;
       

        [SetUp]
        public void SetUp()
        {
            uut = new Alarm();
            dtoBloodpressure = new DTO_Bloodpressure();
            
        }

        [TestCase(false, false, false, false)]
        [TestCase(false, false, true, false)]
        [TestCase(false, true, true, false)]
        [TestCase(true, true, false, true)]
        public void Alarming_BPMeasurementsInitiallyFa_OutputIsTrue()
        {

            dtoBloodpressure.Systolic = 190;
            dtoBloodpressure.Diastolic = 50;

            uut.CheckAlarming(dtoBloodpressure);
            bool result = uut.CheckAlarming(dtoBloodpressure);
            Assert.That(result, Is.EqualTo(true));
        }
       

    }
}

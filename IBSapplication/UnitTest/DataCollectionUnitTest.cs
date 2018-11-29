using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLogic;
using NUnit.Framework;
using DTOLogic;
using BusinessLogic;


namespace UnitTest
{
    [TestFixture]
    public class DataCollectionUnitTest
    {
        private readonly BlockingCollection<DTO_mV> _dataQueue;
        private DataCollection _uut;

        [SetUp]
        public void SetUp()
        {
            _uut = new DataCollection(_dataQueue);
        }

        [Test]
        public void GetOneDataPoint_WavegenDC1V_OndDataPointEqual1plusminus0point05()
        {
        //    double _oneDataPoint = 0;

        //    _oneDataPoint = _uut.GetOneDataPoint();
            Assert.That(_uut.GetOneDataPoint(), Is.EqualTo(1));
        }
    }
}

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
        private readonly BlockingCollection<List<double>> _dataQueue;
        private DataCollection _uut;

        [SetUp]
        public void SetUp()
        {
            _uut = new DataCollection(_dataQueue);
        }

        [Test]
        public void GetSomeDataPoint_WavegenDC1V_SomeDataPointEqualsAround1()
        {
            double meanValue = 0;
            List<double> values = _uut.GetSomeDataPoints();
            foreach (double value in values)
            {
                meanValue += value;
            }

            meanValue = meanValue / values.Count;

            Assert.That(Math.Round(meanValue), Is.EqualTo(1));
        }
        [Test]
        public void GetSomeDataPoint_Gets5DataPoint()
        {
            int number =_uut.GetSomeDataPoints().Count;

            Assert.That(number, Is.EqualTo(5));
        }
    }
}

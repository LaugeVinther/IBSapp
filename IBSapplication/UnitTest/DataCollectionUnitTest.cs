using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLogic;
using NUnit.Framework;
using DTOLogic;


namespace UnitTest
{
    [TestFixture]
    public class DataCollectionUnitTest
    {
        private readonly BlockingCollection<>
        private DataCollection _uut;

        [SetUp]
        public void SetUp()
        {
            _uut = new DataCollection
        }
    }

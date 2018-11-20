using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLogic;
using Interfaces;
using DTOLogic;

namespace BusinessLogic
{
    public class DataProcessing
    {
        private DataCollection dataCollector;
        private DataLogicIF _dataobject;

        private bool isRunning;

        public DataProcessing()
        {
            _dataobject = new DataCollection();
            _dataobjeckt = new DataBase
        }

        public void Start()
        {
            while (isRunning = true)
            {

            }
        }

        public void GetCalibration ()
        {
            _dataobject.GetOneDataPoint();
        }

        public void Safe()
        {
            
        }
    }
}

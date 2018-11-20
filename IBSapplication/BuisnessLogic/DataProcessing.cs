using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLogic;
using Interfaces;

namespace BusinessLogic
{
    public class DataProcessing
    {
        private DataLogicIF _dataobject;

        private bool isRunning;

        public DataProcessing()
        {
            _dataobject = new DataCollection();
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
    }
}

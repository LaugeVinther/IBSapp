using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;
using Interfaces;

namespace BusinessLogic
{
    public class UnitConverter
    {
        private List<double> calibratedSampleList = new List<double>();
        private DataProcessing dataProcessing;

        public UnitConverter ()
        {
            dataProcessing = new DataProcessing();
        }

        public List<double> GetCalibratedSampleList()
        {
            foreach (var convertDataPoint in dataProcessing.GetRawData())
            {
                calibratedSampleList.Add(convertDataPoint * dataProcessing.GetSlope());
            }
            return calibratedSampleList;
        }
    }
}

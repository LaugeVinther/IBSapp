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

        public void convertData()
        {
            foreach (var convertDataPoint in dataProcessing.rawSamples)
            {
                calibratedSampleList.Add(convertDataPoint * dataProcessing.GetCalibration());
            }
        }

        public List<double> GetCalibratedSampleList()
        {
            return calibratedSampleList;
        }
    }
}

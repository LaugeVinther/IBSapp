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
        private DTO_mV dto_convert { get; set; }
        private List<double> calibratedSampleList = new List<double>();
        private DataProcessing dataProcessing;

        public UnitConverter ()
        {
            dto_convert = new DTO_mV();
            dataProcessing = new DataProcessing();
        }

        public void convertData()
        {
            foreach (var convertDataPoint in dto_convert.rawSamples)
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

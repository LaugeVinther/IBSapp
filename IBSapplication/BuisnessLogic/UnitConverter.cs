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
        private DataProcessing dataProcessing;
        private DTO_mV dto_convert { get; set; }
        private List<double> calibratedSampleList = new List<double>();


        public UnitConverter()
        {
            dataProcessing = new DataProcessing();
            dto_convert = new DTO_mV();
        }

        public void convertData()
        {
            double slope;
            slope = dataProcessing.GetCalibration();

            foreach (var convertDataPoint in dto_convert.rawSamples )
            {
                calibratedSampleList.Add(convertDataPoint * slope);
            }
        }

        public List<double> GetCalibratedSampleList()
        {
            return calibratedSampleList;
        }
    }
}

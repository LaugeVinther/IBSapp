using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;
using Interfaces;

namespace BusinessLogic
{
    public class UnitConverter : IUnitConverter
    {
        private List<double> calibratedSampleList = new List<double>();

        public UnitConverter ()
        {
        }

        public List<double> GetCalibratedSampleList(List<double> rawDataList, double slope, double zeroPoint)
        {
            foreach (var convertDataPoint in rawDataList)
            {
                double localConverDataPoint = convertDataPoint;
                localConverDataPoint = convertDataPoint - zeroPoint; 
                calibratedSampleList.Add(localConverDataPoint * slope);
                
            }
            return calibratedSampleList;
        }
    }
}

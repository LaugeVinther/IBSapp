using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using DTOLogic;

namespace BusinessLogic
{
    class ZeroPointAdjustment : IZeroPointAdjustment
    {
        public double zeroPoint { get; set; }

        public void Adjust(List<double> zeroPointMeasurement)
        {
            double localZeroPoint = 0;

            foreach (double measurement in zeroPointMeasurement)
            {
                localZeroPoint = +measurement;
            }

            localZeroPoint = localZeroPoint / zeroPointMeasurement.Count;

            zeroPoint = localZeroPoint;

        }
    }
}

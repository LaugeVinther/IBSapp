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
        public bool AbnormalValue { get; set; }

        public ZeroPointAdjustment()
        {
            AbnormalValue = false;
        }

        public void Adjust(List<double> zeroPointMeasurement)
        {
            double localZeroPoint = 0;

            foreach (double measurement in zeroPointMeasurement)
            {
                localZeroPoint = +measurement;
            }

            localZeroPoint = localZeroPoint / zeroPointMeasurement.Count;

            if (localZeroPoint < 0.1)
            {
                zeroPoint = localZeroPoint;
                AbnormalValue = false;
            }
            else
            {
                zeroPoint = 0;
                AbnormalValue = true;
            }

        }
    }
}

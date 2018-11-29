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
        public DTO_mmHg zeroPoint { get; set; }

        public void Adjust(List<DTO_mmHg> zeroPointMeasurement)
        {
            double localZeroPoint = 0;

            foreach (DTO_mmHg measurement in zeroPointMeasurement)
            {
               
            }



            
        }
    }
}

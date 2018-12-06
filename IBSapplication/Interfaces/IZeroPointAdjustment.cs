using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;

namespace Interfaces
{
    public interface IZeroPointAdjustment
    {
        double zeroPoint { get; }
        bool AbnormalValue { get; }
        void Adjust(List<double> zeroPointMeasurement);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;

namespace Interfaces
{
    public interface IUnitConverter
    {
        List<double> GetCalibratedSampleList(List<double> List, double slope, double zeroPoint);
    }
}

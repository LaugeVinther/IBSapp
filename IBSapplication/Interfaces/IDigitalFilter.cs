using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;

namespace Interfaces
{
    public interface IDigitalFilter
    {
        void FilterOn(List<double> calibratedSampleList);
        void FilterOff(List<double> calibratedSampleList);
    }
}

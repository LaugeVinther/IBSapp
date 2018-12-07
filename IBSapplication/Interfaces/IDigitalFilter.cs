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
        List<double> FilterOn(List<double> calibratedSampleList);
        List<double> FilterOff(List<double> calibratedSampleList);

       List<double> DownSampling(List<double> calibratedSampleList);
    }
}

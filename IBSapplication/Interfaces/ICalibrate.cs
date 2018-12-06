using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICalibrate
    {
        void AddVoltage(double oneDataPoint, int pressureValue);
        double Calibration(double[] voltAxis, double[] pressureAxis);
    }
}

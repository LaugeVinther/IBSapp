using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICalibrate
    {
        double Slope { get; }
        double[] Volt { get; }
        double[] calibrateMmHg { get; }
        void AddVoltage(double oneDataPoint, int pressureValue);
        double Calibration();
    }
}

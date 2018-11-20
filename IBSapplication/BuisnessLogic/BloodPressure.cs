using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;
using Interfaces;

namespace BusinessLogic
{
    class BloodPressure : IBloodPressure
    {
       public DTO_Bloodpressure _dtoBloodpressure;

       public BloodPressure()
       {
          _dtoBloodpressure = new DTO_Bloodpressure();
       }

       public void CalculateBP(double [] measurements, double fs,int pulse)
       {
          int numberOfElementsIn2Cycles = (int)(fs * 2) * (1 /pulse);
          double max = measurements[measurements.Length-1];
          double min = measurements[measurements.Length - 1];
          double sum = 0;

          for (int i = numberOfElementsIn2Cycles; i > 0; i--)
          {
             if (measurements[i] > max)
             {
                max = measurements[i];
             }

             if (measurements[i] < min)
             {
                min = measurements[i];
             }

             sum += measurements[i];
          }

          _dtoBloodpressure.AverageBP = (int)(sum / numberOfElementsIn2Cycles);
          _dtoBloodpressure.Diastolic = (int)min;
          _dtoBloodpressure.Systolic = (int)max;
       }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;
using Interfaces;

namespace BusinessLogic
{
    public class BloodPressure : IBloodPressure
    {
        public DTO_Bloodpressure _dtoBloodpressure { get; private set; }
    


        public BloodPressure(Alarm alarm)
       {
          _dtoBloodpressure = new DTO_Bloodpressure();
           
       }

       public void CalculateBP(double [] measurements, double fs,int pulse)
       {
          int numberOfElementsIn2Cycles = (int)((fs * 2) * pulse);
          double max = measurements[measurements.Length - 1];
          double min = measurements[measurements.Length - 1];
          double sum = 0;

          if (numberOfElementsIn2Cycles > measurements.Length)
          {
             numberOfElementsIn2Cycles = measurements.Length;
          }
          //hvis numberOff er større end størrelsen på arrayeet så skal numberOff være lig med længden af asrrayet

          for (int i = numberOfElementsIn2Cycles-1; i > 0; i--)
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

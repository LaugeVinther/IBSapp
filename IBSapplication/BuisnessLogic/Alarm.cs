using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class Alarm
    {
       public int SystolicMaxThreshold { get; set; }
       public int SystolicMinThreshold { get; set; }
       public int DiastolicMaxThreshold { get; set; }
       public int DiastolicMinThreshold { get; set; }
      public void getThresholds(int sysMax, int sysMin, int diaMax, int diaMin)
      {
         SystolicMaxThreshold = sysMax;
         SystolicMinThreshold = sysMin;
         DiastolicMaxThreshold = diaMax;
         DiastolicMinThreshold = diaMin;
      }
    }
}

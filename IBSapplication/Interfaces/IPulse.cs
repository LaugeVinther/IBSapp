using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;

namespace Interfaces
{
   public interface IPulse
   {
      int  _pulse { get; }
      void CalculatePulse(double[] measurements, double f_sample);
   }
}

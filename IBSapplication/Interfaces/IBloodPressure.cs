﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;

namespace Interfaces
{
    public interface IBloodPressure
    {
       DTO_Bloodpressure _dtoBloodpressure { get; }
      void CalculateBP(double[] measurements, double f_sample, int Pulse);
    }
}

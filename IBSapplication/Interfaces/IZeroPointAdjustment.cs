﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;

namespace Interfaces
{
    public interface IZeroPointAdjustment
    {
        void Adjust(List<DTO_mmHg> zeroPointMeasurement);
    }
}

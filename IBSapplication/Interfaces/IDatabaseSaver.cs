﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;

namespace Interfaces
{
    public interface IDatabaseSaver
    {
        void SaveToDatabase(DTO_SaveData basicData, byte[] byteArray);
    }
}

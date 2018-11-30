using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;

namespace Interfaces
{
    public interface IAlarm
    {
        void GetTresholds(int thresholdupperdia, int thresholdlowerdia, int thresholduppersys, int thresholdlowersys);
        bool CheckAlarming(DTO_Bloodpressure dtoBloodpressure);


    }
}

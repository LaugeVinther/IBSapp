using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BusinessLogic
{
    class AlarmSettings : IAlarmSettings
    {
        private bool activeLight = false;

        public void LightAndSoundAlarm()
        {
            activeLight = true;
        }
    }
}

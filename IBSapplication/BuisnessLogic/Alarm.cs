using Interfaces;
using System.Collections.Generic;
using System.Linq;
using DTOLogic;
using System;

namespace BusinessLogic
{
    public class Alarm : IAlarm
    {

        private int _thresholdUpperDia;
        private int _thresholdLowerDia;
        private int _thresholdUpperSys;
        private int _thresholdLowerSys;
        public bool IsAlarmActivated = false;
        private bool[] _alarmArray; 
      


        public Alarm()
        {
            _thresholdUpperDia = 110;
            _thresholdLowerDia = 60;
            _thresholdUpperSys = 180;
            _thresholdLowerSys = 90;
            _alarmArray = new bool[3];

        }

        public bool CheckAlarming(DTO_Bloodpressure dtoBloodpressure)
        {
            if (dtoBloodpressure.Systolic > _thresholdUpperSys || dtoBloodpressure.Systolic < _thresholdLowerSys || dtoBloodpressure.Diastolic > _thresholdUpperDia || dtoBloodpressure.Diastolic < _thresholdLowerDia)
            {

                _alarmArray[2] = _alarmArray[1];
                _alarmArray[1] = _alarmArray[0];
                _alarmArray[0] = true;
               
              
            }
            else 
            {
                _alarmArray[2] = _alarmArray[1];
                _alarmArray[1] = _alarmArray[0];
                _alarmArray[0] = false;
            }
           
      
            if (_alarmArray[0] == true && _alarmArray[1] == true && _alarmArray[2] == true)
            {
                IsAlarmActivated = true;

            }


            return IsAlarmActivated;
        }
        public void GetTresholds(int thresholdupperdia, int thresholdlowerdia, int thresholduppersys, int thresholdlowersys)
        {
            _thresholdUpperDia = thresholdupperdia;
            _thresholdLowerDia = thresholdlowerdia;
            _thresholdUpperSys = thresholduppersys;
            _thresholdLowerSys = thresholdlowersys;
        }

    }
}

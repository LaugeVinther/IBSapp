using Interfaces;
using System.Collections.Generic;
using System.Linq;
using DTOLogic;
using System;
using System.Media;
using System.Threading;

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
      private SoundPlayer _player;
       public Thread AlarmThread;
       public bool AlarmThreadIsStarted;



      public Alarm()
        {
            _thresholdUpperDia = 110;
            _thresholdLowerDia = 60;
            _thresholdUpperSys = 90;
            _thresholdLowerSys = 180;
            _alarmArray = new bool[3];
         _player = new System.Media.SoundPlayer(@"C:\Users\FridaH\Documents\ST\ST3\PRJ\alarm_high_priority_5overtoner.wav"); //korrekt stinavn skal indsættes
           AlarmThread = new Thread(Alarming);
           AlarmThreadIsStarted = false;

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
               if (AlarmThreadIsStarted == false)
               {
                  AlarmThread.Start();
                  AlarmThreadIsStarted = true;
               }
         }
            else
            {
               IsAlarmActivated = false;
               if (AlarmThreadIsStarted == true)
               {
                  AlarmThread.Join();
                  AlarmThreadIsStarted = false;
               }
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

       public void Alarming()
       {
          while (true)
          {
             _player.Play();
          }
       }

    }
}

﻿using Interfaces;
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
        public bool IsAlarmActivated;
        private bool[] _alarmArray;
        private SoundPlayer _player;
        public Thread AlarmThread;
        public bool AlarmThreadIsStarted;
        public bool ProgramRunning { get; set; }



        public Alarm()
        {
            _thresholdUpperDia = 110;
            _thresholdLowerDia = 60;
            _thresholdUpperSys = 180;
            _thresholdLowerSys = 90;
            _alarmArray = new bool[3];
            //_player = new System.Media.SoundPlayer(@"C:\BuisnessLogic\Alarm\alarm_high_priority_5overtoner.wav"); //korrekt stinavn skal indsættes
            _player = new System.Media.SoundPlayer(@"C:\Users\FridaH\Documents\ST\ST3\PRJ\alarm_high_priority_5overtoner.wav"); //korrekt stinavn skal indsættes
            //_player = new System.Media.SoundPlayer(@"C:\Users\Esma\Documents\Sundhedsteknologi\3. semester\Semesterprojekt 3 - Udvikling af et blodtrykmålesystem\SW\IBSapp\IBSapplication\IBSapplication\bin\Debug\alarm_high_priority_5overtoner.wav");
            AlarmThread = new Thread(Alarming);
            AlarmThreadIsStarted = false;
            IsAlarmActivated = false;
            ProgramRunning = false;

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
                    ProgramRunning = true;
                }
            }
            else
            {
                IsAlarmActivated = false;
                if (AlarmThreadIsStarted == true)
                {
                    AlarmThread.Join();
                    AlarmThreadIsStarted = false;
                    ProgramRunning = false;
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
          while (ProgramRunning == true)
          {
             _player.Play();
              Thread.Sleep(4000);
          }
       }

    }
}

using Interfaces;
using System.Collections.Generic;
using System.Linq;
using DTOLogic;
using System;

namespace BusinessLogic
{
    public class Alarm : IAlarm
    {

        private int ThresholdUpperDia;
        private int ThresholdLowerDia;
        private int ThresholdUpperSys;
        private int ThresholdLowerSys;
        private AlarmSettings alarmSettings;


        //private List<double> processedDataList;
        //private DataProcessing dataProcessing;
        //private IProcessedDataCollector _processedDataCollector;


        public Alarm()
        {
            ThresholdUpperDia = 110;
            ThresholdLowerDia = 60;
            ThresholdUpperSys = 90;
            ThresholdLowerSys = 180;

        }
        public void GetTresholds(int thresholdupperdia, int thresholdlowerdia, int thresholduppersys, int thresholdlowersys)
        {
            ThresholdUpperDia = thresholdupperdia;
            ThresholdLowerDia = thresholdlowerdia;
            ThresholdUpperSys = thresholduppersys;
            ThresholdLowerSys = thresholdlowersys;
        }

        public void ActivateAlarm(DTO_Bloodpressure dtoBloodpressure)
        {
            if (dtoBloodpressure.Systolic > ThresholdUpperSys || dtoBloodpressure.Systolic < ThresholdLowerSys || dtoBloodpressure.Diastolic > ThresholdUpperDia || dtoBloodpressure.Diastolic < ThresholdLowerDia)
            {
                alarmSettings.LightAndSoundAlarm();
            }              
        }

        public void DeactivateAlarm(DTO_Bloodpressure dtoBloodpressure)
        {
            if (dtoBloodpressure.Systolic < ThresholdUpperSys && dtoBloodpressure.Systolic > ThresholdLowerSys && dtoBloodpressure.Diastolic < ThresholdUpperDia && dtoBloodpressure.Diastolic > ThresholdLowerDia)
            {
                //ActivateAlarm() = false;
            }

            //if (ActivateAlarm() == false)
            //{
            //    alarmSettings.LightAndSoundAlarm() = false;
            //}
            //hvilken måde er lettest at bruge?

        }

    }
}

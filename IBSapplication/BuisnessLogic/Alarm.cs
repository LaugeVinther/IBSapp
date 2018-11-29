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


        //private List<double> processedDataList;
        //private DataProcessing dataProcessing;
        //private IProcessedDataCollector _processedDataCollector;


        public Alarm()
        {
            _thresholdUpperDia = 110;
            _thresholdLowerDia = 60;
            _thresholdUpperSys = 90;
            _thresholdLowerSys = 180;

        }
        public void GetTresholds(int thresholdupperdia, int thresholdlowerdia, int thresholduppersys, int thresholdlowersys)
        {
            _thresholdUpperDia = thresholdupperdia;
            _thresholdLowerDia = thresholdlowerdia;
            _thresholdUpperSys = thresholduppersys;
            _thresholdLowerSys = thresholdlowersys;
        }

        public void ActivateAlarm(DTO_Bloodpressure dtoBloodpressure)
        {
            if (dtoBloodpressure.Systolic > _thresholdUpperSys || dtoBloodpressure.Systolic < _thresholdLowerSys || dtoBloodpressure.Diastolic > _thresholdUpperDia || dtoBloodpressure.Diastolic < _thresholdLowerDia)
            {
                IsAlarmActivated = true;
            }              
        }

        public void DeactivateAlarm(DTO_Bloodpressure dtoBloodpressure)
        {
            if (dtoBloodpressure.Systolic < _thresholdUpperSys && dtoBloodpressure.Systolic > _thresholdLowerSys && dtoBloodpressure.Diastolic < _thresholdUpperDia && dtoBloodpressure.Diastolic > _thresholdLowerDia)
            {
                IsAlarmActivated = false;
            }

        }

    }
}

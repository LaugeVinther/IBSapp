using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;
using DataLogic;
using Interfaces;

namespace BusinessLogic
{
    public class DataCalculation
    {
        private DataProcessing _dataProcessing;
       private IPulse _pulse;
       private IBloodPressure _bloodPressure;
       private Alarm alarm;
       private IProcessedDataCollector _processedDataCollector;
       private IDatabaseSaver _databaseSaver;
       private IBinFormatter _binFormatter;
       private List<double> _processedDataList;

      //Define variables
      public int CalculatedPulseValue { get; private set; }
       public int CalculatedSystolicValue { get; private set; }
       public int CalculatedDiastolicValue { get; private set; }
       public int CalculatedAverageBPValue { get; private set; }
       public int SystolicMaxThreshold { get; set; }
       public int SystolicMinThreshold { get; set; }
       public int DiastolicMaxThreshold { get; set; }
       public int DiastolicMinThreshold { get; set; }
       private int f_sample;

      public DataCalculation(DataProcessing dataProcessing)
        {
            _dataProcessing = dataProcessing;
           _pulse = new Pulse();
           _bloodPressure = new BloodPressure();
           _processedDataCollector = new ProcessedDataCollector();
           _databaseSaver = new DatabaseSaver();
           _binFormatter = new BinFormatter();

         //create variables
         f_sample = 1000;
           CalculatedPulseValue = 0;
           CalculatedSystolicValue = 0;
           CalculatedDiastolicValue = 0;
           CalculatedAverageBPValue = 0;
      }

        public void doDataCalculation()
        {
           //liste i næste linje er den liste som opsamles med blockingcollection
           _processedDataList = _processedDataCollector.getProcessedDataList(liste);
           _pulse.CalculatePulse(_processedDataList.ToArray(), f_sample);
           CalculatedPulseValue = _pulse.Pulse;
           _bloodPressure.CalculateBP(_processedDataList.ToArray(), f_sample, CalculatedPulseValue);
           CalculatedSystolicValue = _bloodPressure._dtoBloodpressure.Systolic;
           CalculatedDiastolicValue = _bloodPressure._dtoBloodpressure.Diastolic;
           CalculatedAverageBPValue = _bloodPressure._dtoBloodpressure.AverageBP;

      }
       public void Safe(DTO_SaveData savedataDTO)
       {
          byte[] binArray = _binFormatter.ConvertToByteArray(_processedDataList);

          _databaseSaver.SaveToDatabase(savedataDTO, binArray);

       }
       public void SetThresholds()
       {
          alarm.GetTresholds(SystolicMaxThreshold, SystolicMinThreshold, DiastolicMaxThreshold, DiastolicMinThreshold);
       }
   }
}

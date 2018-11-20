using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;
using Interfaces;

namespace BusinessLogic
{
    class ProcessedDataCollector : IProcessedDataCollector
    {
      List<double> ProcessedData = new List<double>();

        public ProcessedDataCollector()
        {
           
        }

        public void collectData(DTO_mmHg mmHgDTO)
        {
            foreach (var sample in mmHgDTO.modifiedSamples)
            {
                ProcessedData.Add(sample);
            }
            
        }

        public List<double> GetAllProcessedData()
        {
            return ProcessedData;
        }
    }
}

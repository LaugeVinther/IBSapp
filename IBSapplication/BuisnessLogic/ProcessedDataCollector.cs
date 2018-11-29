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
      private List<double> processedDataList = new List<double>();
        
        public List<double> getProcessedDataList(DTO_mmHg mmHgDTO)
        {
            foreach (var sample in mmHgDTO.modifiedSamples)
            {
                processedDataList.Add(sample);
            }

           return processedDataList;
        }
    }
}

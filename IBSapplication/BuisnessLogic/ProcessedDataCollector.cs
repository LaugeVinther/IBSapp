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
        
        public List<double> getProcessedDataList(List<double> listFromDigitalFilter)
        {
            foreach (var sample in listFromDigitalFilter)
            {
                processedDataList.Add(sample);
            }

           return processedDataList;
        }
    }
}

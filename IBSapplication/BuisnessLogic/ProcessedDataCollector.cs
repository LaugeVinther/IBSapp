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
          if (processedDataList.Count > 7000000)
          {
             for (int i = 0; i < 1000; i++)
             {
                processedDataList.RemoveAt(0);
             }
          }
          else
          {
             foreach (var sample in listFromDigitalFilter)
             {
                processedDataList.Add(sample);
             }
          }

       

       //try
         //{
         //   foreach (var sample in listFromDigitalFilter)
         //   {
         //      processedDataList.Add(sample);
         //   }
         // }
         //catch (Exception e)
         //{
         // for (int i = 0; i < 1000; i++)
         // {
         //    processedDataList.RemoveAt(0);
         // }
         //   foreach (var sample in listFromDigitalFilter)
         //   {
         //      processedDataList.Add(sample);
         //   }
      

           

           return processedDataList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;
using Interfaces;

namespace BusinessLogic
{
    public class DigitalFilter : IDigitalFilter
    {
       public List<double> downSampledSamples { get; private set; }
       public List<double> smoothedSamples { get; private set; }

      public DigitalFilter()
       {
          smoothedSamples=new List<double>();
       }
       public void FilterOn(List<double> calibratedSampleList) 
       {
         //Kør først downsampling 
          Downsampling(calibratedSampleList);

         //Herefter lav midlingsfilter på de nedsamlede data
          int length = downSampledSamples.Count();
          List<double> samples = downSampledSamples;

          for (int i = 5; i < length - 5; i ++)
          {
             double sum = 0;
             for (int j = -5; j < 5; j++)
             {
                sum += samples[i + j];
             }

             smoothedSamples.Add(sum / 5);
          }
      }

       public void FilterOff(List<double> calibratedSampleList) 
       {
          Downsampling(calibratedSampleList);
       }

       public void Downsampling(List<double> calibratedSampleList)
       {
          int length = calibratedSampleList.Count();
          List<double> samples = calibratedSampleList;
         for (int i = 9; i < length - 9; i += 19)
          {
             double sum = 0;
             for (int j = -9; j < 9; j++)
             {
                sum += samples[i + j];
             }

             downSampledSamples.Add(sum / (9 + 1 + 9));
          }

      }
    }
}

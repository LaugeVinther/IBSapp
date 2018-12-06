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
           downSampledSamples = new List<double>();
          smoothedSamples=new List<double>();
       }
       public List<double> FilterOn(List<double> calibratedSampleList) 
       {
         //Kør først downsampling 
          DownSampling(calibratedSampleList);

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

          return smoothedSamples;
       }

       public List<double> FilterOff(List<double> calibratedSampleList) 
       {
          DownSampling(calibratedSampleList);
          return downSampledSamples;
       }

       public void DownSampling(List<double> calibratedSampleList)
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

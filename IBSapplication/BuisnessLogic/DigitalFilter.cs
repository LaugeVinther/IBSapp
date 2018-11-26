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
       public void FilterOn(DTO_mmHg dtoMmHg)
       {
         //Kør først downsampling derefter gør nedenfor på de downsamplede data
          int length = dtoMmHg.modifiedSamples.Count();
          List<double> samples = dtoMmHg.modifiedSamples;

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

       public void FilterOff(DTO_mmHg dtoMmHg)
       {
          Downsampling(dtoMmHg);
       }

       public void Downsampling(DTO_mmHg dtoMmHg)
       {
          int length = dtoMmHg.modifiedSamples.Count();
          List<double> samples = dtoMmHg.modifiedSamples;
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

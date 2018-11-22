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
         //Gør som i som i SmootingFilter men med 25 på hver side 
          int length = dtoMmHg.modifiedSamples.Count();
          List<double> samples = dtoMmHg.modifiedSamples;

          for (int i = 5; i < length - 5; i ++)
          {
             double sum = 0;
             double weight = 0;
             for (int j = -5; j < 5; j++)
             {
                weight = 1/5;
                sum += weight * samples[i + j];
             }

             smoothedSamples.Add(sum / (25 + 1 + 25));
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
         for (int i = 9; i < length - 9; i += 18)
          {
             double sum = 0;
             double weight = 0;
             for (int j = -9; j < 9; j++)
             {
                weight = (9 - Math.Abs(j) + 1);
                sum += samples[i + j];
             }

             downSampledSamples.Add(sum / (9 + 1 + 9));
          }

      }
    }
}

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
        //public List<double> downSampledSamples { get; private set; }
        //public List<double> smoothedSamples { get; private set; }

        public DigitalFilter()
        {

        }
        public List<double> FilterOn(List<double> calibratedSampleList)
        {

            List<double> smoothedSamples = new List<double>();
            //Kør først downsampling 


            //Herefter lav midlingsfilter på de nedsamlede data
            List<double> samples = DownSampling(calibratedSampleList);
            int length = samples.Count();


            for (int i = 5; i < length - 5; i++)
            {
                double sum = 0;
                for (int j = -5; j < 0; j++)
                {
                    sum += samples[i + j];
                }

                smoothedSamples.Add(sum / 5);
            }

            return smoothedSamples;
        }

        public List<double> FilterOff(List<double> calibratedSampleList)
        {
            return DownSampling(calibratedSampleList);
        }

        public List<double> DownSampling(List<double> calibratedSampleList)
        {
            List<double> downSampledSamples = new List<double>();
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

            return downSampledSamples;

        }
    }
}

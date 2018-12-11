using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using static alglib;
using DTOLogic;

namespace BusinessLogic
{
    public class Pulse : IPulse
    {
       public int pulse { get; private set; }

      public Pulse()
       {
          pulse = 0;
       }

       public void CalculatePulse(double[] measurements, double f_sample)
       {
          double [] _measurements = new double[10000];

          if (measurements.Length>f_sample*10)
          {
             int start = (measurements.Length-1) - (int)(10 * f_sample);
             int element = 0;
             for (int i = start; i < measurements.Length-1; i++)
             {
                _measurements[element] = measurements[i];
                element++;
             }
          }
          else
          {
            _measurements = measurements;
         }

          int length = _measurements.Length;
          alglib.complex[] measurementsComplexs = new complex[length];
          List<double> Amplitude = new List<double>();

         //Udfør Fourier
         alglib.fftr1d(_measurements, out measurementsComplexs);

          //Regn amplituder for alle pladser i arrayet med komplekse værdier
          foreach (var measurement in measurementsComplexs)
          {
             double amplitude = Math.Sqrt(Math.Pow(measurement.x, 2) + Math.Pow(measurement.y, 2));
             Amplitude.Add(amplitude);
          }

          //Gennemløb hele listen og find max amplituden - denne er grundfrekvensen
          double max = Amplitude[1];
          int index = 0;

          //Vi skal se bort fra målingen på plads 0. Og dividere med 2 for at undgå spejling
          for (int i = 1; i < Amplitude.Count/2; i++)
          {
             if (Amplitude[i] > max)
             {
                max = Amplitude[i];
                index = i;
             }
          }

          //Beregn frekvensen til denne plads ved at finde frekvensopløsningen (formel fra DSB lektion 5)
          //Først beregnes frekvensopløsningen
          double f_req = (index*f_sample) / Amplitude.Count; 

          //Beregn analysefrekvensen (frekvensen ved index i)
          //double f_analysis = f_resolution * index;

          //Frekvensen er i Hz (svingninger pr sekund) det omregnes til puls
          pulse = (int)(f_req * 60);


          //Arrayet vi får ud har på hver plads et komplekst tal. Amplituden er længden af det komplekse tal.
          //Regn amplituderne og find den med den højeste amplitude.
          //Udfra vores samplingsfrekvens og pladsen på arrayet kan vi finde frekvensen til den plads. Lars siger vi skal prøve at finde det på nettet selv. 
       }

    }
}

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
       public DTO_Pulse _dtoPulse {  get; private set; }

       public Pulse()
       {
          _dtoPulse = new DTO_Pulse();
       }
       public void CalculatePulse(double[] measurements, double f_sample)
       {
          double[] _measurements = measurements;
          int length = _measurements.Length;
          alglib.complex[] measurementsComplexs = new complex[length];
          List<double> Amplitude = new List<double>();
          //Brug event-handler-delegation halløj til hele tiden at få den seneste liste fra ProcessedDataCollecter 
          //Eller også ligger dette ovenfor i Datacontroller
          //Lav liste over de sidste 10 sekunder
          //Lav FFT på listen over de sidste 10 sekunder. 
          //Find grundfrekvensen
          //Bestem perioden for grundfrekvensen
          //Omregn periden til puls (find ud af sammenhængen?)
          //Skriv pulsen ind i DTO_Pulse

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
          double f_resolution = f_sample / Amplitude.Count; 

          //Beregn analysefrekvensen (frekvensen ved index i)
          double f_analysis = f_resolution * index;

          //Frekvensen er i Hz (svingninger pr sekund) det omregnes til puls
          int _pulse = (int)(f_analysis * 60);

          //Find 
          _dtoPulse.Pulse = _pulse;



          //Arrayet vi får ud har på hver plads et komplekst tal. Amplituden er længden af det komplekse tal.
          //Regn amplituderne og find den med den højeste amplitude.
          //Udfra vores samplingsfrekvens og pladsen på arrayet kan vi finde frekvensen til den plads. Lars siger vi skal prøve at finde det på nettet selv. 
       }

    }
}

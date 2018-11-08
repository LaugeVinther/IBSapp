using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BusinessLogic
{
    class Pulse : IPulse
    {
       public void CalculatePulse()
       {
          //Brug event-handler-delegation halløj til hele tiden at få den seneste liste fra ProcessedDataCollecter 
          //Eller også ligger dette ovenfor i Datacontroller
          //Lav liste over de sidste 10 sekunder
          //Lav FFT på listen over de sidste 10 sekunder. 
          //Find grundfrekvensen
          //Bestem perioden for grundfrekvensen
          //Omregn periden til puls (find ud af sammenhængen?)
          //Skriv pulsen ind i DTO_Pulse

       }
    }
}

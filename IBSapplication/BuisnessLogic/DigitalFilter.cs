using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BusinessLogic
{
    public class DigitalFilter : IDigitalFilter
    {

       public void FilterOn()
       {
          //Do something to the signal
          //Lav et lavpasfilter
          //Find ud af om man kan lave lavpas-filter med alglib
       }

       public void FilterOff()
       {
          //Do nothing to the signal
       }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using NUnit.Framework;

namespace UnitTest
{
   [TestFixture]

   class UnitTestDigitalFilter
   {
      private DigitalFilter uut;

      [SetUp]
      public void SetUp()
      {
         uut = new DigitalFilter();
      }

      //Kan man overhovedet lave test på det, altså vi kan plotte signalet før og efter og sammenligne,
      //men kan vi lave en Assert?
   }
}

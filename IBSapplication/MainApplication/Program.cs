using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLogic;
using BusinessLogic;
using PresentationLogic;

namespace MainApplication
{
    class Program
    {
        private PresentationLogic.CtrlWinFormGUI currentPL;
        private BusinessLogic.CtrlBuisnessLogic currentBL;
        private DataLogic.CtrlDataLogic currentDL;

        static void Main(string[] args)
        {
        }

        public Program()
        {
            currentPL = new CtrlWinFormGUI(currentBL);
            currentBL = new CtrlBuisnessLogic(currentDL);
            currentDL = new CtrlDataLogic();
        }

    }
}

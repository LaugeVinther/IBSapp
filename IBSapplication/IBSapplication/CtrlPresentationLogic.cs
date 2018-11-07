using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace PresentationLogic
{
    public class CtrlPresentationLogic
    {
        public class CtrlWinFormGUI : PresentationLogicIF
        {
            private BuisnessLogicIF currentBuisnessLogic;

            public CtrlWinFormGUI(BuisnessLogicIF buisnessLogic)
            {
                this.currentBuisnessLogic = buisnessLogic;
            }
        }
    }
}

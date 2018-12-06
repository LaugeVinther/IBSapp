using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;

namespace PresentationLogic
{
    public class CtrlWinFormGUI //: PresentationLogicIF
    {
        //private BuisnessLogicIF currentBuisnessLogic;

        //public CtrlWinFormGUI(BuisnessLogicIF buisnessLogic)
        //{
        //    this.currentBuisnessLogic = buisnessLogic;
        //}

        //[STAThread]  //Tilføjes 
        //public void startUpGUI()
        //{
        //    Application.EnableVisualStyles(); //Tilføjes
        //    Application.SetCompatibleTextRenderingDefault(false); //Tiføjes
        //    Application.DoEvents();// Tilføjes
        //    Application.Run(new PrimaryForm(currentBuisnessLogic)); //Tilføjes !!Dobbelt Dependency Injection!!
        //}
    }
}

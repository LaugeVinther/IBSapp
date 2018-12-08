using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using DataLogic;
using BusinessLogic;
using NUnit.Framework;
using PresentationLogic;

namespace MainApplication
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            BlockingCollection<List<double>> dataQueueToProcessing = new BlockingCollection<List<double>>();
            BlockingCollection<List<double>> dataQueueToCalculation = new BlockingCollection<List<double>>();
            DataCollection dataCollector = new DataCollection(dataQueueToProcessing);
            DatabaseSaver DBS = new DatabaseSaver();

            DataProcessing DP = new DataProcessing(dataQueueToProcessing,dataQueueToCalculation, dataCollector);
            DataCalculation DC = new DataCalculation(dataQueueToCalculation, DBS);
            

            CtrlWinFormGUI Control = new CtrlWinFormGUI();

            Control.startUpGUI(DP,DC);


        //private PresentationLogic.CtrlWinFormGUI currentPL;
        //private BusinessLogic.CtrlBuisnessLogic currentBL;
        //private DataLogic.CtrlDataLogic currentDL;

       
        }

        //public Program()
        //{
        //    currentPL = new CtrlWinFormGUI(currentBL);
        //    currentBL = new CtrlBuisnessLogic(currentDL);
        //    currentDL = new CtrlDataLogic();
        //}

    }
}

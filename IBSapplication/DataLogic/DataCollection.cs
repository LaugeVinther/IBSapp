using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;

namespace DataLogic
{
    class DataCollection
    {
        //private DTO_MeasuredData _DTOMeasuredData;


        //public void LoadData()
        //{

        //}

    //    //Nedenfor er kode fra sidste semester.
    //    List<DTO_EKGDAQ> EKG_DataListe;
    //    double[] EKG_DataArray;
    //    public List<DTO_EKGDAQ> GetEKGdata()
    //    {
    //        EKG_DataArray = new double[2500];
    //        EKG_DataListe = new List<DTO_EKGDAQ>();


    //        //1 Opret en ST2Prj2LibNI-DAQ komponent
    //        NI_DAQVoltage datacollector = new NI_DAQVoltage();


    //        //4 Kun 10 målinger i dette eksempel. Property på datacollector
    //        datacollector.samplesPerChannel = 2500;

    //        //5 Valg af Dev1 enhed og ai0 input kanal. Property på datacollector
    //        datacollector.deviceName = "Dev1/ai0";

    //        //6 Begynd dataopsamlign med ST2Prj2LibNI-DAQ komponent 
    //        //og returnere først når alle målinger er udført
    //        datacollector.getVoltageSeqBlocking();

    //        EKG_DataArray = datacollector.currentVoltageSeqArray;

    //        for (int i = 0; i < EKG_DataArray.Length; i++)
    //        {
    //            double sekunder = 0.004 * (i + 1);
    //            EKG_DataListe.Add(new DTO_EKGDAQ(sekunder, Math.Round((EKG_DataArray[i]), 3)));

    //        }

    //        //9 Og "Farewell"
    //        return EKG_DataListe;
    //    }
    }
}

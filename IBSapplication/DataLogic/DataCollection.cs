using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;
using NationalInstruments.DAQmx;
using System.Threading;
using Interfaces;

namespace DataLogic
{
    public class DataCollection : IDataCollection
    {
        private BlockingCollection<List<double>> _dataQueue;
        private bool keepLoading = false;
        public Thread dataLogicThread;

        public DataCollection(BlockingCollection<List<double>> dataQueue)
        {
            _dataQueue = dataQueue;
        }

        public void StartLoading()
        {
            if(_dataQueue.IsAddingCompleted)
                _dataQueue = new BlockingCollection<List<double>>();
            keepLoading = true;
            dataLogicThread = new Thread(LoadData);
            dataLogicThread.Start();
        }

       public void StopLoading()
       {
            keepLoading = false;
            dataLogicThread.Join();
       }

        public void LoadData()
        {
            keepLoading = true;

            //Oprettelse af DAQ:
           // NI_DAQ daq = new NI_DAQ();

            //5 Valg af Dev1 enhed og ai0 input kanal. Property på datacollector:
            //daq.deviceName = "Dev1/ai0";

            while (keepLoading == true)
            {
                List<double> currentmV;
                //DTO_mV currentDTO = new DTO_mV();
                //daq.getVoltageSeqBlocking();

                //currentmV = daq.currentVoltageSeq;
                currentmV = LavTestSamples();
                //currentDTO.rawSamples = daq.currentVoltageSeq;

                _dataQueue.Add(currentmV);
                Thread.Sleep(1000);
                Thread.Yield();
            }

            //Måske vi skal ahve noget kode, der giver hver sample en tid.
            //for (int i = 0; i < EKG_DataArray.Length; i++)
            //{
            //    double sekunder = 0.004 * (i + 1);
            //    EKG_DataListe.Add(new DTO_EKGDAQ(sekunder, Math.Round((EKG_DataArray[i]), 3)));

            //}

            _dataQueue.CompleteAdding();
        }

        public List<double> GetSomeDataPoints()
        {
            //Oprettelse af lokal double til at gemme det enkelte datapunkt
            List<double> fiveDataPoint;

            //Oprettelse af DAQ:
            NI_DAQ daq = new NI_DAQ();

            //5 Valg af Dev1 enhed og ai0 input kanal. Property på datacollector:
            daq.deviceName = "Dev1/ai0";

            //Angivelse af samples der skal måles.
            daq.samplesPerChannel = 5;
            
            //Foretager målingen
            daq.getVoltageSeqBlocking();

            fiveDataPoint = daq.currentVoltageSeq;
            
            return fiveDataPoint;
        }

        public List<double> LavTestSamples() //til blodtryk
        {
            const int SIZE = 1000000;
            const int SAMPLINGSRATE = 1000;
            const int FREQUENCY = 1;

            // Funktionsbeskrivelsen
            double[] sinus = new double[SIZE];

            for (int t = 0; t < SIZE; t++)
                sinus[t] = 10 * Math.Sin(2 * Math.PI * (t * ((1 * FREQUENCY) / (1.0 * SAMPLINGSRATE))));

            return sinus.ToList();
        }

    }
}

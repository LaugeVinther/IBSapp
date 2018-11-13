using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;
using NationalInstruments.DAQmx;
using System.Threading;

namespace DataLogic
{
    class DataCollection
    {
        private readonly BlockingCollection<DTO_mV> _dataQueue;
        private bool keepLoading = false;

        public DataCollection(BlockingCollection<DTO_mV> dataQueue)
        {
            _dataQueue = dataQueue;
        }

        public void LoadData()
        {
            //Oprettelse af DAQ:
            NI_DAQ daq = new NI_DAQ();

            //5 Valg af Dev1 enhed og ai0 input kanal. Property på datacollector:
            daq.deviceName = "Dev1/ai0";

            while (keepLoading == true)
            {
                DTO_mV currentDTO = new DTO_mV(); 
                daq.getVoltageSeqBlocking();

                currentDTO.rawSamples = daq.currentVoltageSeq;

                _dataQueue.Add(currentDTO);
            }

            //Måske vi skal ahve noget kode, der giver hver sample en tid.
            //for (int i = 0; i < EKG_DataArray.Length; i++)
            //{
            //    double sekunder = 0.004 * (i + 1);
            //    EKG_DataListe.Add(new DTO_EKGDAQ(sekunder, Math.Round((EKG_DataArray[i]), 3)));

            //}

            _dataQueue.CompleteAdding();
        }
    }
}

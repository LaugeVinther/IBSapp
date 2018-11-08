using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments.DAQmx;


namespace DataLogic
{
    class NI_DAQ
    {
        private NationalInstruments.DAQmx.Task readerTask;                //Main Task variable which gets called in the Main Function
        private AnalogMultiChannelReader reader; //NI DAQ reader
        //private int totalSamples = 2500;       //Global container for the number of samples to acquire
        private NationalInstruments.AnalogWaveform<double>[] data; //NI DAQ internal datamodel


        private List<double> currentVoltageSeqPrivate; //Last voltage seqeunce collected, numbers according til value of totalSamples
        /// <summary>
        /// Gives a copy as an array to the latest sequence of voltage meassurings 
        /// </summary>
        public double[] currentVoltageSeqArray { get { return currentVoltageSeqPrivate.ToArray(); } }

        /// <summary>
        /// Gives a copy of the latest sequence of voltage meassurings
        /// </summary>
        public List<double> currentVoltageSeq { get { return new List<double>(currentVoltageSeqPrivate); } }

        /// <summary>
        /// Get or set the sample rate in Hz to collect the collect the sequence of voltage meassurings
        /// Default if not set is 250Hz
        /// </summary>
        public double sampleRateInHz { get; set; }

        /// <summary>
        /// Get or set the minimum voltage to read in Volt Ex: -1.0 for -1.0 V
        /// Default if not set is -1.0 Volt
        /// </summary>
        public double rangeMinimumVolt { get; set; }

        /// <summary>
        /// Get or set the maximum voltage to read in Volt Ex: 1.0 for 1.0 V
        /// Default if not set is 1.0 Volt
        /// </summary>
        public double rangeMaximumVolt { get; set; }


        /// <summary>
        /// Get or set the number of samples to read per channel (in this case only one channel)
        /// Default if not set is 3600
        /// </summary>
        public int samplesPerChannel { get; set; }


        /// <summary>
        /// Get or set the collection timeout in millisecond ex 2500 is 2500 millisecond
        /// Default if not set is infinite ms (-1 seconds)
        /// If set to -1 gives infinite wait for reading
        /// </summary>
        public int seqTimeOut { get; set; }

        /// <summary>
        /// Set or get the name of the current device being used
        /// Ex: "Dev2/ai0"
        /// Default if not set is "Dev2/ai0"
        /// </summary>
        public string deviceName { get; set; }


        public NI_DAQ()
        {
            // Initialize local variables
            sampleRateInHz = 250;
            rangeMinimumVolt = -1.2;
            rangeMaximumVolt = 1.2;
            samplesPerChannel = 3600;
            deviceName = "Dev1/ai0";
            seqTimeOut = -1;

        }
        /// <summary>
        /// Calling this metod will start a blocking sequnce of voltage meassurement at the NI USB-6009 DAQ.
        /// Before calling this metod you must have set the following properties 
        ///     sampleRateInHz (Default 205 Hz)
        ///     rangeMinimumVolt (Default -1.0 Volt)
        ///     rangeMaximumVolt (Default 1.0 Volt)
        ///     samplesPerChannel (Default 3600)
        ///     deviceName (Default "Dev2/ai0")
        ///     seqTimeOut (Default infine ms)
        /// unless the default properties values goes.
        /// To get the last measurements use either
        ///     currentVoltageSeq that returns a copy List<double> 
        ///     currentVoltageSeqArray that returns a copy in an double[]  array
        /// </summary>
        public void getVoltageSeqBlocking()
        {
            try
            {
                // Create a new task
                readerTask = new NationalInstruments.DAQmx.Task(); //The background task reading 

                // Create a channel
                readerTask.AIChannels.CreateVoltageChannel(deviceName, "",
                    (AITerminalConfiguration)(-1), rangeMinimumVolt, rangeMaximumVolt, AIVoltageUnits.Volts);

                // Configure timing specs    
                readerTask.Timing.ConfigureSampleClock("", sampleRateInHz, SampleClockActiveEdge.Rising,
                    SampleQuantityMode.FiniteSamples, samplesPerChannel);
                readerTask.Stream.Timeout = seqTimeOut;

                // Verify the task
                readerTask.Control(TaskAction.Verify);

                //Preppare NI DAQ reader and a myTask to reader
                reader = new AnalogMultiChannelReader(readerTask.Stream);

                // Read the data 
                data = reader.ReadWaveform(samplesPerChannel);//This call is a "Blocking call"

                dataToDataTable(data);
            }
            catch (DaqException exception)
            {
                System.Diagnostics.Debug.WriteLine(exception);
            }
            finally
            {
                readerTask.Dispose();

            }
        }


        private void dataToDataTable(NationalInstruments.AnalogWaveform<double>[] sourceArray)
        {
            // Iterate over channels in this case only one channel
            int currentLineIndex = 0;
            currentVoltageSeqPrivate = new List<double>(); //Previous version is deleted
            foreach (NationalInstruments.AnalogWaveform<double> waveform in sourceArray)
            {
                for (int sample = 0; sample < waveform.Samples.Count; ++sample)
                {
                    currentVoltageSeqPrivate.Add(waveform.Samples[sample].Value);
                }
                currentLineIndex++;
            }
        }
    }
}

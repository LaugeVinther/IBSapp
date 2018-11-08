using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLogic
{
    public class DTO_MeasuredData
    {
        public List<double> RawData { get; set; }

        public  List<double> ConvertedData { get; set; }

        public List<double> FilteredData { get; set; }

        public int SystolicBP { get; set; }

        public int DiastolicBP { get; set; }

        public int AvgBP { get; set; }

        public int Pulse { get; set; }
    }
}

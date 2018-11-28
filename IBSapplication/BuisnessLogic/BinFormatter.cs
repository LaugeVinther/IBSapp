using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using Interfaces;

namespace BusinessLogic
{
    class BinFormatter : IBinFormatter
    {
        private byte[] _byteArray;
        private MemoryStream _mf;
        private BinaryFormatter _bf;

        public BinFormatter()
        {
            _mf = new MemoryStream();
            _bf = new BinaryFormatter();
        }

        public byte[] ConvertToByteArray(List<double> processedDataList)
        {
            _bf.Serialize(_mf, processedDataList);
            _byteArray = _mf.ToArray();

            return _byteArray;
        }


    }
}

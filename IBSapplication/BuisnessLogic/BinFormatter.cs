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
        private MemoryStream _ms;
        private BinaryFormatter _bf;

        public BinFormatter()
        {
            _ms = new MemoryStream();
            _bf = new BinaryFormatter();
        }

        public byte[] ConvertToByteArray(List<double> processedDataList)
        {
            _bf.Serialize(_ms, processedDataList);
            _byteArray = _ms.ToArray();

            return _byteArray;
        }


    }
}

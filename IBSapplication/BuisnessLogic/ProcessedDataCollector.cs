using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;
using Interfaces;

namespace BusinessLogic
{
    class ProcessedDataCollector : IProcessedDataCollector
    {
        private DTO_mmHg mmHgDTO;
        List<DTO_mmHg> ProcessedData = new List<DTO_mmHg>();

        public ProcessedDataCollector()
        {
            mmHgDTO = new DTO_mmHg();
        }

        public void collectData()
        {
            ProcessedData.Add(mmHgDTO);
        }

        public List<DTO_mmHg> GetAllProcessedData()
        {
            return ProcessedData;
        }
    }
}

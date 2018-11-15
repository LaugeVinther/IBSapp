using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;

namespace BusinessLogic
{
    class ProcessedDataCollector
    {
        DTO_mmHg mmHgDTO = new DTO_mmHg();
        List<DTO_mmHg> ProcessedData = new List<DTO_mmHg>();

        public void collectData()
        {
            ProcessedData.Add(mmHgDTO);
        }
    }
}

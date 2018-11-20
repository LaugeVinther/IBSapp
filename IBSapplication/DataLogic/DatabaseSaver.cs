using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  DTOLogic;

namespace DataLogic
{
    class DatabaseSaver
    {
        private DTO_SaveData _saveDataDTO;
       
        
        public DatabaseSaver()
        {
            _saveDataDTO = new DTO_SaveData();
        }

        public void SaveToDataBase(List<DTO_mmHg> processedDataList)
        {
            
        }
    }
}

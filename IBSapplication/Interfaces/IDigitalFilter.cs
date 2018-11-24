using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLogic;

namespace Interfaces
{
    public interface IDigitalFilter
    {
        void FilterOn(DTO_mmHg dtoMmHg);
        void FilterOff(DTO_mmHg dtoMmHg);
    }
}

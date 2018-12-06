using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IDataCollection
    {
        void StartLoading();
        void LoadData();
       void StopLoading();
        List<double> GetSomeDataPoints();
    }
}

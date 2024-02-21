using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DI.ComputerComponent
{
    public interface IRAM : IProduct
    {
        int Capacity { get; set;}
        int Speed { get; set;}
    }
}

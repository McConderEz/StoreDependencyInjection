using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DI.ComputerComponent
{
    public interface IPSU : IProduct
    {
        int PowerCapacity { get; set; }
        string EfficiencyRating { get; set; }
    }
}

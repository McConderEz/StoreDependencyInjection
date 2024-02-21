using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DI.ComputerComponent
{
    public interface ICPU : IProduct
    {
        double ClockSpeed { get; set; }
        int Cores { get; set; }
        int CacheSize { get; set; }
        bool SupportVirtualization { get; set; }
        string Architecture { get; set; }
        string Socket { get; set; }
        IGPU IntegratedChip { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DI.ComputerComponent
{
    public interface IGPU : IProduct
    {
        int MaxResolutionX { get; set; }
        int MaxResolutionY { get; set; }
        int VRAMCapacity { get; set; }
        double Speed { get; set; }
        IGraphicAPI API { get; set; }
    }
}

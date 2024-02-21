using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DI.ComputerComponent
{
    public interface IMotherboard : IProduct
    {
        string SocketType { get; set; }
        string FormFactor { get; set; }
        string Chipset { get; set; }
        int MemorySlots { get; set; }
    }
}

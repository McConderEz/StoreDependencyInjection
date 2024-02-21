using Store.DI.ComputerComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Bll.Model.ComputerModel
{
    public class Motherboard : IMotherboard
    {
        public string SocketType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FormFactor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Chipset { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MemorySlots { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Quantity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DisplayInfo()
        {
            throw new NotImplementedException();
        }
    }
}

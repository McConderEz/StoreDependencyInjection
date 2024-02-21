using Store.DI.ComputerComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Bll.Model.ComputerModel
{
    public class Videocard : IGPU
    {
        public int MaxResolutionX { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MaxResolutionY { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int VRAMCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IGraphicAPI API { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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

using Store.DI.ComputerComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Bll.Model.ComputerModel
{
    public class Processor : ICPU
    {
        public double ClockSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Cores { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CacheSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool SupportVirtualization { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Architecture { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Socket { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IGPU IntegratedChip { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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

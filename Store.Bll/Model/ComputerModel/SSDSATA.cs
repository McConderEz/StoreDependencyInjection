using Store.DI.ComputerComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Bll.Model.ComputerModel
{
    public class SSDSATA : IDataStorageDevice
    {
        public int Capacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double ReadSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double WriteSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Quantity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Connector { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DisplayInfo()
        {
            throw new NotImplementedException();
        }
    }
}

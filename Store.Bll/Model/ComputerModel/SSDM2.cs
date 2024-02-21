using Store.DI.ComputerComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Bll.Model.ComputerModel
{
    internal class SSDM2 : IDataStorageDevice
    {
        public int Capacity { get; set; }
        public double ReadSpeed { get; set; }
        public double WriteSpeed { get; set; }
        public string Connector { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public void DisplayInfo()
        {
            throw new NotImplementedException();
        }
    }
}

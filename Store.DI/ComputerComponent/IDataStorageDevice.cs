using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DI.ComputerComponent
{
    public interface IDataStorageDevice : IProduct
    {
        int Capacity { get; set; }
        double ReadSpeed { get; set; }
        double WriteSpeed { get; set; }
        string Connector { get; set; }
        string Type { get; set; }
    }
}

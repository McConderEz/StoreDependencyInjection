using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DI
{
    public interface IShop
    {
        string Name { get; set; }
        string Address { get; set; } 

        void Add(IProduct product);
        IEnumerable<IProduct> GetAllProduct();
        ICheck Sell(IProduct product);
    }
}

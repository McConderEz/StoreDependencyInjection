using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DI
{
    public interface ICheck
    {
        IShop Shop { get; set; }
        IProduct Product { get; set; }
        DateTime DateTime { get; set; }
    }
}

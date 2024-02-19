using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DI
{
    public interface IShoppingCart
    {
        IEnumerable<IProduct> Items { get; set;}
        decimal TotalPrice { get; set;}
        int ItemCount { get; set;} 
        bool IsEmpty { get; set;}
        void AddItem(IProduct product);
        void RemoveItem(IProduct product);
        void GetAllItems();
        void Clear();

    }
}

using Store.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Bll.Model
{
    internal class ComputerShop : IShop
    {
        private string _name;
        private string _address;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }
                _name = value;
            }
        }
        public string Address
        {
            get => _address;
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }
                _address = value;
            }
        }

        public void Add(IProduct product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public ICheck Sell(IProduct product)
        {
            throw new NotImplementedException();
        }
    }
}

using Store.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Bll.Model
{
    public class Computer : IProduct
    {
        private string _name;
        private decimal _price;
        private string _description;
        private int _quantity;

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

        public decimal Price
        {
            get => _price;
            set
            {
                //if (!decimal.TryParse(value, out decimal validValue) || validValue < 0)
                //{
                //    throw new ArgumentException(nameof(value));
                //}

                //_price = validValue;

            }
        }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Quantity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DisplayInfo()
        {
            throw new NotImplementedException();
        }
    }
}

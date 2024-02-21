using Store.DI;
using Store.DI.ComputerComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Bll.Model.ComputerModel
{
    public class Computer : IProduct
    {
        private string _name;
        private string _description;
        private decimal _price;
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
                if (!decimal.TryParse(value.ToString(), out decimal validValue) || validValue < 0)
                {
                    throw new ArgumentException(nameof(value));
                }

                _price = validValue;
            }
        }
        public string Description
        {
            get => _description;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }

                _description = value;
            }
        }
        public int Quantity
        {
            get => _quantity;
            set
            {
                if (!int.TryParse(value.ToString(), out int valueValid) || valueValid < 0)
                {
                    throw new ArgumentException(nameof(value));
                }

                _quantity = valueValid;
            }
        }

        public ICPU CPU { get; set; }
        public IGPU GPU { get; set; }
        public IPSU PSU { get; set; }
        public IMotherboard Motherboard { get; set; }
        public IDataStorageDevice DataStorageDevice { get; set; }
        public IRAM RAM { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name}\t{Price}\t{Quantity}\n{Description}");
        }
    }
}

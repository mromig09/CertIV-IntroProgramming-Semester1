using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public class VendingMachine
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public VendingMachine(string name, float price)
        {
            this.Name = name;
            this.Price = price;
        }
    }

    public class Clothing : VendingMachine
    {
        public Clothing(string name, float price, string size, bool used) : base(name, price)
        {
            Size = size;
            Used = used;
        }
        public string Size { get; set; }
        public bool Used { get; set; }
        public void Wear()
        {
            if (Used == false);
        }
                   
    }

    public class Food : VendingMachine
    {
        public Food(string name, float price, int grossWeight) : base(name, price)
        {
            GrossWeight = grossWeight;
        }
        public int GrossWeight { get; set; }
        public void Eat()
        {
            Console.WriteLine("");
        }      
    }
}

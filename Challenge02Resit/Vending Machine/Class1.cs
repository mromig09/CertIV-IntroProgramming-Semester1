using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public abstract class Item
    {
        public string Name;
        public float Price;
    }

    public class Food : Item
    {
        public int GrossWeight;

        public Food(string name, float price, int grossweight)
        {
            Name = name;
            Price = price;
            GrossWeight = grossweight;
        }

        public void Eat()
        {
            GrossWeight = 0;
        }
    }

    public class Clothing : Item
    {
        public Clothing(string name, float price, string size, bool used) 
        {
            Name = name;
            Price = price;
            Size = size;
            Used = used;
        }
        public string Size { get; set; }
        public bool Used { get; set; }
        public void Wear()
        {
            if (Used == true);
        }
    }
}

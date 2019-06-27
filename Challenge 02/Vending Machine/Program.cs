using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Budget");
            Console.Read();


            Clothing tshirt = new Clothing("T-Shirt", 15, "S", false);
            Console.WriteLine("Clothing: " + tshirt.Name);
            Console.WriteLine("Price: " + tshirt.Price);
            Console.WriteLine("Size: " + tshirt.Size);
            tshirt.Wear();

            Clothing pants = new Clothing("Pants", 70, "L", true);
            Console.WriteLine("Clothing: " + pants.Name);
            Console.WriteLine("Price: " + pants.Price);
            Console.WriteLine("Size: " + pants.Size);
            pants.Wear();

            Clothing hat = new Clothing("Hat", 25, "M", false);
            Console.WriteLine("Clothing: " + hat.Name);
            Console.WriteLine("Price: " + hat.Price);
            Console.WriteLine("Size: " + hat.Size);
            hat.Wear();

            Console.WriteLine("-------------------");

            Food fruit = new Food("Apple", 1.25f, 200);
            Console.WriteLine("Food: " + fruit.Name);
            Console.WriteLine("Price: " + fruit.Price);
            Console.WriteLine("Gross Weight (grams): " + fruit.GrossWeight);
            fruit.Eat();

            Food junk = new Food("McDonalds", 12.50f, 600);
            Console.WriteLine("Food: " + junk.Name);
            Console.WriteLine("Price: " + junk.Price);
            Console.WriteLine("Gross Weight (grams): " + junk.GrossWeight);
            junk.Eat();

            Food snack = new Food("Cheese Doritos", 4.50f, 127);
            Console.WriteLine("Food: " + snack.Name);
            Console.WriteLine("Price: " + snack.Price);
            Console.WriteLine("Gross Weight (grams): " + snack.GrossWeight);
            junk.Eat();

            Console.ReadKey();
        }
    }
}

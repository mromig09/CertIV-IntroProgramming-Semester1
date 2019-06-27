using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Program
    {
        static List<Item> items = new List<Item>();
        public string Name { get; set; }
        public string Price { get; set; }
        static void Main(string[] args)
        {
            float budget = getBudget();
            string input = "";

            while(input.ToLower() != "e")
            {
                Console.WriteLine();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Would you like to: ");
                Console.WriteLine("(A) Add Item: ");
                Console.WriteLine("(C) Check Budget");
                Console.WriteLine("(E) Exit: ");
                Console.WriteLine("Enter Selection");

                input = Console.ReadLine();

                if(input.ToLower() == "a")
                {
                    addItem();
                }
                else if(input.ToLower() == "c")
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine();

                    float total = 0f;
                    foreach (var i in items)
                    {
                        total += i.Price;
                    }

                    //add code to calculate if items exceed budget
                    //example below gets everything from items and prints name and price
                    foreach (Item i in items)
                    {
                        Console.WriteLine(i.Name + " $" + i.Price);
                    }

                    Console.WriteLine("Current Budget = " + (budget - total));
                        if (budget >= total)
                    {
                        Console.WriteLine("There is $ " + (budget - total) + "left");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Funds, You only have $" + (budget));
                    }
                        //print message indicating current budget and whether items exceed budget or not
                }
            }
        }


        static void addItem()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            string input = "";
            string name;
            float price = -1f;
            string itemType = "";
            string itemSize;

            Console.Write("Enter Item Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Item Price: ");
            input = Console.ReadLine();
            price = float.Parse(input);

            // Edit from this point to impliment clothing
            //Get Item type

            Console.WriteLine("Enter Item Type: (C) Clothes or (F) Food");
            itemType = Console.ReadLine();

            if(itemType.ToLower() == "c")
            {
                List<string> Size = new List<string>() { "S", "M", "L" };
                Console.WriteLine("Size to choose: (1)S, (2)M, (3)L");
                itemSize = Console.ReadLine();
                Size.Add(itemSize);

                Clothing newclothing = new Clothing(name, price, itemSize, true);
                items.Add(newclothing);
            }
            //get data for food, this may be of an example.

            if(itemType.ToLower() == "f")
            {
                int grossWeight = -1;

                Console.Write("Enter Gross Weight: ");
                input = Console.ReadLine();
                grossWeight = int.Parse(input);

                Food newFood = new Food(name, price, grossWeight);
                items.Add(newFood);


            } 
        }

        static float getBudget()
        {
            string input = "";
            float price = -1f;

            Console.Write("Please Enter Budget: $");
            input = Console.ReadLine();
            price = float.Parse(input);

            return price;
        }
    }
}

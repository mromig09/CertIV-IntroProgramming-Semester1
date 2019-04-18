using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> iList = new List<int>();
            iList.Add(9);
            iList.Add(7);
            iList.Add(6);
            iList.Add(10);
            iList.Add(20);

            foreach (object i in iList)
            {
                Console.Write(i);
            }

            Console.WriteLine(" Enter another number");
            int input = int.Parse(Console.ReadLine());
            if (iList.Contains(input))           
            {
                Console.WriteLine("The number "+input+" already exists");
            } else
            {
                Console.WriteLine("Number doesn't exist in the list");
            }
            Console.ReadKey(true);
        }
    }
}

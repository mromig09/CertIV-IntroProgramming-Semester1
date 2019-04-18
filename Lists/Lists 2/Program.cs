using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> iList = new List<int>();
            iList.Add(9);
            iList.Add(9);
            iList.Add(6);
            iList.Add(10);
            iList.Add(9);

            foreach (object i in iList)
            {
                Console.Write(i);
            }

            Console.WriteLine(" Enter another number");
            int input = int.Parse(Console.ReadLine());
            
            int count = 0;

            for (int i = 0; i < 0; i++)
            Console.WriteLine();

            if (count > 0)

            {
                Console.WriteLine("The number " + input + " already exists");
                int index = iList.IndexOf(item: 9, index: 1);
            }
            else
            {
                Console.WriteLine("Number doesn't exist in the list");
            }
            Console.ReadKey(true);
        }
    }
}

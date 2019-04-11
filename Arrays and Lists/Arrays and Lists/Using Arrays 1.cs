using System;

namespace Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {                        
            int i = 0;
            int count = 0;
            string[] names = new string[5];

            while (count < names.Length)
            {
                Console.WriteLine("Enter Name: ");
                names[count] = Console.ReadLine();
                count++;
            }

            while (i < names.Length)
            {
                Console.Write(" Hello " + names[i]);
                i++;
            }
           
            Console.ReadKey(true);
        }
    }
}

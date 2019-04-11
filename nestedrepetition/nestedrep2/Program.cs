using System;

namespace nestedrep2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string Mark = Console.ReadLine();

            Console.Write("How many times? ");
            int amount = int.Parse(Console.ReadLine());
               
            int loop = 0;

            while (loop < amount)
            {
                Console.Write(Mark);
                loop++;
            }

            Console.ReadKey(true);
        }
    }
}

using System;

namespace nestedrepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string Mark = Console.ReadLine();

            int loop = 0;

            while (loop < 10)
            {
                Console.Write(Mark);
                loop++;
            }

            Console.ReadKey(true);
        }
    }
}

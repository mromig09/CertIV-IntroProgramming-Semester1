using System;

namespace Exercise2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many times? ");
            int amount = int.Parse(Console.ReadLine());

            int loop = amount;
            int loop2 = loop;

            while (loop > 0)
            {
                loop2 = loop;

                while (loop2 > 0)
                {
                    Console.Write("x");
                    loop2 = loop2 - 1;
                }
                Console.WriteLine();
                loop = loop - 1;
            }
            Console.ReadKey(true);
        }
    }
}

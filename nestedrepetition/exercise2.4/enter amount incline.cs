using System;

namespace exercise2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many times? ");
            int amount = int.Parse(Console.ReadLine());

            int loop = 1;
            int loop2 = loop;

            while (loop <= amount)
            {
                loop2 = loop;

                while (loop2 > 0)
                {
                    Console.Write("x");
                    loop2 = loop2 - 1;
                }
                Console.WriteLine();
                loop = loop + 1;
            }
            Console.ReadKey(true);
        }
    }
}

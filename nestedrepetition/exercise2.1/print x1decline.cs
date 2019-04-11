using System;

namespace exercise2._1
{
    class Program
    {
        static void Main(string[] args)
        {            
            int loop = 5;
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

using System;

namespace Using_Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("34, 5, 67, 1, 99, 34, 44, 78, 34, 0"); 
            
            int[] arr = new int[] { 34, 5, 67, 1, 99, 34, 44, 78, 34, 0 };
            int sum = 0;
            int i = 0;

            while (i < arr.Length)
            {
                sum = sum + arr[i];
                i++;  
            }
            Console.WriteLine(sum);

            Console.ReadKey(true);
        }
    }
}

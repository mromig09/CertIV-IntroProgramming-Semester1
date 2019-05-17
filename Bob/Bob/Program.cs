using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[6];

            List<int> listValues = new List<int>();
            listValues.Add(5);
            listValues.RemoveAt(0);

            WriteAllValues(values);
            Console.WriteLine("Hello World");
        }

           static void WriteAllValues(int[] values)
            {
                for (var index = 0; index < values.Length; index++)
                {
                    var value = values[index];
                    Console.WriteLine(value);

                }
            }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Dog myDog = new Dog("Staffy", "Mark");
            myDog.Move();

            Console.ReadLine();
        }
    }
}

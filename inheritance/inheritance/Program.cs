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
            Console.WriteLine("My Animals");
            Console.WriteLine("-------------");

            Dog myDog = new Dog("Staffy", "Mark");
            myDog.Name = " Wednesday";
            Console.WriteLine("Name: " + myDog.Name);
            myDog.OwnerName = " Mark";
            Console.WriteLine("Owner:" + myDog.OwnerName);
            myDog.Breed = " Dog - Staffy";
            Console.WriteLine("Breed:" + myDog.Breed);
            myDog.Talk();
            myDog.Move();
            Console.WriteLine();

            Cat myCat = new Cat("Max", "Tabby");
            myCat.Name = " Max";
            Console.WriteLine("Name:" + myCat.Name);
            myCat.OwnerName = " Mark";
            Console.WriteLine("Owner:" + myCat.OwnerName);
            myCat.Breed = " Cat - Tabby";
            Console.WriteLine("Breed:" + myCat.Breed);
            myCat.Talk();
            myCat.Move();
            Console.WriteLine();

            Bear myBear = new Bear("Cayde", "Mark", "Grizzly", "Brown");
            myBear.Name = " Cayde";
            Console.WriteLine("Name: " + myBear.Name);
            myBear.OwnerName = " Mark";
            Console.WriteLine("Owner:" + myBear.OwnerName);
            myBear.Breed = " Bear - Grizzly";
            Console.WriteLine("Breed:" + myBear.Breed);
            myBear.Color = " Brown";
            Console.WriteLine("Color:" + myBear.Color);
            myBear.Talk();
            myBear.Move();
            

            Console.ReadLine();
        }
    }
}

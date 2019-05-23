using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo2
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public int DateOfBirth()
        {
            return 2019 - Age;
        }

    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person(23, "Sara");
            Person person2 = new Person(33, "Frank");
            Person person3 = new Person(57, "Brian");
            Person person4 = new Person(40, "Mitch");
            Person person5 = new Person(20, "Lucy");
            Person person6 = new Person(15, "Betty");
            Person person7 = new Person(18, "Rachel");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" First Name  |   Age   |   Date Of Birth");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("".PadLeft(04) + person1.Name + "".PadLeft(10) + person1.Age + "".PadLeft(11) + person1.DateOfBirth());
            Console.WriteLine("".PadLeft(04) + person2.Name + "".PadLeft(09) + person2.Age + "".PadLeft(11) + person2.DateOfBirth());
            Console.WriteLine("".PadLeft(04) + person3.Name + "".PadLeft(09) + person3.Age + "".PadLeft(11) + person3.DateOfBirth());
            Console.WriteLine("".PadLeft(04) + person4.Name + "".PadLeft(09) + person4.Age + "".PadLeft(11) + person4.DateOfBirth());
            Console.WriteLine("".PadLeft(04) + person5.Name + "".PadLeft(10) + person5.Age + "".PadLeft(11) + person5.DateOfBirth());
            Console.WriteLine("".PadLeft(04) + person6.Name + "".PadLeft(09) + person6.Age + "".PadLeft(11) + person6.DateOfBirth());
            Console.WriteLine("".PadLeft(04) + person7.Name + "".PadLeft(08) + person7.Age + "".PadLeft(11) + person7.DateOfBirth());
            Console.WriteLine("----------------------------------------");


            //old code line
            /*Console.WriteLine("Name: " + person1.Name + " Age: ".PadLeft(12) + person1.Age + " Date Of Birth: ".PadLeft(20) + person1.DateOfBirth());
            Console.WriteLine("Name: " + person2.Name + " Age: ".PadLeft(11) + person2.Age + " Date Of Birth: ".PadLeft(20) + person2.DateOfBirth());
            Console.WriteLine("Name: " + person3.Name + " Age: ".PadLeft(11) + person3.Age + " Date Of Birth: ".PadLeft(20) + person3.DateOfBirth());
            Console.WriteLine("Name: " + person4.Name + " Age: ".PadLeft(11) + person4.Age + " Date Of Birth: ".PadLeft(20) + person4.DateOfBirth());
            Console.WriteLine("Name: " + person5.Name + " Age: ".PadLeft(12) + person5.Age + " Date Of Birth: ".PadLeft(20) + person5.DateOfBirth());
            Console.WriteLine("Name: " + person6.Name + " Age: ".PadLeft(11) + person6.Age + " Date Of Birth: ".PadLeft(20) + person6.DateOfBirth());
            Console.WriteLine("Name: " + person7.Name + " Age: ".PadLeft(10) + person7.Age + " Date Of Birth: ".PadLeft(20) + person7.DateOfBirth());*/
            Console.ReadKey();
        }         
    }
}




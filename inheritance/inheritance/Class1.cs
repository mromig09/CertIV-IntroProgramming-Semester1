using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public abstract class Animal
    {

        public string Name { get; set; }

        public float Fatness { get; set; }

        public int Age { get; set; }

        public Animal(string name)
        {
            this.Name = name;
        }

        public abstract void Move();
        public abstract void Talk();
    }



    public class Dog : Animal
    {
        public Dog(string breed, string ownerName) : base("Dog")
        {
            Breed = breed;
            OwnerName = ownerName;
        }
        public string Breed { get; set; }
        public string OwnerName { get; set; }

        public override void Move()
        {
            Console.WriteLine("Movement Sound: OMG runnningggggg");
        }
        public override void Talk()
        {
            Console.WriteLine("Sound: Woof Woof!!");
        }
    }



    public class Cat : Animal
    {
        public Cat(string breed, string ownerName) : base("Cat")
        {
            Breed = breed;
            OwnerName = ownerName;
        }
        
        public string Breed { get; set; }
        public string OwnerName { get; set; }
        public override void Move()
        {
            Console.WriteLine("Movement Sound: Swift cat like steps, because, cat. . .");
        }    
        public override void Talk()
        {
            Console.WriteLine("Sound: Meow");
        }
    }
    


    public class Bear : Animal
    {
        public Bear(string color, string type, string breed, string ownerName) : base("Bear")
        {
            Color = color;
            Type = type;
            Breed = breed;
            OwnerName = ownerName;
        }

        public string Color { get; set; }
        public string Type { get; set; }
        public string Breed { get; set; }
        public string OwnerName { get; set; }
        public override void Move()
        {
            Console.WriteLine("Movement Sound: Rustle in the grass. . .");
        }
        public override void Talk()
        {
            Console.WriteLine("Sound: ROARR!!");
        }
    }
}

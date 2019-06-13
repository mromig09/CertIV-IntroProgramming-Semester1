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
            Console.WriteLine("Dog Construct");
            Breed = breed;
            OwnerName = OwnerName;
        }
        public string Breed { get; set; }
        public string OwnerName { get; set; }
    
        public override void Move()
        {
            Console.WriteLine("runnningggggg");
        }

        public override void Talk()
        {
            Console.WriteLine("Woof Woof!!");
        }
    }
}

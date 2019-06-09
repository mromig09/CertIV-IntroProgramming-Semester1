using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeKeeping
{
    public class Bee
    {
        public string Name { get; set; }
        public float Size { get; set; }

        public Bee(float size, string name)
        {
            Size = size;
            Name = name;
        }
    }

    public class Beehive
    {
        public List<Bee> Bees { get; set; }
        public int MaxAmount { get; set; }
        public int Days { get; set; }

        public Beehive(List<Bee> bees, int maxAmount)
        {
            this.Bees = bees;
            this.MaxAmount = maxAmount;

        }

        public float CollectHoney(int days)
        {
            //var bees = new List<double> { 3.2, 2.7, 1.1, 2.0 };
            int count = 0;
            foreach (var bee in this.Bees)
            {
                count++;
                Console.WriteLine($"{bee.Name}: {bee.Size}");
            }

            return Days*Size*0.2;
        }
    }
    class Program
    {

        public static void Main(string[] args)
        {
            Bee bee1 = new Bee(3.2f, "John");
            Bee bee2 = new Bee(2.7f, "Paul");
            Bee bee3 = new Bee(1.1f, "George");
            Bee bee4 = new Bee(2.0f, "Ringo");
            Bee bee5 = new Bee(2.3f, "Kurt");
            Bee bee6 = new Bee(7.4f, "Dave");
            Bee bee7 = new Bee(1.5f, "Krist");

            Beehive hive = new Beehive(new List<Bee>(), 4);
            Beehive hive2 = new Beehive(new List<Bee>(), 3);

            Console.WriteLine("----------------------");
            Console.WriteLine("     Beehive 01");
            Console.WriteLine("----------------------");
            Console.WriteLine("Beatles");
            Console.WriteLine();
            hive.Bees.Add(bee1);
            hive.Bees.Add(bee2);
            hive.Bees.Add(bee3);
            hive.Bees.Add(bee4);
            hive.CollectHoney(1);
            Console.WriteLine("----------------------");
            Console.WriteLine("     Beehive 02");
            Console.WriteLine("----------------------");
            Console.WriteLine("Nirvana");
            Console.WriteLine();
            hive2.Bees.Add(bee5);
            hive2.Bees.Add(bee6);
            hive2.Bees.Add(bee7);
            hive2.CollectHoney(4);
            Console.WriteLine("----------------------");


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}


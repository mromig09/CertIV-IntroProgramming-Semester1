using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge01
{
    class Program
    {
        static void Main(string[] args)
        {
            //array "Currently "wrong" must fix
            int[] values = new int[6];
            for (int i = 0; i < 7; i++)

            /*
            values[0] = 1;
            values[1] = 2;
            values[2] = 3;
            values[3] = 4;
            values[4] = 5;
            values[5] = 6; */

            //statement loop
            for ( ; ; )
            {
                //Welcoming line >>need to input "roll" command<<
                Console.WriteLine("Let's Play a Game of Dice!");
                Console.WriteLine("Roll the dice");
                Console.ReadLine();

                //create a new dice object and roll
                Dice newRun = new Dice();
                newRun.Roll();

                //display the results and line space
                Console.WriteLine("You Rolled a {0}", newRun.Die1);
                Console.WriteLine();

                //play again
                Console.WriteLine("Would you like to roll again?");
                Console.ReadLine();

                //if yes we continue, if no cya, bye.
                string yes = Console.ReadLine();
                {
                    if (yes.Equals("yes"))
                    {
                        Console.WriteLine("Lets Play Again. . . ");
                        Console.WriteLine();
                    }
                    else if (yes.Equals("no"))
                    {
                        Console.WriteLine("Cya, Bye. . .");
                    }
                }

                Console.ReadKey();
            }
        }
    }
    
    class Dice
    {
        private int die1;

        public int Die1
        {
            get { return die1; }
            set { die1 = value; }
        }
        
        public void Roll()
        {
            //generate a number for the die face
            Random rand1 = new Random();
            Die1 = rand1.Next(1, 6);
        }
    }
}

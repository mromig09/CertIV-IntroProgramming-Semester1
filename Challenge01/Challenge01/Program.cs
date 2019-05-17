using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge01
{
    class Program
    {
        List<int> items = new List<int>(6);
        static void Main(string[] args)
        {
            Program p = new Program();
            int loopCounter = 0;

            // loop
            while (loopCounter < 1)
                {
                    //Welcoming line >>need to input "roll" command<<
                    bool fail = true;
                    int userInput;
                    Console.WriteLine("Let's Play a Game of Dice!");
                    Console.WriteLine("Push enter to Roll the dice");
                    userInput = Console.Read();

                    //create a new dice object and roll
                    Dice newRun = new Dice();
                    newRun.Roll();

                    //display the results and line space
                    Console.WriteLine("You Rolled a {0}", newRun.Die1);
                    Console.WriteLine();

                    //play again
                    while (fail == true)
                    {
                        Console.WriteLine("Would you like to roll again?");
                        Console.ReadLine();

                        //if yes we continue, if no terminate.
                        string yes = Console.ReadLine();
                        {
                            if (yes == "yes")
                            {
                                Console.WriteLine();
                                Console.WriteLine("Lets Play Again. . . ");
                                Console.WriteLine("Push Enter to Start. . .");
                                fail = false;
                                Console.WriteLine();
                                
                            }
                            else if (yes == "no")
                            {
                                p.items.ForEach(Console.WriteLine);
                                fail = false;
                                loopCounter = 1;
                            }
                            else
                            {
                                Console.WriteLine("That input is invalid, Please try again. .");
                                fail = true;
                                Console.ReadKey();
                            }
                        }
                    }
                }
        }

        class Dice
        {
            Program p = new Program();
            
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
                die1 = rand1.Next(1, 6);
                
                
            }
        }
    }
}

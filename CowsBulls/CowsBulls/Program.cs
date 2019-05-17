using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsBulls
{
    class Program
    {
        static bool game(string guess, int[] num)
        {
            int bullsCount = 0;
            int cowsCount = 0;

            char[] guessed = guess.ToCharArray();
            if (guess.Length != 4)
            {
                Console.WriteLine("Not a Valid Guess.");
                return false;
            }

            for (int i = 0; i < 4; i++)
            {
                int guess1 = (int)char.GetNumericValue(guessed[i]);
                if (guess1 < 1 || guess1 > 9)
                {
                    Console.WriteLine("Number must be greater than 0 and lower than 10");
                    return false;
                }

                if (guess1 == num[i])
                {
                    bullsCount++;
                }

                else
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (guess1 == num[j])
                            cowsCount++;
                    }
                }
            }

            if (cowsCount == 4)
            {
                Console.WriteLine("Congratulations! You have won!");
                return true;
            }
            else
            {
                Console.WriteLine("Your Score is {0} bulls and {1} cows", bullsCount, cowsCount);
                return false;
            }
        }
        static void shuffle<T>(ref T[] array)
        {
            System.Random random = new System.Random();
            for (int i = 0; i < array.Length; i++)
            {
                int j = random.Next(array.Length);
                T temp = array[i]; array[i] = array[j]; array[j] = temp;
            }
        }
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            shuffle<int>(ref nums);
            int[] chosenNum = new int[4];
            Array.Copy(nums, chosenNum, 4);

            Console.WriteLine("Welcome to Cows and Bulls!");
            Console.WriteLine("Whats your guess?");
            while (!game(Console.ReadLine(), chosenNum))
            {
                Console.WriteLine("Your next guess?");
            }

            Console.ReadKey();

            

            
        }
    }
}

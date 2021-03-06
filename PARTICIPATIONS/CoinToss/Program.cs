﻿using System;

//Prompt the user to pick heads or tails, and then generate a random number, using the Random (Links to an external site.) class, generate a random number that has a range of just two numbers (e.g. it should just be random between 0 and 1 or 1 and 2 so that you have two options, heads or tails).  
//Tell the user what side the coin landed on (heads or tails) and then whether or not their guess was right or wrong. 
//Display the developer name (store as a constant) before the user exits the application.

namespace CoinToss
{
    class Program
    {
        
        const string DEVELOPER = "Alessio Hall";
        const int HEADS = 1;
        const int TAILS = 0;

        static void Main(string[] args)

        {
            Random rnd = new Random();
            int coin = rnd.Next(0, 2);

            Console.WriteLine("Pick one: Heads or Tails (capitalize first letter please) >>");

            Console.WriteLine();

            string response = Console.ReadLine();
                 
            Console.WriteLine();
            

            if (coin == HEADS)
            {
                Console.WriteLine("It landed on Heads");

                if (response == "Heads")
                {
                    Console.WriteLine("You got it! Congrats!");
                }
                else
                {
                    Console.WriteLine("WRONG! TRY AGAIN");
                }
            }

            else if (coin == TAILS)
            {
                Console.WriteLine("It landed on Tails");
                if (response == "Tails")
                {
                    Console.WriteLine("You got it! Congrats!");
                }
                else
                {
                    Console.WriteLine("WRONG! TRY AGAIN");
                }
            }
            else
            {
                return;
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine(DEVELOPER);
            Console.ReadKey();

                }

            }
        
        }
    


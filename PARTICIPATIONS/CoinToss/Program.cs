﻿using System;

//Prompt the user to pick heads or tails, and then generate a random number, using the Random (Links to an external site.) class, generate a random number that has a range of just two numbers (e.g. it should just be random between 0 and 1 or 1 and 2 so that you have two options, heads or tails).  
//Tell the user what side the coin landed on (heads or tails) and then whether or not their guess was right or wrong. 
//Display the developer name (store as a constant) before the user exits the application.

namespace CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            Random coin = new Random();

            int coin = coin.next(0, 1);

            Console.WriteLine(coin);


        }
    }
}

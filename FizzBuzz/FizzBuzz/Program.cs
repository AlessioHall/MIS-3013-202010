using System;

//Generate a random number with a range between 1 and 100, using the Random (Links to an external site.) class.  Once you have the random number generated, we will play the FizzBuzz Game.
//If the number they provided to you is divisible by 3, then you should output the word 'Fizz'.
//If the number is divisible by 5, then you should output the word 'Buzz'.
//If the number is divisible by 3 AND 5, then you should output the word 'Fizz Buzz'
//If the number is NOT divisible by either, just output the number back out. 



namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            int randnumber = random.Next(1, 100);
            Console.WriteLine("Random Number Generator = " + randnumber);






        }
    }
}

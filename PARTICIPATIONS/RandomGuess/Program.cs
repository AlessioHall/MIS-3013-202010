using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// Create a new console application (using the .NET Framework and not .NET Core).  Name your project and solution RandomGuess.
// Generate a radnom number that the user will define the minimum value and the maximum value, using the Random class
// Prompt the user to guess the random number until they successfully get it
namespace RandomGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your minimum value?");
            int MinValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your maximum value?");
            int MaxValue = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();

            int randnumber = random.Next(MinValue, (MaxValue+1));

            //Console.WriteLine(randnumber);

            // NOT EQUAL TO: (!=)

            Console.WriteLine("I've generated a random number between the two values you just gave me");
            Console.WriteLine("Now, it's your turn to see if you can guess that number correctly!");
            Console.WriteLine();

            
            int ActualReponse;

            do
            {
                Console.WriteLine("Take your guess!");
                Console.WriteLine();
                string response = Console.ReadLine();

                int number;
                bool success = Int32.TryParse(response, out number);

                if (success)
                {
                    ActualReponse = Convert.ToInt32(response);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Input");
                }




                
                                
                if (number == randnumber)
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations! You guessed correctly!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Let's try that one more time - ");
                }

                ActualReponse = number;

            } while (ActualReponse != randnumber) ;


            Console.ReadKey();

        }
    }
}

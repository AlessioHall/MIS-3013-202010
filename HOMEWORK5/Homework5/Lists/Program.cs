using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> favthings = new List<string>();

            string answer;
            do
            {
                Console.WriteLine("Enter one of your favorite things");
                favthings.Add(Console.ReadLine());
                Console.WriteLine("Do you want to add another favorite thing?");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "yes");

            Console.WriteLine();
            Console.WriteLine("Here is your list in the order that you typed it -- ");
            for (int i = 0; i < favthings.Count; i++)
            {
                if (i != favthings.Count -1)
                {
                Console.WriteLine($"{favthings[i]}, ");
                }
                else
                {
                    Console.WriteLine($"{favthings[i]}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your list but backwards -- ");
            for (int i = favthings.Count - 1; i >= 0; i--)
            {
                if (i != 0)
                {
                    Console.WriteLine($"{favthings[i]}, ");
                }
                else
                {
                    Console.WriteLine($"{favthings[i]}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Finally, here is every other thing you typed");
            for (int i = 0; i < favthings.Count; i += 2)
            {
                if (i != favthings.Count - 2)
                {
                    Console.WriteLine($"{favthings[i]}, ");
                }
                else
                {
                    Console.WriteLine($"{favthings[i]}");
                }
            }








            Console.ReadKey();

        }
    }
}

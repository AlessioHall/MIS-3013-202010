using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter any animal from the following list to see what sound they make!");
            Console.WriteLine("\t << Dog, Monkey, Goat, Cow, Cat, Horse, Fish, Frog >>");
            Console.WriteLine();
            string response = Console.ReadLine();
            string animal = response.ToLower();

            Console.WriteLine();
            Console.WriteLine();
            Speak(animal);

            Console.ReadKey();

        }

        static string Speak(string animal)
        {
            if (animal == "dog")
            {
                Console.WriteLine("Woof");
            }
            else if (animal == "monkey")
            {
                Console.WriteLine("Ooh ooh ah ah");
            }
            else if (animal == "goat")
            {
                Console.WriteLine("Human scream");
            }
            else if (animal == "cow")
            {
                Console.WriteLine("Moooo");
            }
            else if (animal == "cat")
            {
                Console.WriteLine("Meow");
            }
            else if (animal == "horse")
            {
                Console.WriteLine("Neigh");
            }
            else if (animal == "fish")
            {
                Console.WriteLine("glub glub");
                Console.WriteLine();
                Console.WriteLine("that one's my favorite");
            }
            else if (animal == "frog")
            {
                Console.WriteLine("ribbit");
            }
            else
            {
                Console.WriteLine("INVALID ANIMAL");
            }

            return (animal);
        }

        

    }
}

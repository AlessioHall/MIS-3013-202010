using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/* Create a class variable, of type string, that will hold the value:
 * 
 * "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, 
 * and the universe trying to build bigger and better idiots. So far, the universe is winning."
 * 
 * Start your application off by showing the user the above sentence. Then ask the user for input on what word they want to look for in the above sentence,
 * and what word they want to change it to (easier if this is two separate inputs). 
 * If the word they want to look for is not present in the sentence, output 
 *  "Sorry, I could not find your word {INSERT THEIR WORD HERE}." 
 * and then output their word they wanted you to look for in reverse order, using a loop
 * If the word does exist in the sentence, replace all occurrences of it with the word they wanted to replace it with and output the new sentence with the words replaced. */
 

namespace StringManipulation
{
    class Program
    {
        const string Sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
        static void Main(string[] args)
        {
            
            Console.WriteLine(Sentence);
            Console.WriteLine();

            Console.WriteLine("What word do you want to search for?");
            string Input1 = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("What do you want to replace that word with?");
            string Input2 = Console.ReadLine();

            Console.WriteLine();

            bool Search = Sentence.Contains(Input1);

            string correctstring;

            if (Search == true)
            {
                correctstring = Sentence.Replace(Input1, Input2);
                Console.WriteLine(correctstring);
            }
            else
            {
                Console.WriteLine("Sorry - I could not find your word -> " + Input1);
                Console.WriteLine();

                for (int i = Input1.Length -1; i >= 0; --i)
                {
                    char reverse = Input1[i];
                    Console.Write(reverse);
                }


            }








            Console.ReadKey();
        }
    }
}

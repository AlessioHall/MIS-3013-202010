using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesorno;

            do
            {
                Console.WriteLine("enter a toy");
                string answer = Console.ReadLine();

                List<string> ToyList = new List<string>();

                var toys = new ToyBox();

                ToyList.Add(answer);

                toys.Toys.Add(answer);

                Console.WriteLine("what is the manufacturer name");
                string m = Console.ReadLine();
                Toy mytoy = new Toy(m);
                string aisle = mytoy.GetAisle();

                Console.WriteLine("do u want to add another toy?");
                string response = Console.ReadLine();
                yesorno = response.ToLower();

            } while (yesorno == "yes");             






            Console.ReadKey();

        }
    }
}

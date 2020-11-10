using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {

            string AcctBalances = @"C:\Users\aless\Downloads\AccountBalances.csv";
            string[] balance = File.ReadAllLines(AcctBalances);

            string CustomerNames = @"C:\Users\aless\Downloads\CustomerNames.csv";
            string[] customers = File.ReadAllLines(CustomerNames);

            foreach (var name in customers)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Type out a customer's name to see their current balance --");
            Console.WriteLine("*Make sure to use correct capitalizations!*");
            Console.WriteLine();

            string customername = Console.ReadLine();
            

            for (int i = 0; i < customers.Length; i++)
            {
                string name = customers[i];
                if (name == customername)
                {
                    string accountbalance = balance[i];
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"{customername} has a current balance of {accountbalance}");
                }
            }



            Console.ReadKey();
         }
    }
}

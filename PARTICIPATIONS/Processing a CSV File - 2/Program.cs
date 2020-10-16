
// Create an application that will read in the following CSV file (SalesJan2009.csv).  Add the file to your project so that it will copy it to your output directory.
// When the application loads, output all of the Names of the individual, as well as the Transaction_Date, who made the purchase. 
// Only show the information about the individual (their name and the transation date) if they used a Visa AND the sale took place in the United States.


using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing_a_CSV_File___2
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = @"SalesJan2009.csv";

            string[] lines = File.ReadAllLines(filePath);

            /* 
             * Transaction_date = 0 (or 1)
             * Name = 4 (or 5)
             * Payment_Type = 3 (or 4)
             * Country = 7 (or 8)
             */

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                string transactiondate = pieces[0];
                string name = pieces[4];
                string paymenttype = pieces[3];
                string country = pieces[7];

                if (paymenttype == "Visa" && country == "United States")
                {
                    Console.WriteLine($"{name} // {paymenttype} // {country} // {transactiondate}");
                }

            }












            Console.ReadKey();

        }
    }
}

using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = 0;
            double distance = 0;
            string response = "";
            bool containsHazardous = false;

            Console.WriteLine("What is the weight of your shipment, in pounds? >>");
            weight = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("What is the distance of your shipment, in miles? >>");
            distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Does your shipment contain any hazardous materials, Y or N?");
            response = Console.ReadLine();

            if (response == "Y")
            {
                containsHazardous = true;
            }
            else if (response == "N")
            {
                containsHazardous = false;
            }
            else
            {
                Console.WriteLine("INVALID INPUT - TRY AGAIN");
                return;
            }

            double quote = 0.55 * distance + 0.73 * weight;
            double HazardousCost = 0;
       
            if (containsHazardous == true)
            {
                HazardousCost = 0.15 * weight;
            }
            else
            {
                HazardousCost = 0;
            }

            double netTotal = quote + HazardousCost;
            double discount = 0;

            if (distance < 150 && weight > 500)
            {
                discount = netTotal * 0.1;
            }

            double total = netTotal - discount;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Quote: \t\t" + quote.ToString("C"));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hazardous Cost: " + HazardousCost.ToString("C"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Net Total: \t" + netTotal.ToString("C"));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Discount: \t" + discount.ToString("C"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Total: \t\t{total.ToString("C")}");





        }
    }
}

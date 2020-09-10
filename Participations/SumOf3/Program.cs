using System;

namespace Participation1_SumOf3Numbers

   {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In numbers only, how old are you?");
            double Years = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Once again, in numbers only, what is your shoe size (decimals allowed on this one)?");
            double Shoe = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lastly, what is your most favorite number?");
            double FavNumber = Convert.ToDouble(Console.ReadLine());

            double sum = Years + Shoe + FavNumber;
            
            Console.WriteLine("The sum of the three numbers you just provided me is " + sum.ToString("F3") + "!");

            const double seven = 7.777;
            double MagicNumber = sum * seven;

            Console.WriteLine();
            Console.WriteLine("With a bit of magic, your new lucky number is " + MagicNumber.ToString("F3") + "!");
            


        }
    }
}



// Ask the user to enter all of their exam grades. Once they are done, calculate the minimum score, the maximum score and the average score for all of their scores.  
// Perform this using at least 2 Loops (can be the same type of loop) and not any built in functions.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Collections_MinMaxAvg
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> ExamScores = new List<int>();
            string answer;
            int ExamScore;
            do
            {
                Console.WriteLine("Please enter one of your exam scores >>");
                ExamScore = Convert.ToInt32(Console.ReadLine());

                ExamScores.Add(ExamScore);

                Console.WriteLine("Do you have another another exam score to report? >>");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");

            int Length = ExamScores.Count;
            int minimum;

            for (int i = 100; i < Length; i--)
            {
                minimum = 100;
                if (i < minimum)
                {
                    minimum = i;
                }
                Console.WriteLine(minimum);
            }


            Console.WriteLine();


            int TotalNumberOfScores = ExamScores.Count;
            int Sum = ExamScores.Sum();
            int AverageScore = Sum / TotalNumberOfScores;


            Console.WriteLine(AverageScore); 









            Console.ReadKey();
        }
    }
}

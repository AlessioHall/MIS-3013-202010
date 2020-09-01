﻿/*
*
*@Author: Alessio Hall
* Collaborated with: (Whoever I work with)
* 
*/
using System;

namespace InputOutput
{
    class Program
    {
        const string CLASS_NAME = "MIS 3013";
        static void Main(string[] args)
        {
            //This won't work because it is a constant - CLASS_NAME = "MIS 3353";
            //string firstName, lastName; 
            string firstName = "Alessio";
            string lastName = "Hall";

            Console.WriteLine("Please enter your first name >>");
            firstName = Console.ReadLine(); //Getting what the user typed and storing it

            Console.WriteLine("Please enter your last name >>");
            lastName = Console.ReadLine();

            Console.WriteLine("What is your GPA? >>");
            string gpaInput = Console.ReadLine();
            double gpa = Convert.ToDouble(gpaInput);

            //This doesn't make sense, BUT it shows we can use it in calculations 
            double gpaEnhanced = gpa + 1.5;

            Console.WriteLine(firstName + " " + lastName + " is in " + CLASS_NAME + " with a GPA of " + gpa.ToString("N2"));
        }
    }
}

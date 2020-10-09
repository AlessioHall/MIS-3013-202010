using System;
using System.IO;

namespace Processing_a_CSV_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\aless\Downloads\sales_data_sample.csv";
            //string filePath = @"sales_data_sample.csv";

            string[] lines = File.ReadAllLines(filePath);

            //ORDERNUMBER,QUANTITYORDERED,PRICEEACH,ORDERLINENUMBER,SALES,ORDERDATE,STATUS,QTR_ID,MONTH_ID,YEAR_ID,PRODUCTLINE,MSRP,PRODUCTCODE,CUSTOMERNAME,PHONE,ADDRESSLINE1,ADDRESSLINE2,CITY,STATE,POSTALCODE,COUNTRY,TERRITORY,CONTACTLASTNAME,CONTACTFIRSTNAME,DEALSIZE
            /*
             * Sales = 4
             * Status = 6
             * Month = 8
             * Year = 9  
             */
            double sum = 0;
            double sumFor2003 = 0;
            double sumFor2003JAN = 0;
            double sumFor2003FEB = 0;
            double sumFor2003MAR = 0;
            double sumFor2003APR = 0;
            double sumFor2003MAY = 0;
            double sumFor2003JUN = 0;
            double sumFor2003JUL = 0;
            double sumFor2003AUG = 0;
            double sumFor2003SEP = 0;
            double sumFor2003OCT = 0;
            double sumFor2003NOV = 0;
            double sumFor2003DEC = 0;
            double sumFor2004 = 0;
            double sumFor2004JAN = 0;
            double sumFor2004FEB = 0;
            double sumFor2004MAR = 0;
            double sumFor2004APR = 0;
            double sumFor2004MAY = 0;
            double sumFor2004JUN = 0;
            double sumFor2004JUL = 0;
            double sumFor2004AUG = 0;
            double sumFor2004SEP = 0;
            double sumFor2004OCT = 0;
            double sumFor2004NOV = 0;
            double sumFor2004DEC = 0;
            double sumFor2005 = 0;
            double sumFor2005JAN = 0;
            double sumFor2005FEB = 0;
            double sumFor2005MAR = 0;
            double sumFor2005APR = 0;
            double sumFor2005MAY = 0;
            double sumFor2005JUN = 0;
            double sumFor2005JUL = 0;
            double sumFor2005AUG = 0;
            double sumFor2005SEP = 0;
            double sumFor2005OCT = 0;
            double sumFor2005NOV = 0;
            double sumFor2005DEC = 0;

            string month1 = "January";
            string month2 = "February";
            string month3 = "March";
            string month4 = "April";
            string month5 = "May";
            string month6 = "June";
            string month7 = "July";
            string month8 = "August";
            string month9 = "September";
            string month10 = "October";
            string month11 = "November";
            string month12 = "December";


            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                double sale = Convert.ToDouble(pieces[4]);
                string year = pieces[9];
                string month = pieces[8];

                if (pieces[6].Trim().ToLower() == "shipped")
                {
                    if (year == "2003")
                    {
                        sumFor2003 += sale;

                        if (month == "1")
                        {
                            sumFor2003JAN += sale;
                        }
                        else if (month == "2")
                        {
                            sumFor2003FEB += sale;
                        }
                        else if (month == "3")
                        {
                            sumFor2003MAR += sale;
                        }
                        else if (month == "4")
                        {
                            sumFor2003APR += sale;
                        }
                        else if (month == "5")
                        {
                            sumFor2003MAY += sale;
                        }
                        else if (month == "6")
                        {
                            sumFor2003JUN += sale;
                        }
                        else if (month == "7")
                        {
                            sumFor2003JUL += sale;
                        }
                        else if (month == "8")
                        {
                            sumFor2003AUG += sale;
                        }
                        else if (month == "9")
                        {
                            sumFor2003SEP += sale;
                        }
                        else if (month == "10")
                        {
                            sumFor2003OCT += sale;
                        }
                        else if (month == "11")
                        {
                            sumFor2003NOV += sale;
                        }
                        else
                        {
                            sumFor2003DEC += sale;
                        }
                    }
                    else if (year == "2004")
                    {
                        sumFor2004 += sale;
                        if (month == "1")
                        {
                            sumFor2004JAN += sale;
                        }
                        else if (month == "2")
                        {
                            sumFor2004FEB += sale;
                        }
                        else if (month == "3")
                        {
                            sumFor2004MAR += sale;
                        }
                        else if (month == "4")
                        {
                            sumFor2004APR += sale;
                        }
                        else if (month == "5")
                        {
                            sumFor2004MAY += sale;
                        }
                        else if (month == "6")
                        {
                            sumFor2004JUN += sale;
                        }
                        else if (month == "7")
                        {
                            sumFor2004JUL += sale;
                        }
                        else if (month == "8")
                        {
                            sumFor2004AUG += sale;
                        }
                        else if (month == "9")
                        {
                            sumFor2004SEP += sale;
                        }
                        else if (month == "10")
                        {
                            sumFor2004OCT += sale;
                        }
                        else if (month == "11")
                        {
                            sumFor2004NOV += sale;
                        }
                        else
                        {
                            sumFor2004DEC += sale;
                        }
                    }
                    else
                    {
                        sumFor2005 += sale;
                        if (month == "1")
                        {
                            sumFor2005JAN += sale;
                        }
                        else if (month == "2")
                        {
                            sumFor2005FEB += sale;
                        }
                        else if (month == "3")
                        {
                            sumFor2005MAR += sale;
                        }
                        else if (month == "4")
                        {
                            sumFor2005APR += sale;
                        }
                        else if (month == "5")
                        {
                            sumFor2005MAY += sale;
                        }
                        else if (month == "6")
                        {
                            sumFor2005JUN += sale;
                        }
                        else if (month == "7")
                        {
                            sumFor2005JUL += sale;
                        }
                        else if (month == "8")
                        {
                            sumFor2005AUG += sale;
                        }
                        else if (month == "9")
                        {
                            sumFor2005SEP += sale;
                        }
                        else if (month == "10")
                        {
                            sumFor2005OCT += sale;
                        }
                        else if (month == "11")
                        {
                            sumFor2005NOV += sale;
                        }
                        else
                        {
                            sumFor2005DEC += sale;
                        }
                    }

                    sum += sale;
                }

            }

            Console.WriteLine($"The total sales for shipped items in 2003 is {sumFor2003.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in 2004 is {sumFor2004.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in 2005 is {sumFor2005.ToString("C")}!");
            Console.WriteLine();

            Console.WriteLine($"The total sales of shipped items for {month1} of \t 2003/2004/2005 is {sumFor2003JAN.ToString("C")}/{sumFor2004JAN.ToString("C")}/{sumFor2005JAN.ToString("C")}!");
            Console.WriteLine($"The total sales of shipped items for {month2} of \t 2003/2004/2005 is {sumFor2003FEB.ToString("C")}/{sumFor2004FEB.ToString("C")}/{sumFor2005FEB.ToString("C")}!");
            Console.WriteLine($"The total sales of shipped items for {month3} of \t\t 2003/2004/2005 is {sumFor2003MAR.ToString("C")}/{sumFor2004MAR.ToString("C")}/{sumFor2005MAR.ToString("C")}!");
            Console.WriteLine($"The total sales of shipped items for {month4} of \t\t 2003/2004/2005 is {sumFor2003APR.ToString("C")}/{sumFor2004APR.ToString("C")}/{sumFor2005APR.ToString("C")}!");
            Console.WriteLine($"The total sales of shipped items for {month5} of \t\t 2003/2004/2005 is {sumFor2003MAY.ToString("C")}/{sumFor2004MAY.ToString("C")}/{sumFor2005MAY.ToString("C")}!");
            Console.WriteLine($"The total sales of shipped items for {month6} of \t\t 2003/2004/2005 is {sumFor2003JUN.ToString("C")}/{sumFor2004JUN.ToString("C")}/{sumFor2005JUN.ToString("C")}!");
            Console.WriteLine($"The total sales of shipped items for {month7} of \t\t 2003/2004/2005 is {sumFor2003JUL.ToString("C")}/{sumFor2004JUL.ToString("C")}/{sumFor2005JUL.ToString("C")}!");
            Console.WriteLine($"The total sales of shipped items for {month8} of \t\t 2003/2004/2005 is {sumFor2003AUG.ToString("C")}/{sumFor2004AUG.ToString("C")}/{sumFor2005AUG.ToString("C")}!");
            Console.WriteLine($"The total sales of shipped items for {month9} of \t 2003/2004/2005 is {sumFor2003SEP.ToString("C")}/{sumFor2004SEP.ToString("C")}/{sumFor2005SEP.ToString("C")}!");
            Console.WriteLine($"The total sales of shipped items for {month10} of \t 2003/2004/2005 is {sumFor2003OCT.ToString("C")}/{sumFor2004OCT.ToString("C")}/{sumFor2005OCT.ToString("C")}!");
            Console.WriteLine($"The total sales of shipped items for {month11} of \t 2003/2004/2005 is {sumFor2003NOV.ToString("C")}/{sumFor2004NOV.ToString("C")}/{sumFor2005NOV.ToString("C")}!");
            Console.WriteLine($"The total sales of shipped items for {month12} of \t 2003/2004/2005 is {sumFor2003DEC.ToString("C")}/{sumFor2004DEC.ToString("C")}/{sumFor2005DEC.ToString("C")}!");

            Console.WriteLine($"Total sales of shipped orders is {sum.ToString("C2")}.");

            Console.ReadKey();

        }
    }
}

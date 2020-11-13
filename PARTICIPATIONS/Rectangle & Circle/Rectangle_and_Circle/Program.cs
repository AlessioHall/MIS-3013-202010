using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_and_Circle
{
    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double CalculateArea()
        {
            return Width * Length;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }
    class Circle
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 0;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Circle myCircle = new Circle();
            myCircle.Radius = 7.5;
            Console.WriteLine($"A circle with radius {myCircle.Radius} has an area of {myCircle.CalculateArea()}\n" + $" and a perimeter of {myCircle.CalculatePerimeter()}");

            Circle circle2 = new Circle();
            circle2.Radius = 101010;
            double areaofcircle2 = circle2.CalculateArea();
            double perimeterofcircle2 = circle2.CalculatePerimeter();

            Circle circle3 = new Circle(3.5);

            Rectangle myRectangle = new Rectangle();
            myRectangle.Length = 18;
            myRectangle.Width = 4;
            Console.WriteLine($"A rectangle with length {myRectangle.Length} and width {myRectangle.Width} has an area of {myRectangle.CalculateArea()} and a perimeter of {myRectangle.CalculatePerimeter()}");

            Rectangle rectangle2 = new Rectangle();
            rectangle2.Length = 41;
            rectangle2.Width = 30;
            double areaofrectangle2 = rectangle2.CalculateArea();
            double perimeterofrectangle2 = rectangle2.CalculatePerimeter();

            Rectangle rectangle3 = new Rectangle(9, 14);


            Console.ReadKey();
        }
    }
}

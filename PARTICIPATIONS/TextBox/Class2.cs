using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBox
{
    class Class2
    {
        static void Main(string[] args)
        {
            TextBox firsttextbox = new TextBox()
            {
                Text = "This is the first textbox - it has a green forecolor, a red backcolor, and a padding of 2",
                BackColor = ConsoleColor.Red,
                ForeColor = ConsoleColor.Green,
                Padding = 2,
            };

            TextBox secondtextbox = new TextBox()
            {
                Text = "This is the second textbox - it has a yellow forecolor, a dark magenta backcolor, and a padding of 50",
                BackColor = ConsoleColor.DarkMagenta,
                ForeColor = ConsoleColor.Yellow,
                Padding = 50,
            };

            firsttextbox.DisplayText();

            secondtextbox.DisplayText();




            Console.ReadKey();
        }
    }
}

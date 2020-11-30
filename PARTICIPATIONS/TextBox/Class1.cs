using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBox
{
    public class TextBox
    {
        public int Padding { get; set; }

        public ConsoleColor BackColor { get; set; }

        public ConsoleColor ForeColor { get; set; }

        public string Text { get; set; }

        public TextBox()
        {

        }

        public void DisplayText()
        {
            Console.BackgroundColor = this.BackColor;
            Console.ForegroundColor = this.ForeColor;
            string stringpadding = new string(' ', this.Padding);
            Console.WriteLine(stringpadding + this.Text + stringpadding);

        }
    }
}

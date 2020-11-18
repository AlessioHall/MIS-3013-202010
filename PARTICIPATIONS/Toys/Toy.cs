using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Toy
    {
        public string Manufacturer;
        public string Name;
        public double Price;
        public string Notes;

        public Toy(string m)
        {
            this.Manufacturer = m;
        }

        public string GetAisle()
        {
            Random rand = new Random();
            int num = rand.Next(1, 25);
            char aisle1 = Manufacturer[0];
            string Aisle = Convert.ToString(aisle1);
            string final = $"{Aisle}{num}";
            return final;
        }
    }
}

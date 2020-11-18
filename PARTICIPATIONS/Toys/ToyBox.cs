using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class ToyBox
    {
        public List<string> Toys { get; set; }

        public ToyBox()
        {
            Toys = new List<string>();

        }

        public int GetRandomToy()
        {
            Random rand = new Random();
            int ToyNumber = rand.Next(Toys.Count);
            return ToyNumber;
        }
    }
}

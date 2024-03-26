using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Courier
    {
        public string Name { get; set; }
        public int Distance { get; set; }
        public Courier(string name, int distance)
        {
            Name = name;
            Distance = distance;
        }
    }
}

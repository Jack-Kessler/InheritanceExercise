using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public Reptile() { }

        public int LengthOfTail { get; set; }
        public int LengthOfBody { get; set;}
        public bool ShedSkin { get; set; }
        public bool CanRegrowTail { get; set; }
    }
}

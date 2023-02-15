using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public Bird() { }

        public int LengthOfBeak { get; set; }
        public bool CanFly { get; set; }
        public int NumberOfFeathers { get; set;}
        public string Habitat { get; set; }
    }
}

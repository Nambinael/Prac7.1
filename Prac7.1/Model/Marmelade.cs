using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac7._1.Model
{
    internal class Marmelade
    { 
        public string Name { get; set; }
        public string Flavour { get; set; }
        public float Ammount { get; set; } 

        public Marmelade(string name, string flavour, float ammount)
        {
            Name = name;
            Flavour = flavour;
            Ammount = ammount;
        }

        public Marmelade() { }


    }
}   

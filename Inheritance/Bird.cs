using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird: Animal
    {
        public Bird() 
        {
            type = "bird";
            habitate = "rainforest";
            iswild= true;
            islandanimal= true;
        }
        public bool canfly  { get; set; }
        public string nameKind { get; set;}
        public string color { get; set;}
        public double beaksize { get; set;}
        public void printbirddetails() 
        {
            Console.WriteLine($"{type},{habitate},{iswild}, {islandanimal}, {canfly}, {nameKind},{color},{beaksize}");
        }
    }

}

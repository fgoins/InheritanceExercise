using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile:Animal
    {
        public Reptile() 
        {
            type = "reptile";
            habitate = "rainforest";
            iswild = true;
            islandanimal = true;
        }
        public string kind { get; set; }
        public string namekind { get; set; }
        public bool iscoldblooded { get; set; }
        public bool doeshaveteeth { get; set; }

        public void lizard() 
        {
            Console.WriteLine($"in the {habitate} ecosystem there are animals classified as {type}.");
            Console.WriteLine($"they are wild {iswild} and its {islandanimal} they can be land animals.");
            Console.WriteLine($"the animal is cold blood {iscoldblooded}");
            Console.WriteLine($"its also {doeshaveteeth} the {type} has teeth.");
            Console.WriteLine($"you guessed it the animal is {kind} {namekind}.") ;
        }
    }
}

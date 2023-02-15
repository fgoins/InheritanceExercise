using System;
using System.Reflection.Metadata;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            //  Create an object of your Bird class
            //   *  give values to your members using the object of your Bird class
            Bird breed = new Bird()
            {
                nameKind = "spix Macaw",
                canfly = true,
                color = "blue",
                beaksize = 3.4
            };


            //     * Creatively display the class member values
            breed.printbirddetails();
            Console.WriteLine("---------------------------------");
            //Create an object of your Reptile class
            // *  give values to your members using the object of your Reptile class
            Reptile reptile= new Reptile() 
            {
             kind = "lizard",
             namekind = "aligator",
             iscoldblooded = true,
             doeshaveteeth = true
            };

            reptile.lizard();
            // * Creatively display the class member values

}
    }
}

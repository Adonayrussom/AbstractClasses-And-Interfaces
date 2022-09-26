using System;

namespace sess08_AbstractClasses_and_Interfaces
{
    /// <summary>
    /// Program demonstrating explicit interface implementation.It will be used to create
    /// Crocodile instances
    /// </summary>
    public class Crocodile : IMarineAnimal, ITerrestial
    {
        string ITerrestial.Eat()
        {
            return "Crocodile eats fish and other marine animals";
        }

        string IMarineAnimal.Eat()
        {
            return "Crocodile eats land animals like gnu and zebras";
        }

        public string EatTerrestial()
        {
            ITerrestial terrestialAnimal = this;
            return terrestialAnimal.Eat();
        }

        public string EatMarine()
        {
            IMarineAnimal marineAnimal = this;
            return marineAnimal.Eat();
        }
        static void Main(string[] args)
        {
            //Declare and instantiate a Crocodile instance
            Crocodile crocodile = new Crocodile();

            //Display the diet from the ITerrestial and IMarine interface implementation respectivelly
            Console.WriteLine($"From ITerrestial: {crocodile.EatTerrestial()}");
            Console.WriteLine($"From IMarine: {crocodile.EatMarine()}");
        }
    }
}

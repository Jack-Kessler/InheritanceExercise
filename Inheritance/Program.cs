using System;

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

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird myBird = new Bird();

            myBird.Name= "Tweety-Bird";
            myBird.Age = 30;
            myBird.Size = "small";
            myBird.Habitat = "Looney Tunes World of Mayhem";
            myBird.CanFly = true;

            Console.WriteLine($"{myBird.Name} is the cutest bird. She is {myBird.Age} years old and very {myBird.Size}.\n" +
                              $"She lives in {myBird.Habitat} and it is {myBird.CanFly} that she can fly, but not very fast.");
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile myReptile = new Reptile();

            myReptile.Name = "Harry";
            myReptile.Age = 70;
            myReptile.Size = "medium";
            myReptile.CanRegrowTail = false;
            myReptile.ShedSkin = false;

            Console.WriteLine($"{myReptile.Name} is a turtle. He is {myReptile.Age}, so he is very old. He is of {myReptile.Size} size. \n" +
                              $"Two facts about Harry:\n He can regrow his tail: {myReptile.CanRegrowTail} \n He can shed his skin: {myReptile.ShedSkin}\n" +
                              $"Of course he can't though because he's a turtle!");
        }
    }
}

using System;
using System.Collections.Generic;

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
            var cardinal = new Bird()
            {
                Feathers = true,
                Beak = true,
                Eggs = true,
                Name = "Cardinal"
            };

            if (cardinal.Equals(cardinal))
            {
                Console.WriteLine($"{cardinal.Name} is a bird");
            }
            else
            {
                Console.WriteLine($"{cardinal.Name} is not a bird");
            }
            Console.WriteLine();
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var snake = new Reptile()

            {
               WarmBlooded = false,
               Vertebrates = true,
               ColdBlooded = true,
               Name = "Snake"
            };

            if (snake.Equals(snake))
            {
                Console.WriteLine($"{snake.Name} is a reptile.");
            }
            else
            {
                Console.WriteLine($"{snake.Name} is not a bird");
            }


            Console.WriteLine();
            Console.WriteLine();
            cardinal.PrintDetails();
            Console.WriteLine();

            snake.PrintDetails();
        }
    }
}

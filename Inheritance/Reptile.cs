using System;
namespace Inheritance
{
	public class Reptile: Animal
	{
		public Reptile()
		{
			Movement = true;
			Respiration = true;
			Growth = true;
			Nutrition = "different types";
		}

		public bool WarmBlooded { get; set; }
		public bool Vertebrates { get; set; }
		public bool ColdBlooded { get; set; }
		public string Name { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Warm blooded: {WarmBlooded}");
            Console.WriteLine($"Cold blooded: {ColdBlooded}");
            Console.WriteLine($"Has skeletal system: {Vertebrates}");
        }

    }
}


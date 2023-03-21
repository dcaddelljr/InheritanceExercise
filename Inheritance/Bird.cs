using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
			//constructor
			Movement = true;
			Respiration = true;
			Growth = true;
			Nutrition = "Varies";
			Scales = false;
        }

		//Specific characteristics of birds
		public bool Feathers { get; set; }
		public bool Beak { get; set; }
		public bool Eggs { get; set; }
		public string Name { get; set; }

        public void PrintDetails()
		{
			Console.WriteLine($"{GetType().Name}");
			Console.WriteLine($"Name: {Name}");
			Console.WriteLine($"Lays eggs: {Eggs}");
			Console.WriteLine($"Has a beak: {Beak}");
			Console.WriteLine($"Has Scales: {Scales}");
		}
    }
}
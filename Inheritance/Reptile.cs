using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
        public Reptile()
        {
            EatsFood = true;
            LivesOnEarth = true;
            HasBrain = true;
            Reproduces = true;
        }
        public bool ColdBlooded { get; set; }
        public bool LaysEggs  { get; set; }
        public bool HasLungs { get; set; }
        public bool Sheds  { get; set; }

        public void Reptiles()
        {
            Console.WriteLine($"Reptiles are cold blooded animals that lay eggs instead of giving birth to live young. Unlike amphibians they breathe through lungs instead of gills. As they grow reptiles will shed their skin.");
        }

    }
}


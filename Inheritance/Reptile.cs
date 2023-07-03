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
            Console.WriteLine($"Reptiles are:");
            Console.WriteLine($"Cold Blooded: {ColdBlooded}");
            Console.WriteLine($"Reproduce by laying eggs: {LaysEggs}");
            Console.WriteLine($"Breathe through lungs instead of gills: {HasLungs}");
            Console.WriteLine($"Sheds it's skin as it grows: {Sheds}");
        }

    }
}


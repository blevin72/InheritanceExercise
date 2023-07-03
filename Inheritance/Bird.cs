using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
			EatsFood = true;
			LivesOnEarth = true;
			HasBrain = true;
			Reproduces = true;
		}

		public int Legs { get; set; }
		public int Wings { get; set; }
		public bool CanFly { get; set; }
		public bool LaysEggs { get; set; }
	
		public void Birds()
		{
			Console.WriteLine($"Birds are animals with {Legs} legs and {Wings} wings, that they use to fly around. Birds reproduce by laying eggs unlike mammals who birth live young.");
		}
	}
}


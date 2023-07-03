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
			Console.WriteLine($"Birds have {Legs} legs as well as {Wings} wings.");
			Console.WriteLine($"Birds have the ability to fly: {CanFly}");
			Console.WriteLine($"Birds reproduce by laying eggs {LaysEggs}");
		}
	}
}


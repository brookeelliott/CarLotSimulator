using System;
namespace CarLotSimulator
{
	public class Car
	{
		

			public string Make { get; set; }
			public string Model { get; set; }
			public int year { get; set; }
			public string EngineNoise { get; set; }
			public string HonkNoise { get; set; }
			public bool IsDriveable { get; set; }

			public void MakeEngineNoise(string engineInput)
			{
			Console.WriteLine($"{engineInput}!!!!!!!");
			}

			public void MakeHonkNoise(string honkInput)
			{
			Console.WriteLine($"{honkInput}!!!!!!!");
            }


	
	}
}


namespace Lect6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// object initialization
			Car car1 = new Car();
			car1.color = "black";
			car1.make = "Toyota";
			car1.model = "Corolla";
			car1.yearOfManifucture = 2005;
			car1.maxSpeed = 220;

			Console.WriteLine(car1.GetCarInfo());

			// object initialization
			Car car2 = new Car("Kia", "Cerato", 2006, "blue", 200);
			Console.WriteLine(car2.GetCarInfo());
			Console.WriteLine(car2.DetermineMarketValue());
		}
	}
}


namespace Lect6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// object initialization
			Car car1 = new Car();
			car1.setColor( "black");
			car1.setMake("Toyota");
			car1.setModel( "Corolla");
			car1.setYearOfManifucture(2005);
			car1.setMaxSpeed( 220);

			Console.WriteLine(car1.GetCarInfo());

			// object initialization
			Car car2 = new Car("Kia", "Cerato", 2006, "blue", 200);
			Console.WriteLine(car2.GetCarInfo());
			Console.WriteLine(car2.DetermineMarketValue());

			Car car3 = new Car("","",-3000,"MultiColor",1000);
			
		}
	}
}


using Class_Library_Project;

namespace Lect11
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();
			person.FullName = "Samy Hessen";
			//person.age = 1;// error here cause the age is private

			Console.WriteLine($"no of arguements passed : {args.Count()}");


			foreach (string arg in args)
			{
				Console.WriteLine($"argument : {arg}");
			}

			while (true)
				// error trap
				try
				{
					HandlingExceptionsExample();

					Console.WriteLine("Hadrtk tehb teksm rakmeen tany?(y/n)");
					string answer = Console.ReadLine();
					if (answer == "n")
					{
						break;
					}
				}
				catch (FormatException)
				{
					PrintException("Ya ret hedrtak tektb Arkam mesh Horoof !!!");
				}
				catch (OverflowException)
				{
					PrintException($"Maynf3sh tektb arkam akbar men {int.MaxValue} !!! Maynf3sh");
				}
				catch (DivideByZeroException)
				{
					PrintException($"Matksmsh 3la zero ... Mayshsh keda ");
				}
				catch (Exception ex)
				{
					PrintException(ex.Message);
				}
		
		}

		private static void PrintException(string messageToPrint)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(messageToPrint);
			Console.ResetColor();

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Try again ya user ");
			Console.ResetColor();
		}

		private static void HandlingExceptionsExample()
		{

			Console.Write("Enter a number to be divided :");
			int dividant = int.Parse( Console.ReadLine());
			Console.Write("Enter a number to divide by :");
			int divideBy = int.Parse( Console.ReadLine());

			int result = dividant / divideBy;

			Console.WriteLine($"Result: {result}");
			//throw new NotImplementedException();
		}
	}
}

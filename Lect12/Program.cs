using Microsoft.VisualBasic;

namespace Lect12
{
	
	internal class Program
	{
		static void Main(string[] args)
		{
			//LambdaExpressions();
			//Enumerations();
			//DateAndTime();
			AnonymousTypes();

		}

		private static void AnonymousTypes()
		{
			// Object Initializer (no constructor used)
			var student = new
			{
				Id = 1,
				FirstName = "Ali",
				LastName = "Reza",
				Age = 25,
			};

			Console.WriteLine(student.Id);
			Console.WriteLine(student.FirstName);
			Console.WriteLine(student.LastName);

			//student.Id = 2;//Error : cannot change value
			//student.FirstName = "Steve";//Error : cannot change value
			Console.WriteLine("--------------------------------------------");
			var person = new {
				Id = 4,
				Name = "John Doe",
				Age = 30,
				Address = new { City = "Cairo", Country ="Egypt",Street = "El Doki"}
			};

			Console.WriteLine(person.Address.Country);
		}

		private static void DateAndTime()
		{
			//assigns default value 01/01/0001 00:00:00
			DateTime dt = new DateTime();

			//assigns year, month, day
			DateTime dt2 = new DateTime(2015, 12, 23);


			//assigns year, month, day, hour, min, seconds
			DateTime dt3 = new DateTime(2015, 12, 23, 15, 30, 45);

			DateTime dt4 = new DateTime(636370000000000000);

			Console.WriteLine(dt4);
		}

		private static void Enumerations()
		{
			Console.WriteLine(WeekDays.Monday);
			Console.WriteLine(WeekDays.Friday); // output: Friday
			int day = (int) WeekDays.Friday;
			Console.WriteLine(day);

			var wd = (WeekDays) 5;

			Console.WriteLine(wd);

		}

		private static void LambdaExpressions()
		{
			Func<int, double, double> hesba = (x, y) => x * x / y;
			Func<int, double, double> hesbaTanya = (x, y) => x * y - 7 / y;

			UseAFunction(hesba);
			UseAFunction(hesbaTanya);

			Console.WriteLine("-------------------------------");

			int[] numbers = { 2, 3, 4, 5, 20, 101 };
			// LINQ: Langauge integrated Query
			var numbersThatDividableBy5 =     // LINQ query to get numbers divisible by 5
						numbers.Where(x => x % 5 == 0).ToArray();

			Console.WriteLine(string.Join(" - ", numbersThatDividableBy5));

			Console.WriteLine("-------------------------------");

			Action<string> greet =
						  name =>
						  {
							  string greeting = $"Hello {name}!";
							  Console.WriteLine(greeting);
						  };


			greet("Faysal");

			Console.WriteLine("-------------------------------");

			//If a lambda expression has only one input parameter,
			// parentheses are optional:

			Func<double, double> cube =
									x => x * x * x;

			//Sometimes the compiler can't infer the types of 
			//input parameters. You can specify the 
			//types explicitly as shown in the following example

			var isTooLong =
				(int x, string s) => s.Length > x;


			//You can use discards to specify two or more 
			//input parameters of a lambda expression that aren't 
			//used in the expression

			Func<int, int, int> constant =
										(_, _) => 42;
		}

		static void UseAFunction(Func<int, double, double> theFunction)
		{
			Console.WriteLine(theFunction(5, 4.25));
		}
	}
	
}

namespace Lect3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//CheckTheNearstValueTo20();
			//FindTheLargestAndLowest();
			//LoopWithSummation();
			DisplayPattern();
		}

		private static void CheckTheNearstValueTo20()
		{
			Console.WriteLine("Input first integer: ");
			int x = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Input second integer: ");
			int y = Convert.ToInt32(Console.ReadLine());

			int n = 20;

			int val1 = Math.Abs(x - n);
			int val2 = Math.Abs(y - n);

			if (val1 == val2)
			{
				Console.WriteLine(" The 2 numbers are at same distance to 20");
			}
			else if (val1 > val2)
			{
				Console.WriteLine("The nearst number to 20 is {0}", y);
			}
			else
			{
				Console.WriteLine("The nearst number to 20 is {0}", x);
			}

			// short if
			// (condition) ? result if true : result if false ;
			//Console.WriteLine(
			//	(val1 == val2) ? "The 2 numbers at same distance to 20" :
			//		(
			//			(val1> val2) ? 
			//				string.Format("The nearst number to 20 is {0}",y)
			//				:
			//				string.Format("The nearst number to 20 is {0}", x)
			//		)
			//);
		}

		private static void FindTheLargestAndLowest()
		{
			Console.WriteLine("Input first integer: ");
			int x = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Input second integer: ");
			int y = Convert.ToInt32(Console.ReadLine());


			Console.WriteLine("Input third integer: ");
			int z = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine( "Largest of the three : {0}"
					,Math.Max(x, Math.Max(y,z))
				);

			Console.WriteLine( "Lowest of the three : {0}"
					, Math.Min(x, Math.Min(y, z))
				);
		}

		private static void LoopWithSummation()
		{
			Console.WriteLine("Find the sum of first 100 numbers");
			Console.WriteLine("----------------------------------");
			Console.WriteLine("\n\n");

			int sum = 0;

			for ( int i = 1; i <=100; i++ )
			{
				sum += i;
				Console.WriteLine(i);
			}

			Console.WriteLine("The sum is : {0}", sum);
		}

		static void DisplayPattern()
		{
			int i, j, rows;

			Console.WriteLine("\n\n");
			Console.WriteLine("Display the pattern like right angle triangle using astresk:\n");
			Console.WriteLine("--------------------------------------------------------------");
			Console.WriteLine("\n\n");

			Console.WriteLine("Input number of rows : ");
			rows = Convert.ToInt32(Console.ReadLine());

			for (i = 1; i <= rows; i++)
			{
				for (j = 1; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.Write("\n");
			}

		}
	}
}

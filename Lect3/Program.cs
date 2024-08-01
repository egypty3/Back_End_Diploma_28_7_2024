namespace Lect3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//CheckTheNearstValueTo20();
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
	}
}


using System.Numerics;

namespace Lect4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//PrintArrayElement();
			SeparateOddAndEven();
			//LengthOfString();
			//SeparateToIndividualCharacters();
			//CountWords();

			// Method Calling
			// Method Overloading
			Multiply(4,5);
			Multiply(7, 9, 2);

			Console.WriteLine();
			Console.WriteLine(7);
			Console.WriteLine(9.32);
			Console.WriteLine();
		}

		static int Multiply(int x , int y)
		{
			int result = x * y;
			return result;
		}

		static int Multiply(int x , int y,int z)
		{
			int result = x * y * z;
			return result;
		}

		static double Multiply(double x, double y)
		{
			double result = x * y;
			return result;
		}
		private static void CountWords()
		{
			string str;

			Console.WriteLine("Input a string \n");
			str = Console.ReadLine();

			int wrdCount = 1;
			int i = 0;
			char prevChar = ' ' ;

			while (i < str.Length)
			{
				if (str[i] == ' ' && prevChar != ' ')
				{
					wrdCount++;
				}
				
				prevChar = str[i];
				i++;
			}

			Console.WriteLine("The number of words at the string is : {0}",wrdCount);

		}

		private static void SeparateToIndividualCharacters()
		{
			string str;

			Console.WriteLine("Input a string \n");
			str = Console.ReadLine();
			Console.WriteLine("The characters of the string are : ");
			
			int i = 0;

			while (i < str.Length)
			{
				Console.WriteLine(str[i]);
				i++;
			}
		}

		private static void LengthOfString()
		{
			string str;

			Console.WriteLine("Input a string \n");
			str = Console.ReadLine();

			Console.WriteLine("The length of string is {0}", str.Length);
		}

		private static void SeparateOddAndEven()
		{
			Console.Write(
			   "\nInput the number of elements to be stored in the array :"
			   );
			int n = Convert.ToInt32( Console.ReadLine() );

			int[] arr = new int[n];

			Console.Write("Input elements of the Array \n");

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write("element - {0} : ", i);

				arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			List<int> oddNumbers = new List<int>();
			List<int> evenNumbers = new List<int>();

			for (int i = 0;i < arr.Length;i++)
			{
				if (arr[i] % 2 ==0)
				{
					//even
					evenNumbers.Add(arr[i]);
				}
				else
				{
					// odd
					oddNumbers.Add(arr[i]);
				}
			}

			Console.Write("\nThe Even elements are : \n");
			for (int i = 0; i < evenNumbers.Count; i++)
			{
				Console.Write("{0}  ", evenNumbers[i]);
			}

			Console.Write("\nThe Odd elements are : \n");
			for (int i = 0; i < oddNumbers.Count; i++)
			{
				Console.Write("{0}  ", oddNumbers[i]);
			}
		}

		private static void PrintArrayElement()
		{
			//int[] arr = { 1, 2, 3 ,7,20};
			int[] arr = new int[10];

			Console.Write("\n\nRead and print elements of an array:");
			Console.Write("------------------------------------------\n");

			Console.Write("Input 10 elments in the array : \n");

			for (int i = 0; i < arr.Length; i++) {
				Console.Write("element - {0} : ",i);

				arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			Console.Write("\nElements in arrays are : ");
			for(int i = 0;i < arr.Length; i++) { 
				Console.WriteLine(" {0} ", arr[i]);
			}

		}
	}
}

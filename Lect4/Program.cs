
namespace Lect4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//PrintArrayElement();
			SeparateOddAndEven();
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

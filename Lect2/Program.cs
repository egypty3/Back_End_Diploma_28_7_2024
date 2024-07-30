int number1,number2,number3;

Console.WriteLine("Please, input first number :");
number1 =  int.Parse( Console.ReadLine());

Console.WriteLine("Please, input second number :");
number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Please, input third number :");
number3 = int.Parse(Console.ReadLine());

int result = number1 * number2 * number3;

//Console.WriteLine(
//	"Result of : {0} x  {1} x {2} = {3}" ,
//	number1,number2,number3,result);

Console.WriteLine(
	$" Result of : {number1} x {number2} x {number3} = {result}"
	);


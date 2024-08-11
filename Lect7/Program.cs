namespace Lect7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Book book = new Book("Ketab Hyati ya 3ni","Hassan Al Asmar",3);

			book.DisplayInfo();

			EBook eBook = new EBook("Ket", "Al moelef", 33, 4.25);
			
		}
	}
}

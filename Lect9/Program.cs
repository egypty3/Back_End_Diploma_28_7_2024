namespace Lect9
{
	internal class Program
	{
		

		private static string filePath =
			Path.Combine(
				Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
				"books.txt"
				);

		public static void Main(string[] args)
		{
			
			//Book.TotalBooks = 20; // Results error

			//Console.WriteLine(Book.TotalBooks);

			//EBook eBook = new EBook("Ket", "Al moelef", 33, 4.25);
			//eBook.DisplayInfo();

			//Book book = new Book("Ketab Hyati ya 3ni", "Hassan Al Asmar", 3);
			//book.DisplayInfo();


			// Polymoriphism  applied here
			List<Book> books = new List<Book>();
			LoadBooks(books);
			ShowMenu(books);
			SaveBooks(books);
		}

		private static void SaveBooks(List<Book> books)
		{
			StreamWriter sw = new StreamWriter(filePath);

			foreach (Book book in books)
			{
				if (book is EBook)
				{
					EBook eBook = (EBook)book;
					//sw.WriteLine($"{eBook.Title}|{eBook.Author}|{eBook.Pages}|{eBook.FileSize}");
					sw.WriteLine(eBook.ToString());
				}
				else
				{
					sw.WriteLine(book.ToString());
				}
			}
			sw.Close();
			Console.WriteLine("Books saved successfully");
		}

		private static void LoadBooks(List<Book> books)
		{
			if (File.Exists(filePath))
			{
				StreamReader sr = new StreamReader(filePath);

				string line;

				while ((line = sr.ReadLine()) != null)
				{
					string[] data = line.Split('|');
					if (data.Length == 3) // Book data has 3 elements
					{
						Book book = new Book(data[0], data[1], int.Parse(data[2]));
						books.Add(book);
					}
					else if (data.Length == 4) // EBook data has 4 elements
					{
						EBook eBook = new EBook(data[0], data[1],
										int.Parse(data[2]), double.Parse(data[3]));
						books.Add(eBook);
					}
				}
				sr.Close();

				Console.WriteLine("Books loaded successfully");
			}
			else
			{
				Console.WriteLine("No saved books found");
			}
		}

		private static void ShowMenu(List<Book> books)
		{
			while (true)
			{
				Console.ForegroundColor = ConsoleColor.Magenta;
				Console.WriteLine("\n\nLibrary System Menu:");
				Console.ResetColor();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("1. Add a book");
				Console.WriteLine("2. Add an E-book");
				Console.WriteLine("3. Display all books");
				Console.WriteLine("4. Show Total Books");
				Console.WriteLine("5. Exit");
				Console.ForegroundColor = ConsoleColor.Magenta;
				Console.Write("Choose and option: ");
				string choice = Console.ReadLine();
				Console.ResetColor();

				switch (choice)
				{
					case "1":
						AddBook(books);
						break;
					case "2":
						AddEBook(books);
						break;
					case "3":
						DisplayAllBooks(books);
						break;
					case "4":
						ShowTotalBooks();
						break;
					case "5":
						return;
					default:
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Invalid option. Please try again.");
						Console.ResetColor();
						break;
				}
			}
		}

		private static void ShowTotalBooks()
		{
			Console.ForegroundColor= ConsoleColor.Green;
			Console.WriteLine($"Total number of books and e-books: {Book.TotalBooks}");
			Console.ResetColor();
		}

		private static void DisplayAllBooks(List<Book> books)
		{
			if (books.Count == 0)
			{
				Console.WriteLine("No books available.");
				return;
			}

			foreach (var book in books)
			{
				book.DisplayInfo();
			}

		}

		private static void AddEBook(List<Book> books)
		{
			Console.Write("Enter the e-book title :");
			string title = Console.ReadLine();
			Console.Write("Enter the author's name :");
			string author = Console.ReadLine();
			Console.Write("Enter the number of pages :");
			int pages = int.Parse(Console.ReadLine());
			Console.Write("Enter the e-book size in MB :");
			double size = double.Parse(Console.ReadLine());

			EBook eBook = new EBook(title, author, pages, size);

			books.Add(eBook);

		}

		private static void AddBook(List<Book> books)
		{
			Console.Write("Enter the book title :");
			string title = Console.ReadLine();
			Console.Write("Enter the author's name :");
			string author = Console.ReadLine();
			Console.Write("Enter the number of pages :");
			int pages = int.Parse(Console.ReadLine());

			Book book = new Book(title, author, pages);
			books.Add(book);
		}
	}
}

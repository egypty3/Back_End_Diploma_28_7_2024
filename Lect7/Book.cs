using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect7
{
	internal class Book
	{
		#region Fields
		private string _title;
		private string _author;
		private int _pages;
		#endregion
		// Quick Property
		//public string Title { get; set; }

		// full property

		#region Properties

		public string Title
		{
			// read
			get
			{
				return _title;
			}
			// write	
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					// error
					Console.ForegroundColor = ConsoleColor.Red; // ConsoleColor is an enumeration (Enum)
					Console.WriteLine("Error: Title cannot be empty.");
					Console.ResetColor();
				}
				else
				{
					// ok
					_title = value;
				}
			}
		}

		public string Author
		{
			get
			{
				return _author;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Error: Author cannot be empty.");
					Console.ResetColor();
				}
				else
				{
					_author = value;
				}
			}
		}

		public int Pages
		{
			get
			{
				return _pages;
			}
			set
			{
				if (value < 1 || value > 1000)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Error: Invalid number of pages.");
					Console.ResetColor();
				}
				else
				{
					_pages = value;
				}
			}
		}

		#endregion

		#region Constructors
		public Book()
		{

		}
		public Book(string title, string author, int pages)
		{
			Title = title;
			Author = author;
			Pages = pages;
		}

		#endregion

		#region Methods
		public void DisplayInfo()
		{
			Console.ForegroundColor= ConsoleColor.Cyan;
			Console.WriteLine("=== Book Details ===");
			Console.ResetColor();
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"Title: {Title}");
			Console.WriteLine($"Author: {Author}");
			Console.WriteLine($"Pages: {Pages}");
			Console.ResetColor();
			Console.WriteLine();
		}
		#endregion
	}
}

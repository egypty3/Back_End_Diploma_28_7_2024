using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect9
{
	internal class EBook : Book
	{
        public double FileSize { get; set; }

		public EBook(string title, string author, int pages, double fileSize)	
			: base(title, author, pages)    // Call base class constructor with title, author and pages parameters   
			
		{			
			FileSize = fileSize;			
		}

		public override void DisplayInfo()
		{
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("=== EBook Details ===");
			Console.ResetColor();
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"Title: {Title}");
			Console.WriteLine($"Author: {Author}");
			Console.WriteLine($"Pages: {Pages}");
			Console.WriteLine($"File Size: {FileSize} MB");
			Console.ResetColor();
			Console.WriteLine();
		}
		public override string ToString()
		{
			return  $"{base.ToString()}|{FileSize}";
		}

	}
}

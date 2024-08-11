using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect7
{
	internal class EBook : Book
	{
        public double FileSize { get; set; }

		public EBook(string title, string author, int pages, double fileSize)	
			: base(title, author, pages)    // Call base class constructor with title, author and pages parameters   
			
		{			
			FileSize = fileSize;			
		}
	}
}

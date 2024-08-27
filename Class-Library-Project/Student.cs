using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library_Project
{
	public class Student : Person
	{
		private DateTime birthDate;

		public DateTime BirthDate
		{
			get { return birthDate; }
			set {
				if (age > 0)
				{
				}
				else
				{
					birthDate = value;
				}
			}
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lect6
{
	internal class Car
	{
		public string make;
		public string model;
		public int yearOfManifucture;
		public string color;
		public int maxSpeed;

		// constructor is a special method :
		// 1. Cause it's name is the same as the name of the Class
		// 2. It doesn't return anything even void !!!

		// default constructor is created automatically if no other constructor overloads exist
		public Car()
		{

		}

		// constructor overload
		public Car( string make, string model, 
			int yearOfManifucture, string color, int maxSpeed)
        {
			this.make = make;
			this.model = model;
			this.yearOfManifucture = yearOfManifucture;
			this.color = color;
			this.maxSpeed = maxSpeed;
		}
        public string GetCarInfo()
		{		
			return 
				$"Make: {make}, Model: {model}, " +
				$"Year: {yearOfManifucture}, Color: {color}, Max Speed: {maxSpeed}";
		}

		public decimal DetermineMarketValue()
		{
			decimal carPrice;
			if (yearOfManifucture < 2002)
			{
				carPrice = 20000;
			}
			else
			{
				carPrice = 300000;
			}
			// Someday I might look up for the market value 
			// using more accurate online WebAPI
			return carPrice;
		}
	}
}

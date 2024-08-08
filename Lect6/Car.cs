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
		// Encasulation
		private string make;
		private	 string model;
		private int yearOfManifucture;
		private string color;
		private int maxSpeed;

		// constructor is a special method :
		// 1. Cause it's name is the same as the name of the Class
		// 2. It doesn't return anything even void !!!

		// default constructor is created automatically if no other constructor overloads exist
		public Car()
		{

		}

		public void setMake(string make)
		{
			if (make == "")
			{
				Console.WriteLine("Invalid make");
			}
			else
			{
				this.make = make;
			}
		}
		public void setModel(string model)
		{
			if (model == "")
			{
				Console.WriteLine("Invalid model");
			}
			else
			{
				this.model = model;
			}
		}
		// set all the private fields using set... field name methods
		public void setYearOfManifucture(int yearOfManifucture)
		{
			if (yearOfManifucture < 1900 || yearOfManifucture > 2022)
			{
				Console.WriteLine("Invalid year of manufacture");
			}
			else
			{
				this.yearOfManifucture = yearOfManifucture;
			}
		}
		public void setColor(string color)
		{
			if (color == "")
			{
				Console.WriteLine("Invalid color");

			}
			else
			{ 
				this.color = color;
			}
		}


		public void setMaxSpeed(int maxSpeed)
		{ 
			if (maxSpeed < 0 || maxSpeed > 300)
			{
				Console.WriteLine("Invalid max speed");
			}
			else
			{
				this.maxSpeed = maxSpeed;
			}
		}



			// constructor overload
		public Car( string make, string model, 
			int yearOfManifucture, string color, int maxSpeed)
        {
			setMake( make);
			setModel(model);
			setYearOfManifucture(yearOfManifucture);
			setColor(color);
			setMaxSpeed(maxSpeed);
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

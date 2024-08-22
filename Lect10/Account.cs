using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect10
{
	internal abstract class Account
	{
		public abstract bool CloseAccount();

		private string accountOwner;

		public string AccountOwner
		{
			get { return accountOwner; }
			set
			{
				if (value != "")
					accountOwner = value;
				else
					throw new ArgumentException(
						"Invalid account owner");
			}
		}

		protected double balance;

		public double Balance
		{
			get { return balance; }
		}
	}
}

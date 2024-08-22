using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect10
{
	internal class CreditAccount : Account, IAccount,IBan
	{
		

		public string IBANNumber { get; set; }

		public double CalcBalanceAfterOneYear()
		{
			if (Balance >= 100000) {
				return balance * 1.25;
			}
			else
			{
				return balance * 1.20;
			}
		}

		public override bool CloseAccount()
		{
			return true;
		}

		public void Deposit(double amount)
		{
			if (amount >= 200)
			{
				balance += amount;
			}
			else
			{
				throw new ArgumentException("Money is too small");
			}
		}

		public void Withdraw(double amount)
		{
			if (this.balance >= amount && amount <= 50000)
				this.balance -= amount;
			else
				throw new InvalidOperationException("Insufficient funds or amount exceeds daily limit");
		}
	}
}

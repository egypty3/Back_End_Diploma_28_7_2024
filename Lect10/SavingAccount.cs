using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect10
{
	internal class SavingAccount : Account, IAccount
	{
	



		public double CalcBalanceAfterOneYear()
		{
			return balance * 1.05;
		}

		public override bool CloseAccount()
		{
			return true;
		}

		public void Deposit(double amount)
		{
			this.balance += amount;
		}

		public void Withdraw(double amount)
		{
			if (this.balance >= amount)
				this.balance -= amount;
			else
				throw new InvalidOperationException("Insufficient funds");
		}
	}
}

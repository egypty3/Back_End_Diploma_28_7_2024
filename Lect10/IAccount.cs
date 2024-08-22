using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect10
{
	internal interface IAccount
	{
		string AccountOwner { get; set; }
		double Balance { get;  }
		void Deposit(double amount);
		void Withdraw(double amount);
		double CalcBalanceAfterOneYear();
	}
}

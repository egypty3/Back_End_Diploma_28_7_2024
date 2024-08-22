namespace Lect10
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//try
			//{
			//	SavingAccount account = new 
			//		SavingAccount();
			//	account.AccountOwner = "";
			//}
			//catch (Exception ex)
			//{
			//	Console.WriteLine(ex.ToString());
			//}
			
			SavingAccount s = new SavingAccount();

			s.AccountOwner = "Tarek Amer";
			s.Deposit(50000000);

			IAccount c = new CreditAccount();
			c.AccountOwner = "Tarek Shawki";
			c.Deposit(20000000);

			PrintAccountDetails(s);
			PrintAccountDetails(c);
		}

		static void  PrintAccountDetails(IAccount c) // polymorphic method
		{
			Console.WriteLine( $"{c.AccountOwner} has {c.Balance} EGP");
		}
	}
}

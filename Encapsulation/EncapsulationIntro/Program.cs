namespace EncapsulationIntro
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Account account = new Account();
			//account.ClientName = "Nijat Soltanov";
			//account.BalanciArtir(5000);
			//account.BalanciArtir(1000);
			//Console.WriteLine(account.Getalance());
			//         //account.Balance = 5000;


			//         Account account2 = new Account();
			//account2.ClientName = "Ali Agayev";
			//account2.BalanciArtir(10000);
			////account2.Balance = 15000;

			//Console.WriteLine(account.ToString());
			//         Console.WriteLine(account2.ToString());

			Account account = new Account(15000);
            Console.WriteLine(account.GetBalance());

			account.Deposit(5000);
			Console.WriteLine(account.GetBalance());

			account.Withdraw(20000);
            Console.WriteLine(account.GetBalance());

        }
	}
}

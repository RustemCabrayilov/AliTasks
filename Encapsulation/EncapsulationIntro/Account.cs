using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationIntro
{
	public class Account
	{
		//public readonly int Id;
		//public string ClientName { get; set; }
		//private double Balance { get; set; }
		//private static int _count;

		//      public Account()
		//      {
		//	_count++;
		//	Id = _count;
		//      }

		//public void BalanciArtir(double money)
		//{
		//	Balance += money;
		//}

		//public double Getalance()
		//{
		//	return Balance;
		//}
		//public override string ToString()
		//{
		//	return "Id: " + this.Id + " ClientName: " + this.ClientName + " Balance: " + this.Balance;
		//}

	        private decimal _balance;
		    
		    public decimal balance { 

			get => _balance; 
			set => _balance = value;
		    }	

			public Account(decimal initialBalance)
			{
				balance = initialBalance;
			}

			public decimal GetBalance()
			{
				return balance;
			}

			public void Deposit(decimal amount)
			{
				balance += amount;
			}

			public void Withdraw(decimal amount)
			{
				balance -= amount;
			}
	}
}

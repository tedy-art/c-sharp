using System;

namespace BankAccountApp
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount(1000);

            myAccount.Deposit(500);
            Console.WriteLine("Balance: " + myAccount.GetBalance());

            myAccount.Withdraw(2000);
            Console.WriteLine("Balance: " + myAccount.GetBalance());

            myAccount.Withdraw(500);
            Console.WriteLine("Balance: " + myAccount.GetBalance());

            Console.ReadLine();
        }
    }
}

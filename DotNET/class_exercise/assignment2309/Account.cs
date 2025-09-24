using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2309
{
    internal class Account
    {
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public double Balance { get; set; }

        public Account(string accountNumber, string holderName, double balance = 0.0)
        {
            AccountNumber = accountNumber;
            AccountHolderName = holderName;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"\nDeposited ₹{amount}. \nNew Balance:₹{Balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"\nWithdrew ₹{amount}. \nNew Balance: ₹{Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"\nAccount Balance: ₹{Balance}");
        }
    }
}

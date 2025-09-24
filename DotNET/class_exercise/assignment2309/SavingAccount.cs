using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2309
{
    internal class SavingAccount:Account
    {
        public double InterestRate { get; set; }

        public SavingAccount(string accountNumber, string holderName, double balance = 0.0, double interestRate = 0.05)
            : base(accountNumber, holderName, balance)
        {
            InterestRate = interestRate;
        }

        public void ApplyInterest()
        {
            double interest = Balance * InterestRate;
            Balance += interest;
            Console.WriteLine($"Interest of ₹{interest} applied. New Balance: ₹{Balance}");
        }
    }
}

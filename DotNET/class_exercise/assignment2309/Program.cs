namespace assignment2309
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SavingAccount acc = new SavingAccount("SB001", "Amit Kumar", 10000.0);
            
            //acc.DisplayBalance();
            //acc.Deposit(5000);
            //acc.Withdraw(2000);

            //acc.ApplyInterest();

            //Console.ReadLine();

            List<SavingAccount> accounts = new List<SavingAccount>();

            
            SavingAccount acc1 = new SavingAccount("SB001", "Amit Kumar", 10000.0);
            accounts.Add(acc1);

            SavingAccount acc2 = new SavingAccount("SB002", "Gopal Bhai", 50000.0);
            accounts.Add(acc2);


            SavingAccount acc3 = new SavingAccount("SB003", "Priya Sharma", 25000.0);
            accounts.Add(acc3);

            SavingAccount acc4 = new SavingAccount("SB004", "Supriya Sharma", 45000.0);
            accounts.Add(acc4);

            SavingAccount acc5 = new SavingAccount("SB005", "Priyanka Sharma", 65000.0);
            accounts.Add(acc5);

            Console.WriteLine($"\nDetails for {acc1.AccountHolderName}:");
            acc1.DisplayBalance();
            acc1.Deposit(5000);
            acc1.Withdraw(2000);
            acc1.ApplyInterest();

            Console.WriteLine($"\nDetails for {acc2.AccountHolderName}:");
            acc2.DisplayBalance();
            acc2.Deposit(7000);
            acc2.Withdraw(1000);
            acc2.ApplyInterest();

            
            Console.WriteLine($"\nDetails for {acc3.AccountHolderName}:");
            acc2.DisplayBalance();
            acc2.Deposit(7000);
            acc2.Withdraw(1000);
            acc2.ApplyInterest();

            Console.WriteLine($"\nDetails for {acc4.AccountHolderName}:");
            acc2.DisplayBalance();
            acc2.Deposit(7000);
            acc2.Withdraw(1000);
            acc2.ApplyInterest();

            Console.WriteLine($"\nDetails for {acc5.AccountHolderName}:");
            acc2.DisplayBalance();
            acc2.Deposit(7000);
            acc2.Withdraw(1000);
            acc2.ApplyInterest();

            //Console.WriteLine($"\nDetails for {accounts[2].AccountHolderName}:");
            //accounts[2].DisplayBalance();

            //Console.WriteLine($"\nDetails for {accounts[2].AccountHolderName}:");
            //accounts[2].DisplayBalance();

            Console.ReadLine();
        }
    }
}

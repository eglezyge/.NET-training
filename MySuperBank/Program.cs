using MySuperBank;
using System;

var account = new BankAccount("Egle Zyge", 10000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} $.");

account.MakeWithdrawal(150, DateTime.Now, "For food");
Console.WriteLine($"The remaining balance of the account is {account.Balance} $.");

account.MakeDeposit(300, DateTime.Now, "Deposit");
Console.WriteLine(account.Balance);

Console.WriteLine(account.GetAccountHistory());


//namespace MySuperBank
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            var account = new BankAccount("Egle Zyge", 10200);
//            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} $.");
//        }
//    }
//}

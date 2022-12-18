using MySuperBank;
using System;

var account = new BankAccount("Egle Zyge");
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} $.");


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

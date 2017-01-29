using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
           Client cl = new Client("Anna", "Poghosyan",new DateTime(1985,06,12));

            Account Acou = new Account(cl, AccountType.Current, Currency.AMD);
            Console.WriteLine(Acou.Balance);
            Banking.Transaction(Acou, TransactionType.AddMoney, new Money (150, Currency.AMD));
            Console.WriteLine(Acou.Balance);
            Banking.Transaction(Acou, TransactionType.WithdrawMoney, new Money(100, Currency.AMD));
            Console.WriteLine(Acou.Balance);
            Banking.Transaction(Acou, TransactionType.WithdrawMoney, new Money(100, Currency.USD));
            Banking.Transaction(Acou, TransactionType.WithdrawMoney, new Money(100, Currency.AMD));

            Console.WriteLine(Acou.Balance);
           

            Console.ReadKey();


        }
    }
}

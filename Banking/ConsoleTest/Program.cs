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
            Guid c=cl.ID;
            Console.WriteLine(c);
            Account accou = new Account(cl, AccountType.Current, Currency.AMD);
            Console.WriteLine(accou);
            Console.WriteLine(accou.balance);
            Banking.Transaction(accou, TransactionType.AddMoney, new Money (150, Currency.AMD));
            Console.WriteLine(accou.balance);
            Banking.Transaction(accou, TransactionType.WithdrawMoney, new Money(100, Currency.AMD));
            Console.WriteLine(accou.balance);
            Banking.Transaction(accou, TransactionType.WithdrawMoney, new Money(100, Currency.USD));
            Banking.Transaction(accou, TransactionType.WithdrawMoney, new Money(100, Currency.AMD));

            Console.WriteLine(accou.balance);
            //ClientInfoCollection collection = new ClientInfoCollection();
            //foreach (var item in collection.GetEnumerator())
            //{
            //    Console.WriteLine(item);
            //}



            Console.ReadKey();


        }
    }
}

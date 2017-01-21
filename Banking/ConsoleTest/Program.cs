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
            Account Acou = new Account(cl, AccountType.Current,AccountCurrency.AMD);
            Banking.Transaction(Acou, TransactionType.AddMoney, 150);
            Console.WriteLine(Acou);


            Console.ReadKey();


        }
    }
}

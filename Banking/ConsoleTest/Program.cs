using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
           Client cl = new Client("Anna", "Poghosyan",new DateTime(1985,06,12));
            string name=cl.Name;
            Account ac = cl.GetAccount;
            Account Acou = new Account(cl);
            
            Console.WriteLine(cl.ToString());

            Console.ReadKey();


        }
    }
}

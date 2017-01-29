using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class AccountEventArgs: EventArgs
    {
        public Account Accouon { get; set; }
        public Money Money { get; set; }
       // public TransactionType Type { get; set; }
        public AccountEventArgs(Account acou, Money mon ) //TransactionType type,)
        {
            this.Accouon = acou;
           // this.Type = type;
            this.Money = mon;
        }
    }
}

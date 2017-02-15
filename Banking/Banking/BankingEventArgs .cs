using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankingEventArgs: EventArgs
    {
        public Money money { get; private set; }
      
        public BankingEventArgs(Money mon ) 
        {
            this.money = mon;
        }
    }

}

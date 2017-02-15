using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public struct Money
    {
        public decimal moneySize { get; set; }
        public Currency curency { get; set; }
        public Money(decimal money, Currency curr)
        {
            this.moneySize = money;
            this.curency = curr;
        }
    }
}

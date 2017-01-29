using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public struct Money
    {
        public decimal MoneySize { get; set; }
        public Currency Curency { get; set; }
        public Money(decimal money, Currency curr)
        {
            this.MoneySize = money;
            this.Curency = curr;
        }
    }
}

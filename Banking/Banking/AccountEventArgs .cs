﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class AccountEventArgs: EventArgs
    {
        public Money Money { get; set; }
      
        public AccountEventArgs(Money mon ) 
        {
            this.Money = mon;
        }
    }

}

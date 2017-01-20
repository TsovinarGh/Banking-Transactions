using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public  class Account
    {
        private decimal balance;
        
        
        public Account(Client client)
        {
            AccountGenerate();
        }

        private Guid AccountGenerate()
        {
            return Guid.NewGuid();
        }

        public void Add(decimal money)
        {
            balance= balance + money;
        }

        public void Withdraw(decimal money)
        {
            if (balance >= money)
            {
                balance = balance - money;
            }
        }
        
        public decimal Balance
        {
            get { return balance; }
        }
        
    }
}

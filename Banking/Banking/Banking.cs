using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public static class Banking
    {
        public static decimal CurrentBalance { get; private set; }
        public static decimal Transaction(Account accou, TransactionType transe, decimal money)
        {
            switch (transe)
            {
                case TransactionType.AddMoney:
                    CurrentBalance= CurrentBalance + money;
                    break;
                   
                case TransactionType.WithdrawMoney:
                    if (CurrentBalance >= money)
                    {
                        CurrentBalance = CurrentBalance - money;
                    }
                    break;
                case TransactionType.Balance:
                   return CurrentBalance;
                    
            }

            return CurrentBalance;
        }
    }
}

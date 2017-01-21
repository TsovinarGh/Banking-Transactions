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
                    CurrentBalance= accou.Balance + money;
                    break;
                   
                case TransactionType.WithdrawMoney:
                    if (accou.Balance >= money)
                    {
                        CurrentBalance = accou.Balance - money;
                    }
                    break;
                case TransactionType.Balance:
                    CurrentBalance = accou.Balance;
                    break;
            }

            return CurrentBalance;
        }
    }
}

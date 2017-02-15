using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public static class Banking
    {
        private static decimal currentBalance;
        public static event EventHandler<BankingEventArgs> balanceRefresh;

        public static void Transaction(Account account, TransactionType type, Money money)
        {
            switch (type)
            {
                case TransactionType.AddMoney:
                    try
                    {
                        AddMoney(account, money);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case TransactionType.WithdrawMoney:
                    try
                    {
                        WithdrawMoney(account, money);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        private static void AddMoney(Account account, Money money)
        {
            if (account.curency == money.curency)
            {
                currentBalance = account.balance + money.moneySize;
                balanceRefresh?.Invoke(account, new BankingEventArgs(new Money(currentBalance, account.curency)));
            }
            else
            {
                throw new ArgumentException("Account and money currencies are not the same");
            }
        }


        private static void WithdrawMoney(Account account, Money money)
        {
            if (account.curency == money.curency)
            {
                if ((account.balance > money.moneySize))
                {
                    currentBalance = account.balance - money.moneySize;
                    balanceRefresh?.Invoke(account, new BankingEventArgs(new Money(currentBalance, account.curency)));
                }
                else
                {
                    throw new ArgumentException("There is no enough money in your account");
                }
            }
            else
            {
                throw new ArgumentException("Account and money currencies are not the same");
            }
        }
        
    }

}

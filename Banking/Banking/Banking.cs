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
        public static event EventHandler<AccountEventArgs> balanceRefresh;

        public static void Transaction(Account account, TransactionType type, Money money)
        {
            switch (type)
            {
                case TransactionType.AddMoney:
                    try
                    {
                        AddMoney(account, money);
                    }
                    catch(Exception ex)
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
            if (account.Curency == money.Curency)
            {
                currentBalance = account.Balance + money.MoneySize;
                AccountEventInvoke(account, new Money(currentBalance, account.Curency));
                
            }
            else
            {
                throw new ArgumentException("Account and money currencies are not the same");
            }
        }
  

        private static void WithdrawMoney(Account account, Money money)
        {
            if (account.Curency == money.Curency)  
            {
                if ((account.Balance > money.MoneySize))
                {
                    currentBalance = account.Balance - money.MoneySize;
                    AccountEventInvoke(account, new Money(currentBalance, account.Curency));
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

        private static void AccountEventInvoke(Account account, Money money)
        {
                balanceRefresh?.Invoke(account, new AccountEventArgs(money));
        }
    }

}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account
    {
        public Client Client { get; private set; }
        public Currency Curency { get; private set; }
        public AccountType AccountType { get; private set; }
        public Guid AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        private List<Account> accountInfo;
       
       
        public Account(Client client, AccountType actp, Currency accur)
        {
            Client = client;
            AccountType = actp;
            Curency = accur;
            try
            {
                AccountNumber = AccountGenerate(actp, accur);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }
            Balance = 0;
            Banking.balanceRefresh += FillAccountChanging;
            accountInfo = new List<Account>();
            accountInfo.Add(this);
        }

        private Guid AccountGenerate(AccountType actp, Currency accur)
        {
                switch (actp)
                {
                    case AccountType.Current:
                        switch (accur)
                        {
                            case Currency.AMD:
                               return Guid.NewGuid();
                               
                            case Currency.EUR:
                                return Guid.NewGuid();
                                
                            case Currency.USD:
                                return Guid.NewGuid();
                        }                                            
                        break;
                    case AccountType.Saving:
                        switch (accur)
                        {
                            case Currency.AMD:
                                return Guid.NewGuid();
                                
                            case Currency.EUR:
                                return Guid.NewGuid();
                                
                            case Currency.USD:
                                return Guid.NewGuid();
                        }
                        break;
            }

            throw new ArgumentException();
        }

      
        private static void FillAccountChanging(object obj, AccountEventArgs arg)
        {
            Account tempAccount = obj as Account;
            if (tempAccount != null)
            {
                tempAccount.Balance = arg.Money.MoneySize;
            }

        }
        
        public override string ToString()
        {
            return ($"Account details are: owner: {Client}, Account Number:{AccountNumber}, Type: {AccountType}, Curency {Curency}, Balance:{Balance}");
        }

    }
}

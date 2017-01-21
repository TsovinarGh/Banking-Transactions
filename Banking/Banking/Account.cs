using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account
    {
        public Client Client { get; private set; }
        public AccountCurrency Curency { get; private set; }
        public AccountType AccountType { get; private set; }
        public Guid AccountNumber { get; private set; }
       // public decimal Balance { get; private set; }
        //private Dictionary<Client,Account> AccountCollection;
       
        // public Dictionary<Client, Dictionary<AccountCurrency, Dictionary<AccountType, Account>>> acountDic;

        public Account(Client client, AccountType actp, AccountCurrency accur)
        {
            Client = client;
            AccountType = actp;
            Curency = accur;
            AccountNumber = AccountGenerate(actp, accur);
            //Balance = 0;
        }

        private Guid AccountGenerate(AccountType actp, AccountCurrency accur)
        {
                switch (actp)
                {
                    case AccountType.Current:
                        switch (accur)
                        {
                            case AccountCurrency.AMD:
                               return Guid.NewGuid();
                               
                            case AccountCurrency.EUR:
                                return Guid.NewGuid();
                                
                            case AccountCurrency.USD:
                                return Guid.NewGuid();
                        }                                             // amboghjy uzum em dnenq try catchi mej
                        break;
                    case AccountType.Saving:
                        switch (accur)
                        {
                            case AccountCurrency.AMD:
                                return Guid.NewGuid();
                                
                            case AccountCurrency.EUR:
                                return Guid.NewGuid();
                                
                            case AccountCurrency.USD:
                                return Guid.NewGuid();
                        }

                        break;
                }

            throw new ArgumentException();
        }

        public override string ToString()
        {
            return ($"Account details are: owner: {Client}, Account Number:{AccountNumber}, Type: {AccountType}, Curency {Curency}, Balance:{Banking.CurrentBalance}");
        }

    }
}

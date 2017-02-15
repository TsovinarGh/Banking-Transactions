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
        public Client client { get; private set; }
        public Currency curency { get; private set; }
        public AccountType accountType { get; private set; }
        public Guid accountNumber { get; private set; }
        public decimal balance { get; private set; }
        public static event EventHandler<AccountInfoEventArgs> accountInfoEvent; //uzum em aranc statici
        //private ClientInfoCollection accountList = new ClientInfoCollection();
         private List<Account> accountList= new List<Account>();       

        public Account(Client client, AccountType actp, Currency curr)
        {
            this.client = client;
            accountType = actp;
            curency = curr;
            try
            {
                accountNumber = AccountGenerate(actp, curr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }
            balance = 0;
            Banking.balanceRefresh += FillAccountChanging;
            accountList.Add(this);
            AccountInfoEventInvoke();
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

      
        private static void FillAccountChanging(object obj, BankingEventArgs arg)
        {
            Account currentAccount = obj as Account;
            if (currentAccount != null)
            {
                currentAccount.balance = arg.money.moneySize;
            }
        }
        
        public override string ToString()
        {
            return ($"Account details are: owner: {client}, \nAccount Number:{accountNumber}, \nType: {accountType}, \nCurency {curency}, \nBalance:{balance}");
        }

        private void AccountInfoEventInvoke()
        {
            accountInfoEvent?.Invoke(this, new AccountInfoEventArgs(accountList));
        }
    }
}

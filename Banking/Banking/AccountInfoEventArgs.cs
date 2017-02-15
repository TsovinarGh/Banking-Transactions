using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class AccountInfoEventArgs : EventArgs
    {
        public List<Account> listArgs { get; private set; }
        
        public AccountInfoEventArgs(List<Account> list) 
        {
            this.listArgs = list;
        }
    }
}

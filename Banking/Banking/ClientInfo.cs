using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class ClientInfo : IEnumerable<Account>
    {
        private List<Account> clientInfo;

        public ClientInfo()
        {

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Account> IEnumerable<Account>.GetEnumerator()
        {
            return clientInfo.GetEnumerator();
        }
    }
}

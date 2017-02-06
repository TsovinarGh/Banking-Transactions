using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class ClientInfoCollection
    {
         
        private List<Account> clientInfoList=new List<Account>();
        private const String message = "This Client dosent have Account";

        public ClientInfoCollection()
        {
            Account.ClientInfo += FillingChenges;
        }
        public IEnumerable GetEnumerator()
        {
            foreach (var item in clientInfoList)
            {
                yield return item;
            }
        }

        public void Add(Account account)
        {
            clientInfoList.Add(account);
        }
        public Account ByClient(Client client)
        {
            foreach (Account item in clientInfoList)
            {
                if (item.Client == client)
                {
                    return item;
                }
                else
                {
                    Console.WriteLine(message);
                }
            }
            throw new ArgumentException();
        }

        public Account ByFullName(string name, string surname)
        {
            foreach (Account item in clientInfoList)
            {
                if ((item.Client.Name == name) && (item.Client.SurName == surname))
                {
                    return item;
                }
                else
                {
                    Console.WriteLine(message);
                }
            }
            throw new ArgumentException();
        }

        private void FillingChenges(object obj, InfoEventArgs arg)
        {
            ClientInfoCollection temp = obj as ClientInfoCollection;
            if (temp == null)
            {

            }

            clientInfoList = temp.clientInfoList;
        }


        public Account this[int index]
        {
            get
            {
                return clientInfoList[index];
            }
        }
    }
}

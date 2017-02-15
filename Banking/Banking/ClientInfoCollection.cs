using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public  class ClientInfoCollection
    {
        //public  List<Account> clientInfoList { get; private set; }
        private static List<Account> clientInfoList;
        private const String message = "This Client dosent have Account";

        public ClientInfoCollection()
        {
            Account.accountInfoEvent += FillingChenges;
        }
        public static IEnumerable GetEnumerator()
        {
            foreach (var item in clientInfoList)
            {
                yield return item;
            }
        }

        
        //public Account ByClient(Client client)
        //{
        //    foreach (Account item in clientInfoList)
        //    {
        //        if (item.client == client)
        //        {
        //            return item;
        //        }
        //        else
        //        {
        //            Console.WriteLine(message);
        //        }
        //    }
        //    throw new ArgumentException();
        //}

        //public Account ByFullName(string name, string surname)
        //{
        //    foreach (Account item in clientInfoList)
        //    {
        //        if ((item.client.Name == name) && (item.client.SurName == surname))
        //        {
        //            return item;
        //        }
        //        else
        //        {
        //            Console.WriteLine(message);
        //        }
        //    }
        //    throw new ArgumentException();
        //}

        private static void FillingChenges(object obj, AccountInfoEventArgs args)
        {
            Account temp = obj as Account;
            if (temp == null)
            {
                throw new ArgumentNullException();
            }

            clientInfoList = args.listArgs;
        }


        //public Account this[int index]
        //{
        //    get
        //    {
        //        return clientInfoList[index];
        //    }
        //}
    }
}

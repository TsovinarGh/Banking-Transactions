using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Client
    {
        private const string unValidValue = "UnvalidValue";
        private const int maxAge = 140;
        private const int minAge = 16;
        private DateTime unValidDateTime = DateTime.MinValue;
        private string name;
        private string surName;
        private Guid iD;
        private DateTime birthDay;
       
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    name = unValidValue;
                }
                else
                {
                    name = value;
                }
            }
        }
        public string SurName
        {
            get
            {
                return surName;
            }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    surName = unValidValue;
                }
                else
                {
                    surName = value;
                }
            }
        }
        public DateTime BirthDay
        {
            get
            {
                return birthDay;
            }
            private set
            {
                int temp = DateTime.Now.Year - value.Year;
                if (temp <= 0 || temp < minAge || temp > maxAge)
                {
                    birthDay = unValidDateTime;
                }
                else
                {
                    birthDay = value;
                }
            }
        }
        public Guid ID
        {
            get
            {
                return iD; 
            }
        }

        public Client(string name, string surName, DateTime birth)
        {
            Name = name;
            SurName = surName;
            BirthDay = birth;
            iD= Guid.NewGuid();
        }
        public override string ToString()
        {
            return ($"Name: {Name}, Surname: {SurName}, \nBirthday {BirthDay}, \nID Number {ID}");
        }

        public static bool operator == (Client cl1, Client cl2)
        {
            return cl1.Equals(cl2);
        }

        public static bool operator !=(Client cl1, Client cl2)
        {
            return (!cl1.Equals(cl2));
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Client temp = obj as Client;
            if (temp == null)
            {
                return false;
            }
            return ((this.name == temp.name) && (this.surName == temp.surName) && (this.iD == temp.iD)); 
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}

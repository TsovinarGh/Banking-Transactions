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
        private DateTime dt = DateTime.MinValue;
        private string name;
        private string surName;
        private Guid id;
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
                    birthDay = dt;
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
                return Guid.NewGuid();
            }
        }

        public Client(string name, string surName, DateTime birth)
        {
            Name = name;
            SurName = surName;
            id = ID;
            BirthDay = birth;
        }
        public override string ToString()
        {
            return ($"Name: {Name}, Surname: {SurName}, Birthday {BirthDay}, ID Number {ID}");

        }

    }

}

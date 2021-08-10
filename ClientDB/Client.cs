using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDB
{
    class Client
    {
        private string lastName = "";
        private string firstName = "";
        private string secondName = "";
        private int age = 0;
        
        public Client() { }

        public Client(string name, int value)
        {
            SetNames(name);
            SetAge(value);
        }

        private void SetNames( string name )
        {
            if( name != " ")
            {
                string[] names = name.Split(new string[] { " ", "." },
                StringSplitOptions.RemoveEmptyEntries);
                int n = names.Length;
                // Length is the number of array elements (names)

                if (n == 1) { firstName = names[0]; }
                else if (n == 2) {
                    firstName = names[0];
                    lastName = names[1];
                }
                    else {
                        firstName = names[0];
                        secondName = names[1];
                        lastName = names[2];
                    }
            }
            
        }
        public void SetAge(int value)
        {
            age = value;
        }

        public string FullName
        {
            get { return firstName + " " + secondName + " " + lastName;  }
            set { SetNames(value);  }
        }
      
        public int Age
        {
            get { return age; }
            set { SetAge(value); }
        }

        public bool IsSame( string name )
        {
            string[] names = name.Split(new string[] { " ", "." },
                StringSplitOptions.RemoveEmptyEntries);
            int n = names.Length;

            if (lastName != null)
                return lastName.Equals(names[n - 1]) &&
                    firstName.Equals(names[0]);
            else
                return name.Equals(names[0]);

        }



    }
}

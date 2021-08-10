using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDB
{
    class NonMemberClient : Client
    {
        private int clientID;

        public NonMemberClient() : base() {  }

        public NonMemberClient(string name, int value, int ID) : base(name, value)
        {
            setID(ID);
        }

        public void setID(int id)
        {
            clientID = id;
        }
        
        public int ClientID
        {
            get { return clientID;  }
            set { setID(clientID);  }
        }

    }
}

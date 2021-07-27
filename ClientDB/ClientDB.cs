using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClientDB
{
    class ClientDB
    {
        private string companyName;
        public int totalClients;       // Total number of clients maintained by this object
        private const int MAX_CLIENTS = 100;
        private Client[] myClients;     // An array containing the clients' object reference

        public ClientDB(string companyName)
        {
            this.companyName = companyName;
            totalClients = 0;
            myClients = new Client[MAX_CLIENTS];
        }

        public bool AddClient(string clientName)
        {
            
            // Find any empty slots in myClient array
            int index = -1;
            for (int i = 0; i < MAX_CLIENTS; i++)
            {
                if (myClients[i] == null)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                myClients[index] = new Client(clientName);
                // Create a new client object

                totalClients++;
                return true;
            }
            return false;
        }

        public bool RemoveClient(string clientName)
        {
            for (int i = 0; i < MAX_CLIENTS; i++)
            {
                if (myClients[i] != null)
                {
                    if (myClients[i].IsSame(clientName))
                    {
                        myClients[i] = null;
                        // This client object is to be garbage collected
                        totalClients--;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsAClient(string clientName)
        {
            for (int i = 0; i < MAX_CLIENTS; i++)
                if (myClients[i] != null)
                    if (myClients[i].IsSame(clientName))
                        return true;
            return false;
        }

        public bool ListAllClients(IList list)
        {
            bool check = false;

            for (int i = 0; i < totalClients; i++)
            {
                list.Add(myClients[i].FullName);
                check = true;
            }

            return check;

        }
    }
}

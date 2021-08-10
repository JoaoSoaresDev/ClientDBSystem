using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDB
{
    class MemberClient : Client
    {
        private int MemberbeshipID;

        public MemberClient() : base() { }

        public MemberClient(string name, int value, int ID) : base(name, value)
        {
            setID(ID);
        }

        public void setID( int id )
        {
            MemberbeshipID = id;
        }

        public int MembershipID
        {
            get { return MemberbeshipID; }
            set { setID(MemberbeshipID); }
        }
    }
}

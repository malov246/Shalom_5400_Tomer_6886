using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Supplier
    {
        private int _supplierID;

        public int supplierID
        {
            get { return _supplierID; }
            set { _supplierID = value; }
        }

        private String _firstName;

        public String firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private String _lastName;

        public String lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private String _address;

        public String address
        {
            get { return _address; }
            set { _address = value; }
        }
    }
}

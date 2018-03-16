using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//testing
namespace test1
{
    class Customer
    {
        private int _customerID;

        public int customerID
        {
            get { return _customerID; }
            set { _customerID = value; }
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

        private int _kitchenID;

        public int kitchenID
        {
            get { return _kitchenID; }
            set { _kitchenID = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Kitchen
    {
        private int _kitchenID;

        public int kitchenID
        {
            get { return _kitchenID; }
            set { _kitchenID = value; }
        }

        private String _city;

        public String city
        {
            get { return _city; }
            set { _city = value; }
        }

        private String _street;

        public String street
        {
            get { return _street; }
            set { _street = value; }
        }

        private int _addrNum;

        public int addrNum
        {
            get { return _addrNum; }
            set { _addrNum = value; }
        }

        private int _supplierID;

        public int supplierID
        {
            get { return _supplierID; }
            set { _supplierID = value; }
        }
    }
}

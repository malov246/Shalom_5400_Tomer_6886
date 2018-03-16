using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Meal
    {
        private int _mealID;

        public int mealID
        {
            get { return _mealID; }
            set { _mealID = value; }
        }

        private String _mealTime;

        public String mealTime
        {
            get { return _mealTime; }
            set { _mealTime = value; }
        }

        private int _customerID;

        public int customerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }
    }
}

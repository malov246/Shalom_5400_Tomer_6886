using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Product
    {
        private int _productID;

        public int productID
        {
            get { return _productID; }
            set { _productID = value; }
        }

        private int _caloriesPerKilo;

        public int caloriesPerKilo
        {
            get { return _caloriesPerKilo; }
            set { _caloriesPerKilo = value; }
        }

        private String _name;

        public String name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _pricePerWeight;

        public int pricePerWeight
        {
            get { return _pricePerWeight; }
            set { _pricePerWeight = value; }
        }
    }
}

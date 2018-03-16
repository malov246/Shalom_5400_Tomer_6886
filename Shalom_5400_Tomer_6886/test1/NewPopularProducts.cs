using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace test1
{
    public partial class NewPopularProducts : Form
    {
        string query = "";
        OracleCommand cmd = new OracleCommand();
        public NewPopularProducts()
        {
            InitializeComponent();
            cmd.Connection = Connection.Conn;
            query = "select distinct p.productname,sum(mc.productweight)\nfrom product p\njoin mealcontent mc\non mc.productid = p.productid\njoin meal m\non mc.mealid = m.mealid\ngroup by p.productname";
            Connection.GetDataByQueryString(query, TableDataGridView);
            TableDataGridView.Columns[1].HeaderText = "sum weight";
            TableDataGridView.Columns[0].HeaderText = "Product Name";
        }
    }
}

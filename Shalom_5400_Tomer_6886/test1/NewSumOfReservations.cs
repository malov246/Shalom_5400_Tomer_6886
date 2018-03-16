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
    public partial class NewSumOfReservations : Form
    {
        string query = "";
        OracleCommand cmd = new OracleCommand();
        public NewSumOfReservations()
        {
            InitializeComponent();
            cmd.Connection = Connection.Conn;
            query = "select p.PRODUCTID, sum(o.ProductWeight) as TotalOrders from PRODUCT p join ORDERCONTENT o on p.productid=o.productid group by p.productid order by totalorders";
            Connection.GetDataByQueryString(query, TableDataGridView);
            TableDataGridView.Columns[0].HeaderText = "Product Number";
            TableDataGridView.Columns[1].HeaderText = "Total orders weight";
        }

        private void NewSumOfReservations_Load(object sender, EventArgs e)
        {

        }
    }
}

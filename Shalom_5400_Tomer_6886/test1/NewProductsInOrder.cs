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
    public partial class NewProductsInOrder : Form
    {
        string query = "";
        OracleCommand cmd = new OracleCommand();
        public NewProductsInOrder()
        {
            InitializeComponent();
            cmd.Connection = Connection.Conn;
        }

        private void NewProductsInReservation_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(detailsCheckBox.Checked))
                {
                    query = "select sp.orderid,p.productid,p.productname\nfrom supplyorder sp\njoin ordercontent oc\non oc.orderid=sp.orderid\njoin product p\non p.productid=oc.productid\nwhere sp.orderid=";
                    query += OrderIdNumericUpDown.Value.ToString();
                    Connection.GetDataByQueryString(query, TableDataGridView);
                    TableDataGridView.Columns[1].HeaderText = "Product Number";
                    TableDataGridView.Columns[2].HeaderText = "Product Name";
                    TableDataGridView.Columns[0].HeaderText = "order number";
                }
                else
                {
                    query = "select sp.*,p.*\nfrom supplyorder sp\njoin ordercontent oc\non oc.orderid=sp.orderid\njoin product p\non p.productid=oc.productid\nwhere sp.orderid=";
                    query += OrderIdNumericUpDown.Value.ToString();
                    Connection.GetDataByQueryString(query, TableDataGridView);
                }
                
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }
    }
}

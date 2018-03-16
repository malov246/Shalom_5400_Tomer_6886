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
    public partial class NewHealthyProducts : Form
    {
        string query = "";
        OracleCommand cmd = new OracleCommand();
        public NewHealthyProducts()
        {
            InitializeComponent();
            cmd.Connection = Connection.Conn;
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select p.*\nfrom product p\nwhere p.caloriesperkilo <=";
                query += CalorieNumericUpDown.Value.ToString();
                Connection.GetDataByQueryString(query, TableDataGridView);
                TableDataGridView.Columns[0].HeaderText = "Product Number";
                TableDataGridView.Columns[1].HeaderText = "Product Name";
                TableDataGridView.Columns[2].HeaderText = "Calories Value(c per kilo)";
                TableDataGridView.Columns[3].HeaderText = "Price (per weight)";
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }
    }
}

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
    public partial class NewDataTables : Form
    {
        string table = "";
        int lastRowsCount = -1;
        OracleCommand cmd = new OracleCommand();
        public NewDataTables()
        {
            InitializeComponent();
            DataSelectionComboBox.Items.Add("Customer");
            DataSelectionComboBox.Items.Add("Meal");
            DataSelectionComboBox.Items.Add("Product");
            DataSelectionComboBox.Items.Add("Kitchen");
            DataSelectionComboBox.Items.Add("Supplier");
            DataSelectionComboBox.Items.Add("Meal Content");
            DataSelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cmd.Connection = Connection.Conn;
        }

        private void DataSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (DataSelectionComboBox.SelectedIndex)
                {
                    case 0:
                        table = "Customer";
                        break;
                    case 1:
                        table = "Meal";
                        break;
                    case 2:
                        table = "Product";
                        break;
                    case 3:
                        table = "Kithcen";
                        break;
                    case 4:
                        table = "Supplier";
                        break;
                    case 5:
                        table = "MEALCONTENT";
                        break;
                }

                if (table == "")
                    TableDataGridView.DataSource = null;
                else
                    Connection.GetDataByQueryString("select * from " + table, TableDataGridView);
                lastRowsCount = TableDataGridView.Rows.Count;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }

        private void DataTables_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

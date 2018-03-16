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
    public partial class NewDeleteData : Form
    {
        OracleCommand cmd = new OracleCommand();
        public NewDeleteData()
        {
            InitializeComponent();
            DataSelectionComboBox.Items.Add("Customer");
            DataSelectionComboBox.Items.Add("Meal");
            DataSelectionComboBox.Items.Add("Product");
            DataSelectionComboBox.Items.Add("Kitchen");
            DataSelectionComboBox.Items.Add("Supplier");
            DataSelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cmd.Connection = Connection.Conn;
            if (!(Connection.Conn.State == ConnectionState.Open))
            {
                Connection.Conn.Open();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string commandString = "";
                /*DELETE FROM table_name
                WHERE some_column=some_value;*/
                commandString += "DELETE FROM ";
                switch (DataSelectionComboBox.SelectedIndex)
                {
                    case 0:
                        commandString += "Customer";
                        break;
                    case 1:
                        commandString += "Meal";
                        break;
                    case 2:
                        commandString += "Product";
                        break;
                    case 3:
                        commandString += "Kithcen";
                        break;
                    case 4:
                        commandString += "Supplier";
                        break;
                }
                commandString += " Where ";
                switch (DataSelectionComboBox.SelectedIndex)
                {
                    case 0:
                        commandString += "Customerid";
                        break;
                    case 1:
                        commandString += "Mealid";
                        break;
                    case 2:
                        commandString += "Productid";
                        break;
                    case 3:
                        commandString += "Kitchenid";
                        break;
                    case 4:
                        commandString += "Supplierid";
                        break;
                }
                commandString += "=";
                commandString += IDNumericUpDown.Value.ToString();
                cmd.CommandText = commandString;
                cmd.ExecuteNonQuery();
                commandString = "commit";
                cmd.CommandText = commandString;
                cmd.ExecuteNonQuery();


                string msg = "";
                msg += DataSelectionComboBox.Text;
                msg += " number " + IDNumericUpDown.Value + " was deleted succesfully.";
                MessageBox.Show(msg);
                this.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }
    }
}

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
    public partial class ChangeSupplier : Form
    {
        public int type { get; set; }
        OracleCommand cmd = new OracleCommand();
                                /// <summary>
        /// 
        /// </summary>
        /// <param name="type">type=0 :insert
        ///type=1 :Update
       /// type=2 :Delete</param>
        /// <param name="id"></param>
        public ChangeSupplier(int atype = 0, int id = 0)
        {
            type = atype;
            InitializeComponent();
            if (type == 1||type==2)
            {
                supplierIDNumericUpDown.Value = id;
                supplierIDNumericUpDown.Enabled = false;
            }
            this.AcceptButton = SaveButton;
            cmd.Connection = Connection.Conn;
            if (!(Connection.Conn.State == ConnectionState.Open))
            {
                Connection.Conn.Open();
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string commandString = "";
                switch (type)
                {
                    case 0:
                        //INSERT INTO table_name (column1,column2,column3,...)
                        //VALUES (value1,value2,value3,...);
                        commandString += "INSERT INTO SUPPLIER (SUPPLIERID, FIRSTNAME, LASTNAME, ADRESS) values(";
                        commandString += supplierIDNumericUpDown.Value.ToString();
                        commandString += ",";
                        commandString += "'";
                        commandString += firstNameTextBox.Text;
                        commandString += "'";
                        commandString += ",";
                        commandString += "'";
                        commandString += lastNameTextBox.Text;
                        commandString += "'";
                        commandString += ",";
                        commandString += "'";
                        commandString += addressTextBox.Text;
                        commandString += "'";
                        commandString += ")";
                        //commandString += " commit";
                        cmd.CommandText = commandString;
                        cmd.ExecuteNonQuery();
                        commandString = "commit";
                        cmd.CommandText = commandString;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer added succenfully");
                        this.Close();
                        break;
                    case 1:
                        //update CUSTOMER set FirstName='Aviel',LastName='Baryo',Kitchenid=100,Kitchenid1=1 where customerid=15
                        commandString += "update SUPPLIER set ";
                        commandString += "FirstName=";
                        commandString += "'";
                        commandString += firstNameTextBox.Text;
                        commandString += "'";
                        commandString += ",";
                        commandString += "lastName=";
                        commandString += "'";
                        commandString += lastNameTextBox.Text;
                        commandString += "'";
                        commandString += ",";
                        commandString += "ADRESS=";
                        commandString += "'";
                        commandString += addressTextBox.Text;
                        commandString += "'";
                        commandString += "where SUPPLIERID=";
                        commandString += supplierIDNumericUpDown.Value.ToString();
                        //commandString += " commit";
                        cmd.CommandText = commandString;
                        cmd.ExecuteNonQuery();
                        commandString = "commit";
                        cmd.CommandText = commandString;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer updated succenfully");
                        this.Close();
                        break;
                    default:
                        throw new Exception("ERROR");
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }
        private void ChangeSupplier_Load(object sender, EventArgs e)
        {

        }
    }
}

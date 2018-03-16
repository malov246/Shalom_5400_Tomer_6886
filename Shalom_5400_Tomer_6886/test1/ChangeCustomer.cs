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
    public partial class ChangeCustomer : Form
    {
        public int type { get; set; }
        OracleCommand cmd = new OracleCommand();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type">type=0 :insert
        ///type=1 :Update</param>
        /// <param name="id"></param>
        public ChangeCustomer(int atype = 0, int id = 0)
        {
            type = atype;
            InitializeComponent();
            if (type == 1)
            {
                customerIDNumericUpDown.Value = id;
                customerIDNumericUpDown.Enabled = false;
            }
            this.AcceptButton = SaveButton;
            cmd.Connection = Connection.Conn;
            if (!(Connection.Conn.State == ConnectionState.Open))
            {
                Connection.Conn.Open();
            }
        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

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
                        commandString += "INSERT INTO CUSTOMER (customerid,FirstName,LastName,Kitchenid,Kitchenid1) VALUES (";
                        commandString += customerIDNumericUpDown.Value.ToString();
                        commandString += ",";
                        commandString += "'";
                        commandString += firstNameTextBox.Text;
                        commandString += "'";
                        commandString += ",";
                        commandString += "'";
                        commandString += lastNameTextBox.Text;
                        commandString += "'";
                        commandString += ",";
                        commandString += kitchenIDNumericUpDown.Value.ToString();
                        commandString += ",";
                        commandString += kitchenIDNumericUpDown.Value.ToString();
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
                        commandString += "update CUSTOMER set ";
                        commandString += "FirstName=";
                        commandString += "'";
                        commandString += firstNameTextBox.Text;
                        commandString += "'";
                        commandString += ",";
                        commandString += "LastName=";
                        commandString += "'";
                        commandString += lastNameTextBox.Text;
                        commandString += "'";
                        commandString += ",";
                        commandString += "Kitchenid=";
                        commandString += kitchenIDNumericUpDown.Value.ToString();
                        commandString += ",Kitchenid1=1 ";
                        commandString += "where customerid=";
                        commandString += customerIDNumericUpDown.Value.ToString();
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

        private void ChangeCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}

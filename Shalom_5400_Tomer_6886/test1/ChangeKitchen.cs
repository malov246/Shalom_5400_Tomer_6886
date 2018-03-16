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
    public partial class ChangeKitchen : Form
    {
        public int type { get; set; }
        OracleCommand cmd = new OracleCommand();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type">type=0 :insert
        ///type=1 :Update</param>
        /// <param name="id"></param>
        public ChangeKitchen(int atype = 0, int id = 0)
        {
            type = atype;
            InitializeComponent();
            if (type == 1)
            {
                kitchenIDNumericUpDown.Value = id;
                kitchenIDNumericUpDown.Enabled = false;
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
                        commandString += "INSERT INTO kithcen (kitchenid,city,street,addrnumber,supplierid) VALUES (";
                        commandString += kitchenIDNumericUpDown.Value.ToString();
                        commandString += ",";
                        commandString += "'";
                        commandString += cityTextBox.Text;
                        commandString += "'";
                        commandString += ",";
                        commandString += "'";
                        commandString += streetTextBox.Text;
                        commandString += "'";
                        commandString += ",";
                        commandString += addrNumNumericUpDown.Value.ToString();
                        commandString += ",";
                        commandString += supplierIDNumericUpDown.Value.ToString();
                        commandString += ")";
                        //commandString += " commit";
                        cmd.CommandText = commandString;
                        cmd.ExecuteNonQuery();
                        commandString = "commit";
                        cmd.CommandText = commandString;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kitchen added succenfully");
                        this.Close();
                        break;
                    case 1:
                        //update CUSTOMER set FirstName='Aviel',LastName='Baryo',Kitchenid=100,Kitchenid1=1 where customerid=15
                        commandString += "update kithcen set ";
                        commandString += "city=";
                        commandString += "'";
                        commandString += cityTextBox.Text;
                        commandString += "'";
                        commandString += ",";
                        commandString += "street=";
                        commandString += "'";
                        commandString += streetTextBox.Text;
                        commandString += "'";
                        commandString += ",";
                        commandString += "addrnumber=";
                        commandString += addrNumNumericUpDown.Value.ToString();
                        commandString += ",";
                        commandString += "supplierid=";
                        commandString += supplierIDNumericUpDown.Value.ToString();
                        commandString += " where kitchenid=";
                        commandString += kitchenIDNumericUpDown.Value.ToString();
                        //commandString += " commit";
                        cmd.CommandText = commandString;
                        cmd.ExecuteNonQuery();
                        commandString = "commit";
                        cmd.CommandText = commandString;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("kitchen updated succenfully");
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
    }
}

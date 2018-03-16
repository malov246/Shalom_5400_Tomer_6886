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
    public partial class ChangeProduct : Form
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
        public ChangeProduct(int atype = 0, int id = 0)
        {
            type = atype;
            InitializeComponent();
            if (type == 1||type==2)
            {
                productIDNumericUpDown.Value = id;
                productIDNumericUpDown.Enabled = false;
            }
            this.AcceptButton = SaveButton;
            cmd.Connection = Connection.Conn;
            if (!(Connection.Conn.State == ConnectionState.Open))
            {
                Connection.Conn.Open();
            }
        }

        private void productIDNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string commandString = "";
                switch (type)
                {
                    case 0:
                        //INSERT INTO table_name (column1,column2,column3,...)
                        //VALUES (value1,value2,value3,...);
                        commandString += "INSERT INTO PRODUCT (PRODUCTID, PRODUCTNAME, CALORIESPERKILO, PRICEPERWEIGHT) values(";
                        commandString += productIDNumericUpDown.Value.ToString();
                        commandString += ",";                        
                        commandString += "'";
                        commandString += nameTextBox.Text;
                        commandString += "'";
                        commandString += ",";
                        commandString += caloriesPerKiloNumericUpDown.Value.ToString();
                        commandString += ",";
                        commandString += pricePerWeightNumericUpDown.Value.ToString();
                        commandString += ")";
                        //commandString += " commit";
                        cmd.CommandText = commandString;
                        cmd.ExecuteNonQuery();
                        commandString = "commit";
                        cmd.CommandText = commandString;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("product added succenfully");
                        this.Close();
                        break;
                    case 1:
                        //update CUSTOMER set FirstName='Aviel',LastName='Baryo',Kitchenid=100,Kitchenid1=1 where customerid=15
                        commandString += "update product set ";
                        commandString += "CALORIESPERKILO=";
                        commandString += caloriesPerKiloNumericUpDown.Value.ToString();
                        commandString += ",";
                        commandString += "PRODUCTNAME=";
                        commandString += "'";
                        commandString += nameTextBox.Text;
                        commandString += "'";
                        commandString += ",";
                        commandString += "PRICEPERWEIGHT=";
                        commandString += pricePerWeightNumericUpDown.Value.ToString();
                        commandString += " where PRODUCTID=";
                        commandString += productIDNumericUpDown.Value.ToString();
                        //commandString += " commit";
                        cmd.CommandText = commandString;
                        cmd.ExecuteNonQuery();
                        commandString = "commit";
                        cmd.CommandText = commandString;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("product updated succenfully");
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

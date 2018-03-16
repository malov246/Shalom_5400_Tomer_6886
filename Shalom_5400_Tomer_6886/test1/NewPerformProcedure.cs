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
    public partial class NewPerformProcedure : Form
    {
        OracleCommand cmd = new OracleCommand();
        public NewPerformProcedure()
        {
            InitializeComponent();
            if (!(Connection.Conn.State == ConnectionState.Open))
            {
                Connection.Conn.Open();
            }
            cmd.Connection = Connection.Conn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "shrink_order";
                //meal_id in integer, factor in integer
                cmd.Parameters.Add("meal_id",OracleType.Number);
                cmd.Parameters.Add("factor", OracleType.Number);
                cmd.Parameters["meal_id"].Direction = ParameterDirection.Input;
                cmd.Parameters["factor"].Direction = ParameterDirection.Input;
                cmd.Parameters["factor"].Value = FactorNumericUpDown.Value;
                for (int i = 1737; i < 1756; i++)
                {
                    cmd.Parameters["meal_id"].Value = i;
                    cmd.ExecuteNonQuery();
                }
                
                MessageBox.Show("succeed");
            }
            catch (Exception msg)
            {

                MessageBox.Show(msg.Message);
            }
        }
    }
}

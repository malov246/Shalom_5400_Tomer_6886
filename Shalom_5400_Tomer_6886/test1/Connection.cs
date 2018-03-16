using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;
using System.Windows.Forms;

namespace test1
{
    public class Connection
    {
        private static OracleConnection conn;
        private Connection() { }
        public static OracleConnection Conn
        {
            get
            {
                if (conn == null)
                {
                    OracleConnectionStringBuilder myCStringB = new OracleConnectionStringBuilder();
                    myCStringB.UserID = "SHATOM";
                    myCStringB.Password = "123";
                    myCStringB.DataSource = "XE";
                    conn = new OracleConnection(myCStringB.ConnectionString);
                    conn.Open();
                }
                return conn;
            }
        }
        public static void GetDataByQueryString(string strQueryString, DataGridView dgv)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = new OracleCommand();
            DataTable dt = new DataTable();

            da.SelectCommand.Connection = conn;
            da.SelectCommand.CommandText = strQueryString;
            da.Fill(dt);
            dgv.DataSource = dt;
            conn.Close();
        }
    }
}

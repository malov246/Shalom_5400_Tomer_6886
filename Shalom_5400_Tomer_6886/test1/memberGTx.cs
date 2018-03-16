using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class memberGTx : Form
    {
        public memberGTx()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.GetDataByQueryString("SELECT m.* FROM MEMBER m WHERE (SYSDATE-to_date(m.date_of_birth))/365> " + textBox1.Text, dataGridView1);
        }
    }
}

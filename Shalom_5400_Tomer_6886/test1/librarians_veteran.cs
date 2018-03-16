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
    public partial class librarians_veteran : Form
    {
        public librarians_veteran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.GetDataByQueryString("select first_name,last_name,id from librarian where librarian.seniority >= " + textBox1.Text + " order by id", dataGridView1);
        }
    }
}

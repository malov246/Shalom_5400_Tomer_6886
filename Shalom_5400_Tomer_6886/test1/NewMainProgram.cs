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
    public partial class NewMainProgram : Form
    {
        public NewMainProgram()
        {
            InitializeComponent();
            if (!(Connection.Conn.State==ConnectionState.Open))
            {
                Connection.Conn.Open();
            }
        }

        private void ShowDataTablesButton_Click(object sender, EventArgs e)
        {
            NewDataTables dt = new NewDataTables();
            dt.ShowDialog();
        }

        private void InsertDataButton_Click(object sender, EventArgs e)
        {
            NewInsertMenu ins = new NewInsertMenu();
            ins.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void UpdateDataButton_Click(object sender, EventArgs e)
        {
            NewUpdateMenu updt = new NewUpdateMenu();
            updt.ShowDialog();
        }

        private void DeleteDataButton_Click(object sender, EventArgs e)
        {
            NewDeleteData del = new NewDeleteData();
            del.ShowDialog();
        }

        private void QuerysButton_Click(object sender, EventArgs e)
        {
            NewProductsQueries que = new NewProductsQueries();
            que.ShowDialog();
        }

        private void ProcedureBtton_Click(object sender, EventArgs e)
        {
            NewPerformProcedure per = new NewPerformProcedure();
            per.ShowDialog();
        }

        private void NewMainProgram_Load(object sender, EventArgs e)
        {

        }
    }
}

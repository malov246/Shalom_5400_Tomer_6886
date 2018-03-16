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
    public partial class DataSource_Form : Form
    {
        public DataSource_Form()
        {
            InitializeComponent();
        }

        private void DataSource_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Lecture' table. You can move, or remove it, as needed.
            this.lectureTableAdapter.FillLecture2(this.dataSet1.Lecture);
            // TODO: This line of code loads data into the 'dataSet11.DataTable2' table. You can move, or remove it, as needed.
        //    this.dataTable2TableAdapter.FillLecture2(this.dataSet11.DataTable2);
            // TODO: This line of code loads data into the 'dataSet1.DEPARTMENTS' table. You can move, or remove it, as needed.
       //     this.dEPARTMENTSTableAdapter.Fill(this.dataSet1.DEPARTMENTS);

        }

        private void dEPARTMENTSBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
   //             this.dEPARTMENTSTableAdapter.FillBy(this.dataSet1.DEPARTMENTS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByLocation1700ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
         //       this.dEPARTMENTSTableAdapter.FillByLocation1700(this.dataSet1.DEPARTMENTS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

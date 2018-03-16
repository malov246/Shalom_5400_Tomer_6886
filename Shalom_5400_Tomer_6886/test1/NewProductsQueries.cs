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
    public partial class NewProductsQueries : Form
    {
        public NewProductsQueries()
        {
            InitializeComponent();
        }

        private void ProductsQueries_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewSumOfReservations q = new NewSumOfReservations();
            q.ShowDialog();
        }

        private void Query1Button_Click(object sender, EventArgs e)
        {
            NewProductsInOrder q = new NewProductsInOrder();
            q.ShowDialog();
        }

        private void HealthyProductsButton_Click(object sender, EventArgs e)
        {
            NewHealthyProducts q = new NewHealthyProducts();
            q.ShowDialog();
        }

        private void PopularProductsButton_Click(object sender, EventArgs e)
        {
            NewPopularProducts q = new NewPopularProducts();
            q.ShowDialog();
        }
    }
}

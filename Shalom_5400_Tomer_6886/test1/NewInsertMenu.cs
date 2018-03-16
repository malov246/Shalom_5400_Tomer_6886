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
    public partial class NewInsertMenu : Form
    {
        public NewInsertMenu()
        {
            InitializeComponent();
            DataSelectionComboBox.Items.Add("Customer");
            DataSelectionComboBox.Items.Add("Meal");
            DataSelectionComboBox.Items.Add("Kitchen");
            DataSelectionComboBox.Items.Add("Product"); 
            DataSelectionComboBox.Items.Add("Supplier");
            DataSelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (DataSelectionComboBox.Text)
                {
                    case "Customer":
                        ChangeCustomer cusForm = new ChangeCustomer(0);
                        cusForm.ShowDialog();
                        break;
                    case "Meal":
                        ChangeMeal mealForm = new ChangeMeal(0);
                        mealForm.ShowDialog();
                        break;
                    case "Product":
                        ChangeProduct prodForm = new ChangeProduct(0);
                        prodForm.ShowDialog();
                        break;
                    case "Kitchen":
                        ChangeKitchen kitForm = new ChangeKitchen(0);
                        kitForm.ShowDialog();
                        break;
                    case "Supplier":
                        ChangeSupplier supForm = new ChangeSupplier(0);
                        supForm.ShowDialog();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }
    }
}

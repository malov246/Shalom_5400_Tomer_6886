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
    public partial class NewUpdateMenu : Form
    {
        public NewUpdateMenu()
        {
            InitializeComponent();
            DataSelectionComboBox.Items.Add("Customer");
            DataSelectionComboBox.Items.Add("Meal");
            DataSelectionComboBox.Items.Add("Kitchen");
            DataSelectionComboBox.Items.Add("Product");
            DataSelectionComboBox.Items.Add("Supplier");
            DataSelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (DataSelectionComboBox.Text)
                {
                    case "Customer":
                        ChangeCustomer cusForm = new ChangeCustomer(1, (int)IDNumericUpDown.Value);
                        cusForm.ShowDialog();
                        break;
                    case "Meal":
                        ChangeMeal mealForm = new ChangeMeal(1,(int)IDNumericUpDown.Value);
                        mealForm.ShowDialog();
                        break;
                    case "Product":
                        ChangeProduct prodForm = new ChangeProduct(1, (int)IDNumericUpDown.Value);
                        prodForm.ShowDialog();
                        break;
                    case "Kitchen":
                        ChangeKitchen kitForm = new ChangeKitchen(1, (int)IDNumericUpDown.Value);
                        kitForm.ShowDialog();
                        break;
                    case "Supplier":
                        ChangeSupplier supForm = new ChangeSupplier(1, (int)IDNumericUpDown.Value);
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

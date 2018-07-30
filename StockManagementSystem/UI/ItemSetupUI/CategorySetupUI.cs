using StockManagementSystem.BLL;
using StockManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.UI.ItemSetup
{
    public partial class CategorySetupUI : Form
    {
        CategoryManager _manager = new CategoryManager();
        public CategorySetupUI()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Category category = new Category();
                category.Name = nameTextBox.Text;
                if (category.Name == String.Empty || category.Name.Length < 2)
                {
                    errorProvider.SetError(nameTextBox, "Please provide a valid category!");
                }

                bool isAdded = _manager.Add(category);
                if (isAdded)
                {
                    DataTable dataTable = _manager.GetCategories();
                    categoryDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Error Occured While Saving!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.BLL;
using StockManagementSystem.Models;

namespace StockManagementSystem.UI.ItemSetup
{
    public partial class ItemSetupUI : Form
    {
        ItemManager _manager = new ItemManager();
        public ItemSetupUI()
        {
            InitializeComponent();
            PopulateCompanies(new List<Company>());
            PopulateCategories(new List<Category>());
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item();
                item.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
                item.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);
                item.Name = itemNameTextBox.Text;
                item.ReOrderLevel = Convert.ToInt32(reOrderLevelTextBox.Text);

                bool isAdded = _manager.Add(item);
                if (isAdded)
                {
                    Reset(this.Controls);
                    itemNameTextBox.Focus();
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

        private void Reset(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                    tb.Text = "";
                else
                    Reset(ctrl.Controls);
            }
        }

        private void PopulateCategories(List<Category> categories )
        {
            categoryComboBox.Items.Clear();
            List<Category> categoriesAre = _manager.GetCategories(categories);
            categoryComboBox.DataSource = categoriesAre;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "Id";

        }

        private void PopulateCompanies(List<Company> companies)
        {
            companyComboBox.Items.Clear();
            List<Company> companiesAre = _manager.GetCompanies(companies);
            companyComboBox.DataSource = companiesAre;
            companyComboBox.DisplayMember = "Name";
            companyComboBox.ValueMember = "Id";
        }
    }
}

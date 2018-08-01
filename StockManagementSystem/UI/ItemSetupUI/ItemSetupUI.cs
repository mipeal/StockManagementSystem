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
using StockManagementSystem.UI.InventoryUI;

namespace StockManagementSystem.UI.ItemSetup
{
    public partial class ItemSetupUI : Form
    {
        ItemManager _itemManager = new ItemManager();
        CompanyManager _companyManager = new CompanyManager();
        CategoryManager _categoryManager = new CategoryManager();

        public ItemSetupUI()
        {
            InitializeComponent();
            PopulateCompanies();
            PopulateCategories();
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

                bool isAdded = _itemManager.Add(item);
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


        private void PopulateCategories()
        {
            DataTable dt = new DataTable();
            dt = _categoryManager.GetCategories();
            categoryComboBox.ValueMember = "Id";
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.DataSource = dt;

        }

        private void PopulateCompanies()
        {
            DataTable dt = new DataTable();
            dt = _companyManager.GetCompanies();
            companyComboBox.ValueMember = "Id";
            companyComboBox.DisplayMember = "Name";
            companyComboBox.DataSource = dt;
        }

        #region MenuBar
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            this.Hide();
        }
        private void addCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanySetupUI companySetup = new CompanySetupUI();
            companySetup.Show();
            this.Hide();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategorySetupUI categorySetup = new CategorySetupUI();
            categorySetup.Show();
            this.Hide();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemSetupUI itemSetup = new ItemSetupUI();
            itemSetup.Show();
            this.Hide();
        }

        private void stockInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockInUI stockIn = new StockInUI();
            stockIn.Show();
            this.Hide();
        }

        private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockOutUI stockOut = new StockOutUI();
            stockOut.Show();
            this.Hide();
        }

        private void itemSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemSummaryUI itemSummary = new ItemSummaryUI();
            itemSummary.Show();
            this.Hide();
        }

        private void salesSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSalesByDates viewSales = new ViewSalesByDates();
            viewSales.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure!", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Index index = new Index();
                index.Show();
            }
        }
        #endregion

        private void ItemSetupUI_FormClosing(object sender, FormClosingEventArgs e)
        {

            var window = MessageBox.Show("Close the window?", "Are you sure?", MessageBoxButtons.YesNo);

            e.Cancel = (window == DialogResult.No);
            Index index = new Index();
            index.Show();
        }

    }
}

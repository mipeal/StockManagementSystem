using StockManagementSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Models;
using StockManagementSystem.UI.ItemSetup;

namespace StockManagementSystem.UI.InventoryUI
{
    public partial class ItemSummaryUI : Form
    {
        CompanyManager _companyManager = new CompanyManager();
        CategoryManager _categoryManager = new CategoryManager();
        InventoryManager _inventoryManager = new InventoryManager();
        DataTable _dataTable = new DataTable();
        public ItemSummaryUI()
        {
            InitializeComponent();
        }




        private void PopulateCategories()
        {
            categoryComboBox.Text = "Select Category";
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

        private void SearchButton_Click(object sender, EventArgs e)
        {

            try
            {

                #region Search Code
                int categoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
                int companyId = Convert.ToInt32(companyComboBox.SelectedValue);
                #endregion

                _dataTable = _inventoryManager.SearchItemsSummary(categoryId,companyId);

                if (_dataTable.Rows.Count>0)
                {
                    itemSummaryDataGridView.DataSource = _dataTable;
                }
                else
                {
                    MessageBox.Show("Sorry, No Items Found!!");
                }

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void categoryComboBox_Click(object sender, EventArgs e)
        {
            PopulateCategories();
        }

        private void companyComboBox_Click(object sender, EventArgs e)
        {
            PopulateCompanies();
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

        private void ItemSummaryUI_FormClosing(object sender, FormClosingEventArgs e)
        {

            var window = MessageBox.Show("Close the window?", "Are you sure?", MessageBoxButtons.YesNo);

            e.Cancel = (window == DialogResult.No);
            Index index = new Index();
            index.Show();
        }

    }
}

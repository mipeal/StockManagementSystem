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
    }
}

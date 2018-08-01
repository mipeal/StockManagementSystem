using StockManagementSystem.BLL;
using StockManagementSystem.Models;
using StockManagementSystem.Models.InventoryModels;
using StockManagementSystem.UI.ItemSetup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.UI.InventoryUI
{
    public partial class StockInUI : Form
    {
        CompanyManager _companyManager = new CompanyManager();
        CategoryManager _categoryManager = new CategoryManager();
        ItemManager _itemManager = new ItemManager();
        InventoryManager _inventoryManager = new InventoryManager();
        Item _item = new Item();
        
        public StockInUI()
        {
            InitializeComponent();
            PopulateCompanies();
            PopulateCategories();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory stockIn = new Inventory();
                stockIn.ItemId = Convert.ToInt32(itemNameComboBox.SelectedValue.ToString());
                if (stockIn.ItemId <= 0)
                {
                    errorProvider.SetError(itemNameComboBox, "Please Select a Item!");
                }
                stockIn.StockAvailable = Convert.ToInt32(availableQuantityLabel.Text) + Convert.ToInt32(stockInTextBox.Text);

                stockIn.StockTransaction = Convert.ToInt32(stockInTextBox.Text);
                if (stockIn.ItemId <= 0)
                {
                    errorProvider.SetError(itemNameComboBox, "Please input valid transaction value!");
                }
                stockIn.StockType = (int)StockTypes.In;

                bool isAdded = _inventoryManager.Add(stockIn);
                if (isAdded)
                {
                    MessageBox.Show("Stock Updated!");
                    Reset(this.Controls);
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

        #region Selcted Index Changed

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _item.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue.ToString());
            if (_item.CompanyId > 0)
            {
                PopulateItems(_item.CategoryId, _item.CompanyId);

            }
            else
            {
                MessageBox.Show("Please Select Company!");
            }

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _item.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue.ToString());
            if (_item.CategoryId > 0)
            {
                PopulateItems(_item.CategoryId, _item.CompanyId);
            }
            else
            {
                MessageBox.Show("Please Select Category!");
            }
        }

        private void itemNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _item.Id = Convert.ToInt32(itemNameComboBox.SelectedValue.ToString());
            if (_item.Id > 0)
            {
                DataTable dt = new DataTable();
                dt = _itemManager.GetItems(_item.CategoryId, _item.CompanyId);
                if (dt.Rows.Count > 0)
                {
                    reOrderLevelLabel.Text = Convert.ToString(dt.Rows[0].Field<int>("ReOrderLevel"));
                }
                PopulateItemInfo(_item.Id);
            }
            else
            {
                MessageBox.Show("Please Select Category!");
            }
        } 
        #endregion

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


        #region Populating Controls

        private void PopulateItems(int categoryId, int companyId)
        {
            DataTable dt = new DataTable();
            dt = _itemManager.GetItems(_item.CategoryId, _item.CompanyId);

            if (dt != null)
            {
                itemNameComboBox.ValueMember = "Id";
                itemNameComboBox.DisplayMember = "Name";
                itemNameComboBox.DataSource = dt;
            }
            else
            {
                itemNameComboBox.Items.Clear();
            }
        }
        private void PopulateItemInfo(int itemId)
        {
            DataSet ds = new DataSet();
            ds = _inventoryManager.GetItemInventory(itemId);
            if (ds.Tables[0].Rows.Count > 0)
            {
                availableQuantityLabel.Text = Convert.ToString(ds.Tables[0].Rows[0].Field<int>("StockAvailable"));
            }
            else
            {
                availableQuantityLabel.Text = "0";
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
        #endregion

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

        private void StockInUI_FormClosing(object sender, FormClosingEventArgs e)
        {

            var window = MessageBox.Show("Close the window?", "Are you sure?", MessageBoxButtons.YesNo);

            e.Cancel = (window == DialogResult.No);
            Index index = new Index();
            index.Show();
        }

    }
}

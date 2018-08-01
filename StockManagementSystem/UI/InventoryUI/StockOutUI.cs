using StockManagementSystem.BLL;
using StockManagementSystem.Models.InventoryModels;
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

namespace StockManagementSystem.UI.InventoryUI
{
    public partial class StockOutUI : Form
    {
        CompanyManager _companyManager = new CompanyManager();
        CategoryManager _categoryManager = new CategoryManager();
        ItemManager _itemManager = new ItemManager();
        InventoryManager _inventoryManager = new InventoryManager();
        Item _item = new Item();
        List<Inventory> _stockOutList = new List<Inventory>();


        public StockOutUI()
        {
            InitializeComponent();
            PopulateCompanies();
            PopulateCategories();
        }
        

        private void SellButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in _stockOutList)
                {
                    item.StockOutType = (int)StockOutTypes.Sell;
                }
                int isAdded = _inventoryManager.Add(_stockOutList);
                if (isAdded > 0)
                {
                    MessageBox.Show(isAdded + " Transaction for Stock-Out Added!");
                    stockOutDataGridView.Rows.Clear();
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
        private void DamageButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in _stockOutList)
                {
                    item.StockOutType = (int)StockOutTypes.Damage;
                }
                int isAdded = _inventoryManager.Add(_stockOutList);
                if (isAdded > 0)
                {
                    MessageBox.Show(isAdded + " Transaction for Stock-Out Added!");
                    stockOutDataGridView.Rows.Clear();
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
        private void LostButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in _stockOutList)
                {
                    item.StockOutType = (int)StockOutTypes.Lost;
                }
                int isAdded = _inventoryManager.Add(_stockOutList);
                if (isAdded > 0)
                {
                    MessageBox.Show(isAdded + " Transaction for Stock-Out Added!");
                    stockOutDataGridView.Rows.Clear();
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory stockOut = new Inventory();
                stockOut.ItemId = Convert.ToInt32(itemNameComboBox.SelectedValue.ToString());
                if (stockOut.ItemId <= 0)
                {
                    errorProvider.SetError(itemNameComboBox, "Please Select a Item!");
                    return;
                }
                stockOut.CategoryName = categoryComboBox.Text;
                if (stockOut.CategoryName==String.Empty)
                {
                    errorProvider.SetError(categoryComboBox, "Please Select a Category!");
                    return;
                }
                stockOut.CompanyName = companyComboBox.Text;
                if (stockOut.CompanyName == String.Empty)
                {
                    errorProvider.SetError(companyComboBox, "Please Select a Company!");
                    return;
                }
                stockOut.ItemName = itemNameComboBox.Text;
                if (stockOut.ItemName == String.Empty)
                {
                    errorProvider.SetError(itemNameComboBox, "Please Select a Item!");
                    return;
                }

                stockOut.StockAvailable = Convert.ToInt32(availableQuantityLabel.Text) - Convert.ToInt32(stockOutTextBox.Text);

                if (stockOut.StockAvailable <= 0)
                {
                    errorProvider.SetError(availableQuantityLabel, "There's not enough stock available, Please re-order!");
                    return;
                }

                stockOut.StockTransaction = Convert.ToInt32(stockOutTextBox.Text);
                if (stockOut.StockTransaction <= 0)
                {
                    errorProvider.SetError(stockOutTextBox, "Please input valid transaction value!");
                    return;
                }
                stockOut.StockType = (int)StockTypes.Out;

                _stockOutList.Add(stockOut);
                stockOutDataGridView.Rows.Clear();
                foreach (var item in _stockOutList)
                {
                    stockOutDataGridView.Rows.Add(item.ItemName,item.StockTransaction,item.StockAvailable,item.CompanyName,item.CategoryName,item.TransactionDate);
                }
                //stockOutDataGridView.DataSource = stockOutList.ToList();
                availableQuantityLabel.Text = (Convert.ToInt32(availableQuantityLabel.Text) - Convert.ToInt32(stockOutTextBox.Text)).ToString();
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

    }
}

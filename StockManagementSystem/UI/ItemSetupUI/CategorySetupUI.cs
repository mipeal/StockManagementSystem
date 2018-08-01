using StockManagementSystem.BLL;
using StockManagementSystem.Models;
using StockManagementSystem.UI.InventoryUI;
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
        private DataTable _dataTable;
        CategoryManager _manager = new CategoryManager();
        Category _category;

        public CategorySetupUI()
        {
            InitializeComponent();
            if (_category == null)
            {
                UpdateButton.Visible = false;
                _category = new Category();
            }
            else
            {
                SaveButton.Visible = false;
            }
            _dataTable = _manager.GetCategories(); for (int i = 0; i < _dataTable.Rows.Count; i++)
            {
                categoryDataGridView.Rows.Add(_dataTable.Rows[i].Field<int>("Id"), _dataTable.Rows[i].Field<string>("Name"));
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                    _category.Name = nameTextBox.Text;
                    if (_category.Name == String.Empty || _category.Name.Length < 2)
                    {
                        errorProvider.SetError(nameTextBox, "Please provide a valid category!");
                    }

                    bool isAdded = _manager.Add(_category);
                    if (isAdded)
                    {
                        Reset(this.Controls);
                        _dataTable = _manager.GetCategories();
                    for (int i = 0; i < _dataTable.Rows.Count; i++)
                    {
                        categoryDataGridView.Rows.Add( _dataTable.Rows[i].Field<int>("Id"), _dataTable.Rows[i].Field<string>("Name"));
                    }

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

        private void categoryDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _category.Name = categoryDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                
                if (_category.Name.Length <3)
                {
                    gridMessage.Text = "Please Select A Category Name!";
                    return;
                }
                gridMessage.Visible = false;
                _category.Id = Convert.ToInt32(categoryDataGridView.Rows[categoryDataGridView.CurrentRow.Index].Cells[0].Value);
                nameTextBox.Text = _category.Name;
                UpdateButton.Visible = true;
                SaveButton.Visible = false;
                UpdateButton.ForeColor = Color.Green;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                _category.Name = nameTextBox.Text;
                if (_category.Name == String.Empty || _category.Name.Length < 2)
                {
                    errorProvider.SetError(nameTextBox, "Please provide a valid category!");
                }
                bool isAdded = _manager.Update(_category);
                if (isAdded)
                {
                    Reset(this.Controls);
                    _dataTable = _manager.GetCategories();
                    categoryDataGridView.DataSource = _dataTable;

                }
                else
                {
                    MessageBox.Show("Error Occured While Updating!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           
        }

        private void categoryDataGridView_MouseHover(object sender, EventArgs e)
        {
            gridMessage.Text = "Please Select A Category Name!";
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

        private void CategorySetupUI_FormClosing(object sender, FormClosingEventArgs e)
        {

            var window = MessageBox.Show("Close the window?", "Are you sure?", MessageBoxButtons.YesNo);

            e.Cancel = (window == DialogResult.No);
            Index index = new Index();
            index.Show();
        }

    }
}

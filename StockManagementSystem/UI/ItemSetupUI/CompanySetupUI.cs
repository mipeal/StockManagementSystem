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
    public partial class CompanySetupUI : Form
    {
        CompanyManager _manager = new CompanyManager();
        private DataTable _dataTable;
        public CompanySetupUI()
        {
            InitializeComponent();

            _dataTable = _manager.GetCompanies(); for (int i = 0; i < _dataTable.Rows.Count; i++)
            {
                companyDataGridView.Rows.Add(_dataTable.Rows[i].Field<int>("Id"), _dataTable.Rows[i].Field<string>("Name"));
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Company company = new Company();
                company.Name = nameTextBox.Text;
                if (company.Name == String.Empty || company.Name.Length < 2)
                {
                    errorProvider.SetError(nameTextBox, "Please provide a valid company!");
                }

                bool isAdded = _manager.Add(company);
                if (isAdded)
                {
                    Reset(this.Controls);
                    _dataTable = _manager.GetCompanies();
                    for (int i = 0; i < _dataTable.Rows.Count; i++)
                    {
                        companyDataGridView.Rows.Add(_dataTable.Rows[i].Field<int>("Id"), _dataTable.Rows[i].Field<string>("Name"));
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

        private void CompanySetupUI_FormClosing(object sender, FormClosingEventArgs e)
        {

            var window = MessageBox.Show("Close the window?", "Are you sure?", MessageBoxButtons.YesNo);

            e.Cancel = (window == DialogResult.No);
            Index index = new Index();
            index.Show();
        }
        
    }
}

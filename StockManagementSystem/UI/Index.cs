using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.UI.InventoryUI;
using StockManagementSystem.UI.ItemSetup;

namespace StockManagementSystem.UI
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }
        


        #region MenuBar
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
                this.Dispose();
            }
        }
        #endregion

        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show( "Close the window?", "Are you sure?", MessageBoxButtons.YesNo);

            e.Cancel = (window == DialogResult.No);
        }
    }
}

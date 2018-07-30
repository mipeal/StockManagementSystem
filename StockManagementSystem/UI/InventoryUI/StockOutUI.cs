using StockManagementSystem.Models.InventoryModels;
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
        public StockOutUI()
        {
            InitializeComponent();
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            Inventory stockOut = new Inventory();
        }
    }
}

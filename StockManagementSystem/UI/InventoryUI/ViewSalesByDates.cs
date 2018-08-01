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

namespace StockManagementSystem.UI.InventoryUI
{
    public partial class ViewSalesByDates : Form
    {
        InventoryManager _inventoryManager = new InventoryManager();
        DataTable _dataTable = new DataTable();
        public ViewSalesByDates()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                #region Search Code
                string fromDate = fromDatePicker.Text;
                string toDate = toDatePicker.Text;
                #endregion

                _dataTable = _inventoryManager.ViewSaleSummary(fromDate, toDate);

                if (_dataTable.Rows.Count > 0)
                {
                    for (int i = 0; i <_dataTable.Rows.Count; i++)
                    {
                        saleSummaryGridView.Rows.Add((i + 1).ToString(), _dataTable.Rows[i].Field<string>("Name"), _dataTable.Rows[i].Field<int>("Sale Quantity"));
                    }
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
    }
}

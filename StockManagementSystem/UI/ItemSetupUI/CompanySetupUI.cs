using StockManagementSystem.BLL;
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

namespace StockManagementSystem.UI.ItemSetup
{
    public partial class CompanySetupUI : Form
    {
        CompanyManager _manager = new CompanyManager();
        private DataTable _dataTable;
        public CompanySetupUI()
        {
            InitializeComponent();

            _dataTable = _manager.GetCompanies();
            companyDataGridView.DataSource = _dataTable;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Company company = new Company();
                company.Name = nameTextBox.Text;
                if (company.Name == String.Empty || company.Name.Length < 2)
                {
                    errorProvider.SetError(nameTextBox, "Please provide a valid category!");
                }

                bool isAdded = _manager.Add(company);
                if (isAdded)
                {
                    Reset(this.Controls);
                    _dataTable = _manager.GetCompanies();
                    companyDataGridView.DataSource = _dataTable;
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
    }
}

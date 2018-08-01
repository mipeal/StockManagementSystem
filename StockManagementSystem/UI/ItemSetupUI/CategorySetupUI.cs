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
            _dataTable = _manager.GetCategories();
            categoryDataGridView.DataSource = _dataTable;
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
                        categoryDataGridView.DataSource = _dataTable;

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
    }
}

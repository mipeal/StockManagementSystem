using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DAL;
using StockManagementSystem.Models;

namespace StockManagementSystem.BLL
{
    class CategoryManager
    {
        CategoryRepository _repository = new CategoryRepository();
        public bool Add(Category category)
        {
            if (category==null && category.Name.Length<2)
            {
                throw new Exception("Sorry, Invalid Name Inserted!");
            }

            bool isAdded = _repository.Add(category);
            return isAdded;

        }

        public DataTable GetCategories()
        {
            DataTable dataTable = _repository.GetCategories();
            return dataTable;
        }

        public bool Update(Category category)
        {
            if (category.Name.Length < 2 && category.Id > 0 && category == null)
            {
                throw new Exception("Sorry, Invalid Name & ID Inserted!");
            }

            bool isAdded = _repository.Update(category);
            return isAdded;
        }
    }
}

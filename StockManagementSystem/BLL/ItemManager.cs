using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DAL;
using StockManagementSystem.Models;

namespace StockManagementSystem.BLL
{
    class ItemManager
    {
        ItemRepository _repository =new ItemRepository();
        public List<Category> GetCategories(List<Category> categories)
        {
            List<Category> categoriesAre = _repository.GetCategories(categories);
            return categoriesAre;
        }

        public List<Company> GetCompanies(List<Company> companies)
        {
            List<Company> companiesAre = _repository.GetCompanies(companies);
            return companiesAre;
        }

        public bool Add(Item item)
        {

            if (item == null && item.Name.Length < 3)
            {
                throw new Exception("Sorry, Invalid Name Inserted!");
            }

            bool isAdded = _repository.Add(item);
            return isAdded;
        }
    }
}

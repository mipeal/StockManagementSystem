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
    class ItemManager
    {
        ItemRepository _repository =new ItemRepository();
      

        public bool Add(Item item)
        {

            if (item == null && item.Name.Length < 3)
            {
                throw new Exception("Sorry, Invalid Name Inserted!");
            }

            bool isAdded = _repository.Add(item);
            return isAdded;
        }

        public DataTable GetItems(int categoryId, int companyId)
        {
            DataTable items = new DataTable();
            if (categoryId>0 && companyId>0)
            {
                items = _repository.GetItems(categoryId,companyId);
            }
            else if (categoryId == 0)
            {
                items = _repository.GetItemsByCompany(companyId);
            }
            else if (companyId==0)
            {
                items = _repository.GetItemsByCategory(categoryId);
            }
            else
            {
                items = _repository.GetItems();
            }
            return items;
        }
    }
}

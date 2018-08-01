using StockManagementSystem.DAL;
using StockManagementSystem.Models.InventoryModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.BLL
{
    class InventoryManager
    {
        InventoryRepository _repository = new InventoryRepository();
        public DataSet GetItemInventory(int itemId)
        {
            DataSet items = new DataSet();
            if (itemId > 0)
            {
                items = _repository.GetItemInventory(itemId);
            }
            return items;
        }

        public bool Add(Inventory stockIn)
        {
            if (stockIn == null && stockIn.StockTransaction<=0)
            {
                throw new Exception("Sorry, Invalid Transaction Occurred!");
            }

            bool isAdded = _repository.Add(stockIn);
            return isAdded;
        }
    }
}

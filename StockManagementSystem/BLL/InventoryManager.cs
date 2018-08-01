using StockManagementSystem.DAL;
using StockManagementSystem.Models;
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

            bool isAdded = _repository.AddStockIn(stockIn);
            return isAdded;
        }

        public int Add(List<Inventory> stockOutList)
        {
            int rowOccurred = 0;
            if (stockOutList == null )
            {
                throw new Exception("Sorry, No Item Found!");
            }
            foreach (var item in stockOutList)
            {

                bool isInserted = _repository.AddStockOut(item);
                if (isInserted)
                {
                    rowOccurred++;
                }
            }
            return rowOccurred;
        }

        public DataSet GetStockBalance(int itemId)
        {
            DataSet items = new DataSet();
            if (itemId > 0)
            {
                items = _repository.GetStockBalance(itemId);
            }
            return items;
        }

        public DataTable SearchItemsSummary(int categoryId,int companyId)
        {
            if ( categoryId <=0 && companyId <=0)
            {
                throw new Exception("Sorry.. Please Select Category or Company!!!");
            }

            DataTable dt = new DataTable();
            if (categoryId <= 0)
            {
                dt = _repository.SearchItemsSummaryByCompanyId(companyId);
            }
            else if (companyId<=0)
            {
                dt = _repository.SearchItemsSummaryByCategoryId(categoryId);
            }
            else
            {
                dt = _repository.SearchItemsSummary(categoryId, companyId);
            }
            return dt;
        }
    }
}

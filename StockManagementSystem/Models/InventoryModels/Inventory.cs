using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.InventoryModels
{
    class Inventory
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int StockAvailable { get; set; }
        public int StockTransaction { get; set; }
        public int StockType { get; set; }
        public int StockOutType { get; set; }
        public DateTime TransactionDate { get => DateTime.Now; }

    }
}

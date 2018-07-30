using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReOrderLevel { get; set; }
        public int CompanyId { get; set; }
        public int CategoryId { get; set; }

    }
}

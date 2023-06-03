using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale.Entities
{
    public class Stock
    {
        public int StockID { get; set; }
        public int ProductID { get; set; }
        public double StockQuantity { get; set; }
        public double PurchasingCost { get; set; }
        public double SellingPrice { get; set; }
        public string Date { get; set; }
        public string StockStatus { get; set; }
    }
    
}

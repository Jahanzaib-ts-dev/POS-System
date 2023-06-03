using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale.Entities
{
    class TempProducts
    {
        public int ID { get; set; }
        public string Product_Name { get; set; }
        public string Product_Quantity { get; set; }
        public double Purchasing_Cost { get; set; }
        public double Selling_Price { get; set; }
        public string Date { get; set; }
    }
}

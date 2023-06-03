using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale.Entities
{
    public class Sales
    {
        public int SalesID { get; set; }
        public int CustomerID { get; set; }
        public string ProductName { get; set; }
        public double ProductQuantity { get; set; }
        public double Total { get; set; }
        public string SalesDate { get; set; }

    }
}

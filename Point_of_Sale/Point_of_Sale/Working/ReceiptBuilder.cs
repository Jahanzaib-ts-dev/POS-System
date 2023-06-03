using Point_of_Sale.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale.Working
{
    class ReceiptBuilder
    {
        public ReceiptBuilder(List<Sales> sales)
        {
            Builder(sales);
        }
        const int FIRST_COL_PAD = 25;
        const int SECOND_COL_PAD = 5;
        const int THIRD_COL_PAD = 8;
        void Builder(List<Sales> sales)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\t\tPOINT OF SALES");
            sb.AppendLine("\t\t================");

            foreach (var item in sales)
            {
                sb.Append(item.ProductName.PadRight(FIRST_COL_PAD));

                var breakDown = item.ProductQuantity > 0 ? "  " +item.ProductQuantity.ToString() : string.Empty;
                sb.Append(breakDown.PadRight(SECOND_COL_PAD));

                sb.AppendLine(string.Format("{0:0.00}", item.Total).PadLeft(THIRD_COL_PAD));

            }

            sb.AppendLine("\t\t================");

            Debug.WriteLine(sb.ToString());
        }
        
    }
}

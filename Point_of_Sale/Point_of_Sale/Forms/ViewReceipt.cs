using Point_of_Sale.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale.Forms
{
    public partial class ViewReceipt : Form
    {
        public ViewReceipt()
        {
            InitializeComponent();
        }
        public ViewReceipt(List<Sales> sales)
        {
            InitializeComponent();
            temp_receipt_grid(sales);
        }

        public void temp_receipt_grid(List<Sales> sales)
        {
            
            double quantity = 0;
            double total = 0;
            foreach(Sales obj in sales)
            {
                view_receipt_grid.Rows.Add(obj.ProductName, obj.ProductQuantity, obj.Total);
                quantity += obj.ProductQuantity;
                total += obj.Total;
            }
            total_count_label.Text = total.ToString();
            items_count_label.Text = quantity.ToString();

        }


    }
}

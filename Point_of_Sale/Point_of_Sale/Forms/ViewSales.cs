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
    public partial class ViewSales : Form
    {
        public ViewSales()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }
        public ViewSales(List<Sales> sales)
        {
            DoubleBuffered = true;
            InitializeComponent();
            temp_view_sales_grid(sales);
        }


        public void temp_view_sales_grid(List<Sales> stocks)
        {
            view_sales_grid.Rows.Clear();

            foreach(Sales obj in stocks)
            {
                view_sales_grid.Rows.Add(obj.SalesID ,  obj.ProductQuantity, obj.Total, obj.SalesDate);
                count_count_label.Text = Convert.ToString(Convert.ToDouble(count_count_label.Text) + obj.ProductQuantity);
                total_count_label.Text = Convert.ToString(Convert.ToDouble(total_count_label.Text) + obj.Total);
            }
        }
    }
}

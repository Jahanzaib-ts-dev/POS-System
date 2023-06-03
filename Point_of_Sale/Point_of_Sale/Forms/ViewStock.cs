using Point_of_Sale.DAO;
using Point_of_Sale.Working;
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
    public partial class ViewStock : Form
    {
        ProductDAO productDAO = new ProductDAO();
        StockDAO stockDAO = new StockDAO();
        HelpingFunction helpingFunction = new HelpingFunction();

        public ViewStock()
        {
            InitializeComponent();        
        }
        public ViewStock(List<Stock> stocks , string verify)
        {
            InitializeComponent();
            switch (verify)
            {
                case "view_inventory":
                    {
                        temp_view_inventory_grid(stocks);
                        break;
                    }
                case "update_inventory":
                    {
                        temp_view_inventory_grid_update(stocks);
                        break;
                    }
                case "delete_inventory":
                    {
                        temp_view_inventory_grid_delete(stocks);
                        break;
                    }
            }
            
        }

        


       

        private void temp_view_inventory_grid(List<Stock> stocks)
        {
            
            DataTable addproduct_tab = new DataTable();
            addproduct_tab.Columns.Add("StockQuantity", typeof(double));
            addproduct_tab.Columns.Add("Purchasing Cost", typeof(double));
            addproduct_tab.Columns.Add("Selling Price", typeof(double));
            addproduct_tab.Columns.Add("Date", typeof(string));
            addproduct_tab.Columns.Add("Status", typeof(string));
           


            foreach (Stock tobj in stocks)
            {
                addproduct_tab.Rows.Add(tobj.StockQuantity, tobj.PurchasingCost, tobj.SellingPrice, tobj.Date , tobj.StockStatus);
            }

            view_stock_grid.DataSource = addproduct_tab;

        }
        private void temp_view_inventory_grid_update(List<Stock> stocks)
        {

            DataTable addproduct_tab = new DataTable();
            addproduct_tab.Columns.Add("StockID", typeof(int));
            addproduct_tab.Columns.Add("StockQuantity", typeof(double));
            addproduct_tab.Columns.Add("Purchasing Cost", typeof(double));
            addproduct_tab.Columns.Add("Selling Price", typeof(double));
            addproduct_tab.Columns.Add("Date", typeof(string));
            addproduct_tab.Columns.Add("Edit", typeof(string));



            foreach (Stock tobj in stocks)
            {
                addproduct_tab.Rows.Add(tobj.StockID , tobj.StockQuantity, tobj.PurchasingCost, tobj.SellingPrice, tobj.Date , "Edit");
            }

            view_stock_grid.DataSource = addproduct_tab;

        }
        private void temp_view_inventory_grid_delete(List<Stock> stocks)
        {

            DataTable addproduct_tab = new DataTable();
            addproduct_tab.Columns.Add("StockID", typeof(int));
            addproduct_tab.Columns.Add("StockQuantity", typeof(double));
            addproduct_tab.Columns.Add("Purchasing Cost", typeof(double));
            addproduct_tab.Columns.Add("Selling Price", typeof(double));
            addproduct_tab.Columns.Add("Date", typeof(string));
            addproduct_tab.Columns.Add("Delete Stock", typeof(string));



            foreach (Stock tobj in stocks)
            {
                addproduct_tab.Rows.Add(tobj.StockID , tobj.StockQuantity, tobj.PurchasingCost, tobj.SellingPrice, tobj.Date , "Delete Stock");
            }

            view_stock_grid.DataSource = addproduct_tab;

        }
        private void view_stock_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                if (e.RowIndex >= 0)
                {
                    if (view_stock_grid.Columns[e.ColumnIndex].HeaderText == "Delete Stock")
                    {
                        int StockID = Convert.ToInt32(view_stock_grid.Rows[e.RowIndex].Cells[0].Value.ToString());
                        string pName = productDAO.Select_ProductName_by_ProductID(stockDAO.Select_ProductID_by_StockID(StockID));
                        stockDAO.Delete_by_StockID(StockID);
                        helpingFunction.product_quantity_updater(pName);
                        this.Hide();
                    }
                    else
                    {
                        int StockID = Convert.ToInt32(view_stock_grid.Rows[e.RowIndex].Cells[0].Value.ToString());
                        UpdateInventoryForm updateInventoryForm = new UpdateInventoryForm(StockID);
                        updateInventoryForm.Show();
                        this.Hide();
                    }
                }
                    
            }
                
        }
    }
}

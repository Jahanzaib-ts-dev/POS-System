using Point_of_Sale.DAO;
using Point_of_Sale.Entities;
using Point_of_Sale.Working;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale
{
    public partial class UpdateInventoryForm : Form
    {

        private int StockID = 0;
        private StockDAO stockDAO = new StockDAO();
        private ProductDAO productDAO = new ProductDAO();
        private HelpingFunction helpingFunction = new HelpingFunction();
        public UpdateInventoryForm()
        {
            InitializeComponent();
        }

        public UpdateInventoryForm(int StockID)
        {
            InitializeComponent();
            Stock stock_row = stockDAO.Select_Stock_by_StockID(StockID);
            string productName = productDAO.Select_ProductName_by_ProductID(stock_row.ProductID);
            fields_Value_Assigner(productName , stock_row.StockQuantity , stock_row.PurchasingCost , stock_row.SellingPrice);
            setStockID(stock_row.StockID);

        }
        private void update_button_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.StockID = getStockID();
            stock.StockQuantity = Convert.ToDouble(product_quantity_textbox.Text.Trim());
            stock.PurchasingCost = Convert.ToDouble(purchasing_cost_textbox.Text.Trim());
            stock.SellingPrice = Convert.ToDouble(selling_price_textbox.Text.Trim());
            stockDAO.Update_Stock_tuple(stock);
            string pName = productDAO.Select_ProductName_by_ProductID(stockDAO.Select_ProductID_by_StockID(getStockID()));
            helpingFunction.product_quantity_updater(pName);
            this.Hide();
            stockDAO.Update_StockStatus_inStock();
        }

        private void fields_Value_Assigner(string productName , double productQuantity , double purchasingCost , double sellingPrice)
        {
            product_name_textbox.Text = productName;
            product_quantity_textbox.Text = Convert.ToString(productQuantity);
            purchasing_cost_textbox.Text = Convert.ToString(purchasingCost);
            selling_price_textbox.Text = Convert.ToString(sellingPrice);
        }
        public void setStockID(int stockID)
        {
           StockID = stockID;
        }
        public int getStockID()
        {
            return StockID;
        }

        private void product_quantity_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            helpingFunction.Only_Number_KeyPress(sender, e);
        }

        private void purchasing_cost_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            helpingFunction.Only_Decimal_KeyPress(sender, e, purchasing_cost_textbox.Text.Trim());
        }

        private void selling_price_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            helpingFunction.Only_Decimal_KeyPress(sender, e, selling_price_textbox.Text.Trim());
        }
    }
}

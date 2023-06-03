using Point_of_Sale.DAO;
using Point_of_Sale.DBconnections;
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
    public partial class NewPurchases : Form
    {
        ProductDAO productDAO = new ProductDAO();
        StockDAO stockDAO = new StockDAO();
        HelpingFunction helpingFunction = new HelpingFunction(); 

        

        public NewPurchases()
        {
            InitializeComponent();
            List<string> productNames = productDAO.Select_Product_Name();
            productNames.Sort();
            NewPurchases_combobox.AutoCompleteCustomSource.AddRange(productNames.ToArray());
            NewPurchases_combobox.Items.AddRange(productNames.ToArray());
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (NewPurchases_combobox.Text.Trim() != "" && product_quantity_textbox.Text.Trim() != "" && purchasingcost_textbox.Text.Trim() != "" && sellingprice_textbox.Text.Trim() != "")
            {
                int productID = productDAO.Select_productID_by_productName(NewPurchases_combobox.Text.ToString());
                stockDAO.Insert_Stock(productID, Convert.ToDouble(product_quantity_textbox.Text.Trim()), Convert.ToDouble(purchasingcost_textbox.Text.Trim()), Convert.ToDouble(sellingprice_textbox.Text.Trim()), addproduct_datetime.Value.ToString("dd/MM/yyyy"));
                helpingFunction.product_quantity_updater(NewPurchases_combobox.Text.Trim());

                NewPurchases_combobox.Text = ""; product_quantity_textbox.Text = ""; purchasingcost_textbox.Text = ""; sellingprice_textbox.Text = "";
            }
            else
            {
                MessageBox.Show("Empty Field");
            }
        }

        private void product_quantity_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            helpingFunction.Only_Number_KeyPress(sender, e);
        }

        private void purchasingcost_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            helpingFunction.Only_Decimal_KeyPress(sender, e, purchasingcost_textbox.Text.Trim());
        }

        private void sellingprice_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            helpingFunction.Only_Decimal_KeyPress(sender, e, sellingprice_textbox.Text.Trim());
        }
    }
}

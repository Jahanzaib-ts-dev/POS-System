using Point_of_Sale.DAO;
using Point_of_Sale.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale.Working
{
    class HelpingFunction
    {
        StockDAO stockDAO = new StockDAO();
        ProductDAO productDAO = new ProductDAO();
        public bool string_parse(string check_name , string product_name)
        {
            for(int i = 0; i<product_name.Length; i++)
            {
               if(check_name[i] != product_name[i])
               {
                    return false;
               }
            }
            return true;
        }

        public void stock_status_checker()
        {
            stockDAO.Update_StockStatus();
        }

        public void product_quantity_updater(string pName)
        {
            int pID = productDAO.Select_productID_by_productName(pName);
            List<Stock> stocks = stockDAO.Select_Stock_by_ProductID(pID);
            double pQuantity = 0;
            foreach (var item in stocks)
            {
                pQuantity += item.StockQuantity;
            }
            productDAO.update_productQuantity(pQuantity, pID);


        }
        public void Only_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8))
                e.Handled = true;
        }
        public void Only_Decimal_KeyPress(object sender, KeyPressEventArgs e , string text)
        {
            if (!((e.KeyChar >=48 && e.KeyChar <=57) || e.KeyChar == 46 || e.KeyChar == 8))
                e.Handled = true;
            else if (e.KeyChar == 46)
                e.Handled = (dot_checker(text) == true) ? true : false;
        }
        public void Only_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        public bool dot_checker(string text)
        {
            bool dotCheck = false;
            foreach (char chr in text)
            {
                if(chr == '.')
                {
                    dotCheck = true;
                    break;
                }

            }
            return dotCheck;
        }

    }
}

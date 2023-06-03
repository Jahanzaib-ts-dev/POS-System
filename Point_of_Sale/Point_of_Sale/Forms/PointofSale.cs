///-------------------------------------بِسْمِ ٱللَّٰهِ ٱلرَّحْمَٰنِٱلرَّحِيمِ-----------------------------------------
using Point_of_Sale.DAO;
using Point_of_Sale.DBconnections;
using Point_of_Sale.Entities; 
using Point_of_Sale.Forms;
using Point_of_Sale.Working;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Point_of_Sale
{
    partial class PointofSaleForm : Form
    {
        public PointofSaleForm()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            helpingFunction.stock_status_checker();
            
        }
        public PointofSaleForm(string user , string role)
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            helpingFunction.stock_status_checker();
            this.employee_label.Text = user;
            this.Role_label.Text = role;
        }

        //-----------------------------------DECLARATION---------------------------------
        ProductDAO productDAO = new ProductDAO();
        StockDAO stockDAO = new StockDAO();
        CustomerDAO customerDAO = new CustomerDAO();
        SalesDAO salesDAO = new SalesDAO();

        Employees employee = new Employees();
        DBconnection db = new DBconnection();

        HelpingFunction helpingFunction = new HelpingFunction();
        List<TempProducts> addproducts_list = new List<TempProducts>();
        List<Stock> item_list = new List<Stock>();
        List<string> productNames = new List<string>();
        string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        List<double> monthlySales = new List<double>();

        //-----------------------------------DECLARATION------------------------------------

        //----------------------------------FORM_RELATED------------------------------------
        [MTAThread]
        private void PointofSaleForm_Load(object sender, EventArgs e)
        {
            List<string> product_name_list = productDAO.Select_Product_Name();
            newsales_combobox.AutoCompleteCustomSource.AddRange(product_name_list.ToArray());
            newsales_button_Click(sender, e);
            role_operation(); 
        }
        private void Header_panel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, Header_panel.ClientRectangle,
            Color.White, 0, ButtonBorderStyle.Solid, // left
            Color.DimGray, 1, ButtonBorderStyle.Solid, // top
            Color.DimGray, 0, ButtonBorderStyle.Solid, // right
            Color.DimGray, 1, ButtonBorderStyle.Solid);// bottom
        }
        //----------------------------------FORM_RELATED-------------------------------------

        //-----------------------------------NEW SALES---------------------------------------
        private void newsales_button_Click(object sender, EventArgs e)
        {
            Panel_Visibility();
            NEW_SALES.Visible = true;
            title_label.Text = "";
            title_label.Text = "NEW SALES";
            newsales_combobox.Items.Clear();
            productNames = productDAO.Select_Product_Name();
            newsales_combobox.Items.AddRange(productNames.ToArray());
        }

        private void newsales_add_button_Click(object sender, EventArgs e)
        {
            List<string> productNames = productDAO.Select_Product_Name();
            helpingFunction.stock_status_checker();
            bool checker = false;
            foreach (string value in productNames)
            {
                if (newsales_combobox.Text.Trim() == value)
                {
                    checker = true;
                    break;
                }
            }
            if (checker == true)
            {
                int productID = productDAO.Select_productID_by_productName(newsales_combobox.Text.Trim());
                List<Stock> stocksList = stockDAO.Select_Stock_by_ProductID_AND_Status(productID, "InStock");
                if (stocksList.ElementAtOrDefault(0) != null)
                {
                    temp_item_grid(productID);
                }
            }


        }

        private void End_Sale_button_Click(object sender, EventArgs e)
        {

            if (items_grid.Rows.Count != 0)
            {
                customerDAO.Insert_Customer(customer_name_textbox.Text.Trim(), main_datetime_picker.Value.ToString("dd/MM/yyyy"));
            }

            int i = 0;
            foreach (DataGridViewRow row in items_grid.Rows)
            {
                int productID = productDAO.Select_productID_by_productName(Convert.ToString(row.Cells[0].Value.ToString()));
                List<Stock> stocksList = stockDAO.Select_Stock_by_ProductID(productID);
                int stockID = stockDAO.Select_StockID_by_ProductName(Convert.ToString(row.Cells[0].Value.ToString()));
                double quantity = stockDAO.Select_StockQuantity_by_StockID(stockID);
                double pQuantity = Convert.ToDouble(row.Cells[1].Value.ToString());

                while (pQuantity != 0)
                {
                    foreach (Stock obj in stocksList)
                    {
                        double stockQuantity = 0;
                        if (pQuantity <= obj.StockQuantity || pQuantity > obj.StockQuantity && pQuantity >= 0)
                        {
                            if (pQuantity > obj.StockQuantity)
                            {
                                pQuantity = pQuantity - obj.StockQuantity;
                                stockQuantity = 0;
                            }
                            else if (pQuantity <= obj.StockQuantity && pQuantity >= 0)
                            {
                                stockQuantity = obj.StockQuantity - pQuantity;
                                pQuantity = 0;
                            }

                            stockDAO.Update_Stock_Quantity_by_StockID(stockQuantity, obj.StockID);
                        }

                    }
                    salesDAO.Insert_NewSales(customerDAO.Select_Last_CustomerID(), Convert.ToString(row.Cells[0].Value.ToString()), Convert.ToDouble(row.Cells[1].Value), Convert.ToDouble(row.Cells[3].Value), main_datetime_picker.Value.ToString("dd/MM/yyyy"));
                }

                helpingFunction.product_quantity_updater(Convert.ToString(row.Cells[0].Value.ToString()));

                i++;
            }

            CashReturnForm cashReturnForm = new CashReturnForm(Total_price_label.Text.Trim());
            Subtotal_price_label.Text = Convert.ToString(0.0);
            Discounts_price_label.Text = Convert.ToString(0.0);
            Total_price_label.Text = Convert.ToString(0.0);
            items_count_label.Text = Convert.ToString(0.0);
            

            if (items_grid.Rows.Count != 0)
            {
                cashReturnForm.Show();
            }

            items_grid.Rows.Clear();
            helpingFunction.stock_status_checker();
          
            //List<Sales> sales = salesDAO.Select_Sales_by_CustomerID(customerDAO.Select_Last_CustomerID());
            //ReceiptBuilder receipt = new ReceiptBuilder(sales);
        }

        private void newsales_combobox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                newsales_add_button_Click(sender, e);
            }
        }

        private void items_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if(e.RowIndex >= 0)
                {
                    items_grid.Rows.RemoveAt(e.RowIndex);
                }
               
            }
        }

        private void temp_item_grid(int productID)
        {
            itemprice_count_label.Text = Convert.ToString(0.0);
            items_count_label.Text = Convert.ToString(0.0);
            Subtotal_price_label.Text = Convert.ToString(0.0);
            Discounts_price_label.Text = Convert.ToString(0.0);
            Total_price_label.Text = Convert.ToString(0.0);
            //List<Stock> stockList = stockDAO.Select_Stock_by_ProductID(productID);
            Button btn = new Button();
            btn.Text = "Delete";

            bool found = false;

            if (items_grid.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in items_grid.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == newsales_combobox.Text && (productDAO.Select_productQuantity_by_productID(productID) > Convert.ToDouble(row.Cells[1].Value)))
                    //&& row.Cells[1].Value.ToString() <=
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        found = true;

                    }
                }
                foreach (DataGridViewRow row in items_grid.Rows)
                {
                    if (newsales_combobox.Text.Trim() == row.Cells[0].Value.ToString())
                    {
                        found = true;
                        break;
                    }
                }
                if (found == false)
                {
                    items_grid.Rows.Add(productDAO.Select_ProductName_by_ProductID(productID), 1, Math.Round(stockDAO.Select_ProductPrice_by_ProductID(productID), 2), 0);
                }

            }
            else
            {
                items_grid.Rows.Add(productDAO.Select_ProductName_by_ProductID(productID), 1, Math.Round(stockDAO.Select_ProductPrice_by_ProductID(productID), 2), 0);
            }

            foreach (DataGridViewRow row in items_grid.Rows)
            {
                items_count_label.Text = Convert.ToString(Convert.ToInt32(items_count_label.Text) + Convert.ToInt32(row.Cells[1].Value));
                double total = Convert.ToSingle(row.Cells[1].Value) * Convert.ToSingle(row.Cells[2].Value);
                row.Cells[3].Value = Convert.ToString(Math.Round(total, 2));
                Subtotal_price_label.Text = Convert.ToString(Math.Round((Convert.ToDouble(Subtotal_price_label.Text) + total), 2));
                Total_price_label.Text = Convert.ToString(Math.Round(Convert.ToDouble(Subtotal_price_label.Text), 2));

            }

        }
        private void newsalesClearButton_Click(object sender, EventArgs e)
        {
            items_grid.Rows.Clear();

            itemprice_count_label.Text = Convert.ToString(0.0);
            items_count_label.Text = Convert.ToString(0.0);
            Subtotal_price_label.Text = Convert.ToString(0.0);
            Discounts_price_label.Text = Convert.ToString(0.0);
            Total_price_label.Text = Convert.ToString(0.0);

        }

        //-------------------------------------------ADD PRODUCT----------------------------
        private void addproduct_button_Click(object sender, EventArgs e)
        {
            Panel_Visibility();
            ADD_PRODUCT.Visible = true;
            title_label.Text = "";
            title_label.Text = "ADD PRODUCT";
        }
        private void temp_addproduct_grid()
        {

            DataTable addproduct_tab = new DataTable();

            addproduct_tab.Columns.Add("Product Name", typeof(string));
            addproduct_tab.Columns.Add("Product Quantity", typeof(string));
            addproduct_tab.Columns.Add("Purchasing Cost", typeof(double));
            addproduct_tab.Columns.Add("Selling Price", typeof(double));
            addproduct_tab.Columns.Add("Date", typeof(string));


            foreach (TempProducts tobj in addproducts_list)
            {
                addproduct_tab.Rows.Add(tobj.Product_Name, tobj.Product_Quantity, tobj.Purchasing_Cost, tobj.Selling_Price, tobj.Date);
            }

            addproduct_gridview.DataSource = addproduct_tab;
            addproduct_gridview.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
            addproduct_gridview.EnableHeadersVisualStyles = false;
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            if (productname_textbox.Text.Trim() == "" || productquantity_textbox.Text.Trim() == "" || purchasingcost_textbox.Text.Trim() == "" || sellingprice_textbox.Text.Trim() == "")
            {
                MessageBox.Show("Any of your field is Empty");
            }
            else
            {
                productDAO.Insert_Product(productname_textbox.Text.Trim());
                int productID = productDAO.Select_ProductID();
                stockDAO.Insert_Stock(productID, Convert.ToDouble(productquantity_textbox.Text.Trim()), Convert.ToDouble(purchasingcost_textbox.Text.Trim()), Convert.ToDouble(sellingprice_textbox.Text.Trim()), addproduct_datetime.Value.ToString("dd/MM/yyyy"));
                helpingFunction.product_quantity_updater(productname_textbox.Text.Trim());
                TempProducts obj = new TempProducts();
                obj.Product_Name = productname_textbox.Text; obj.Product_Quantity = productquantity_textbox.Text; obj.Purchasing_Cost = Convert.ToDouble(purchasingcost_textbox.Text); obj.Selling_Price = Convert.ToDouble(sellingprice_textbox.Text); obj.Date = addproduct_datetime.Value.ToString("dd/MM/yyyy");
                addproducts_list.Add(obj);

                temp_addproduct_grid();
                productname_textbox.Text = ""; productquantity_textbox.Text = ""; purchasingcost_textbox.Text = ""; sellingprice_textbox.Text = "";
            }

        }
        private void productquantity_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!productquantity_textbox.Text.Contains('.'))
            {
                helpingFunction.Only_Number_KeyPress(sender, e);
            }
        }

        private void new_purchases_button_Click(object sender, EventArgs e)
        {
            NewPurchases newPurchases = new NewPurchases();
            newPurchases.Show();
        }

        private void purchasingcost_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            helpingFunction.Only_Decimal_KeyPress(sender, e, purchasingcost_textbox.Text.Trim());
        }

        private void sellingprice_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            helpingFunction.Only_Decimal_KeyPress(sender, e, sellingprice_textbox.Text.Trim());
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            addproducts_list.Clear();
            temp_addproduct_grid();
        }

        //-----------------------------DELETE PRODUCT---------------------------------------
        private void deleteproduct_button_Click(object sender, EventArgs e)
        {
            Panel_Visibility();
            DELETE_PRODUCT.Visible = true;
            title_label.Text = "";
            title_label.Text = "DELETE PRODUCT";
            
            List<string> product_name_list = productDAO.Select_Product_Name();
            del_product_textbox.AutoCompleteCustomSource.AddRange(product_name_list.ToArray());
            del_product_textbox_TextChanged(sender, e);
        }

        private void del_product_textbox_TextChanged(object sender, EventArgs e)
        {            

            List<Product> allproduct = productDAO.Select_All_Products();
            List<Product> required_product = new List<Product>();

            foreach (Product obj in allproduct)
            {
                bool check = helpingFunction.string_parse(obj.Product_Name, del_product_textbox.Text);
                if (check == true)
                {
                    required_product.Add(obj);
                }
            }

            DataTable addproduct_tab = new DataTable();
            addproduct_tab.Columns.Add("ID", typeof(int));
            addproduct_tab.Columns.Add("Product Name", typeof(string));
            addproduct_tab.Columns.Add("Delete Stock", typeof(string));

            foreach (Product tobj in required_product)
            {
                addproduct_tab.Rows.Add(tobj.ID, tobj.Product_Name, "Delete Stock");
            }

            del_product_gridview.DataSource = addproduct_tab;
            del_product_gridview.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
            del_product_gridview.EnableHeadersVisualStyles = false;

        }

        private void del_product_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if(e.RowIndex >= 0)
                {

                    int id = Convert.ToInt32(del_product_gridview.Rows[e.RowIndex].Cells[0].Value.ToString());
                    List<Stock> stocks = stockDAO.Select_Stock_by_ProductID(id);

                    ViewStock viewStock = new ViewStock(stocks, "delete_inventory");
                    viewStock.Show();
                }
            }
        }

        //-----------------------------------------SALES_PER_DAY------------------------------------
        private void salesperday_button_Click(object sender, EventArgs e)
        {
            Panel_Visibility();
            SALES_PER_DAY.Visible = true;
            title_label.Text = "";
            title_label.Text = "SALES PER DAY";

            sales_per_day_datetime_ValueChanged(sender, e);
        }

        private void sales_per_day_datetime_ValueChanged(object sender, EventArgs e)
        {
            List<Customers> customers = customerDAO.Select_Customers_by_Date(sales_per_day_datetime.Value.ToString("dd/MM/yyyy"));

            DataTable addCustomers = new DataTable();
            addCustomers.Columns.Add("ID", typeof(int));
            addCustomers.Columns.Add("Customer", typeof(string));
            addCustomers.Columns.Add("Transaction Date", typeof(string));
            addCustomers.Columns.Add("Receipt", typeof(string));

            foreach (Customers obj in customers)
            {
                addCustomers.Rows.Add(obj.CustomerID, obj.CustomerName, obj.TransactionDate, "View Receipt");
            }


            sales_per_day_grid.DataSource = addCustomers;
            sales_per_day_grid.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
            sales_per_day_grid.EnableHeadersVisualStyles = false;

        }

        private void sales_per_day_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (e.RowIndex >= 0)
                {
                    int cID = Convert.ToInt32(sales_per_day_grid.Rows[e.RowIndex].Cells[0].Value);
                    List<Sales> sales = salesDAO.Select_Sales_by_CustomerID(cID);
                    ViewReceipt viewReceipt = new ViewReceipt(sales);
                    viewReceipt.Show();
                }

            }
        }

        //--------------------------------------------------SALES_PER_PRODUCT--------------------------------
        private void salesperproduct_button_Click(object sender, EventArgs e)
        {
            Panel_Visibility();
            SALES_PER_PRODUCT.Visible = true;
            title_label.Text = "";
            title_label.Text = "SALES PER PRODUCT";
            List<string> product_name_list = productDAO.Select_Product_Name();
            sales_product_name_textbox.AutoCompleteCustomSource.AddRange(product_name_list.ToArray());

            List<Product> products = productDAO.Select_All_Products();
            temp_sales_product_grid(products);
        }

        private void sales_product_name_textbox_TextChanged(object sender, EventArgs e)
        {


            List<Product> allproduct = productDAO.Select_All_Products();
            List<Product> required_product = new List<Product>();

            foreach (Product obj in allproduct)
            {
                bool check = helpingFunction.string_parse(obj.Product_Name, sales_product_name_textbox.Text.Trim());
                if (check == true)
                {
                    required_product.Add(obj);
                }
            }
            temp_sales_product_grid(required_product);
        }

        private void temp_sales_product_grid(List<Product> products)
        {
            DataTable addProduct = new DataTable();
            addProduct.Columns.Add("ID", typeof(int));
            addProduct.Columns.Add("Product", typeof(string));
            addProduct.Columns.Add("Sales", typeof(string));

            foreach (Product obj in products)
            {
                addProduct.Rows.Add(obj.ID, obj.Product_Name, "View Sales");
            }
            sales_per_product_grid.DataSource = addProduct;
        }

        private void sales_per_product_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if(e.RowIndex >= 0)
                {
                    string pName = sales_per_product_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    List<Sales> sales = salesDAO.Select_Sales_by_ProductName(pName);

                    ViewSales viewSales = new ViewSales(sales);
                    viewSales.Show();
                }
               
            }
        }


        //-----------------------------------------------------VIEW_INVENTORY--------------------------------
        private void viewinventory_button_Click(object sender, EventArgs e)
        {
            Panel_Visibility();
            VIEW_INVENTORY.Visible = true;
            title_label.Text = "";
            title_label.Text = "VIEW INVENTORY";

            List<string> product_name_list = productDAO.Select_Product_Name();
            view_inventory_textbox.AutoCompleteCustomSource.AddRange(product_name_list.ToArray());

            List<Product> allproduct = productDAO.Select_All_Products();
            temp_view_inventory_grid(allproduct);


        }

        private void temp_view_inventory_grid(List<Product> product)
        {

            DataTable addproduct_tab = new DataTable();
            addproduct_tab.Columns.Add("ID", typeof(int));
            addproduct_tab.Columns.Add("Product Name", typeof(string));
            addproduct_tab.Columns.Add("View Stock", typeof(string));

            foreach (Product tobj in product)
            {
                addproduct_tab.Rows.Add(tobj.ID, tobj.Product_Name, "View Stock");
            }

            view_inventory_grid.DataSource = addproduct_tab;
            view_inventory_grid.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
            view_inventory_grid.EnableHeadersVisualStyles = false;

        }

        private void view_inventory_textbox_TextChanged(object sender, EventArgs e)
        {
            List<Product> allproduct = productDAO.Select_All_Products();
            List<Product> required_product = new List<Product>();

            foreach (Product obj in allproduct)
            {
                bool check = helpingFunction.string_parse(obj.Product_Name, view_inventory_textbox.Text.Trim());
                if (check == true)
                {
                    required_product.Add(obj);
                }
            }
            temp_view_inventory_grid(required_product);
        }

        private void view_inventory_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.RowIndex >= 0)
                {
                    int id = Convert.ToInt32(view_inventory_grid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    List<Stock> stock_list = stockDAO.Select_Stock_by_ProductID(id);
                    ViewStock viewStock = new ViewStock(stock_list, "view_inventory");
                    viewStock.Show();
                }

            }
        }

        //--------------------------------------------------UPDATE_INVENTORY--------------------------------
        private void updateinventory_button_Click(object sender, EventArgs e)
        {
            Panel_Visibility();
            UPDATE_INVENTORY.Visible = true;
            title_label.Text = "";
            title_label.Text = "UPDATE INVENTORY";

            List<string> product_name_list = productDAO.Select_Product_Name();
            product_name_textbox.AutoCompleteCustomSource.AddRange(product_name_list.ToArray());

            List<Product> allproduct = productDAO.Select_All_Products();
            temp_update_inventory_grid(allproduct);

        }

        private void product_name_textbox_TextChanged(object sender, EventArgs e)
        {
            List<Product> allproduct = productDAO.Select_All_Products();
            List<Product> required_product = new List<Product>();

            foreach (Product obj in allproduct)
            {
                bool check = helpingFunction.string_parse(obj.Product_Name, product_name_textbox.Text.Trim());
                if (check == true)
                {
                    required_product.Add(obj);
                }
            }
            temp_update_inventory_grid(required_product);
        }

        private void temp_update_inventory_grid(List<Product> product)
        {


            DataTable addproduct_tab = new DataTable();
            addproduct_tab.Columns.Add("ID", typeof(int));
            addproduct_tab.Columns.Add("Product Name", typeof(string));
            addproduct_tab.Columns.Add("Edit", typeof(string));

            foreach (Product tobj in product)
            {
                addproduct_tab.Rows.Add(tobj.ID, tobj.Product_Name, "Edit Stock");
            }

            update_inventory_grid.DataSource = addproduct_tab;
            update_inventory_grid.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
            update_inventory_grid.EnableHeadersVisualStyles = false;
        }

        private void update_inventory_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.RowIndex >= 0)
                {
                    int id = Convert.ToInt32(update_inventory_grid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    List<Stock> stock_list = stockDAO.Select_Stock_by_ProductID(id);
                    ViewStock viewStock = new ViewStock(stock_list, "update_inventory");
                    viewStock.Show();
                }
            }
        }

        //-----------------------------------------------MONTHLY SALES ----------------------
        private void Monthly_sales_button_Click(object sender, EventArgs e)
        {
            Panel_Visibility();
            MONTHLY_SALES.Visible = true;
            title_label.Text = "";
            title_label.Text = "REPORT";
            yearly_datetimepicker.CustomFormat = "yyyy";
            yearly_datetimepicker.ShowUpDown = true;
            yearly_datetimepicker_ValueChanged(sender, e);
        }

        private void monthlyTableFill()
        {
            Jan_count.Text = monthlySales[0].ToString();
            Feb_count.Text = monthlySales[1].ToString();
            Mar_count.Text = monthlySales[2].ToString();
            Apr_count.Text = monthlySales[3].ToString();
            May_count.Text = monthlySales[4].ToString();
            Jun_count.Text = monthlySales[5].ToString();
            Jul_count.Text = monthlySales[6].ToString();
            Aug_count.Text = monthlySales[7].ToString();
            Sep_count.Text = monthlySales[8].ToString();
            Oct_count.Text = monthlySales[9].ToString();
            Nov_count.Text = monthlySales[10].ToString();
            Dec_count.Text = monthlySales[11].ToString();
            total_count.Text = "0";
            for (int i = 0; i<monthlySales.Count; i++)
            {
                total_count.Text = Convert.ToString(Convert.ToDouble(total_count.Text.ToString()) + monthlySales[i]);
            }

        }
        private void monthly_sales_count()
        {
            monthlySales.Clear();
            for (int i = 1; i <= months.Length; i++)
            {
                List<Sales> sales = salesDAO.Select_all_Sales();
                double mTotal = 0;
                foreach (Sales obj in sales)
                {
                    string date = obj.SalesDate;
                    DateTime dt = DateTime.ParseExact(date, "dd/MM/yyyy", null);
                    if (dt.Month == i && dt.Year == yearly_datetimepicker.Value.Year)
                    {
                        mTotal += obj.Total;
                    }
                }
                monthlySales.Add(mTotal);

            }
        }

        private void yearly_datetimepicker_ValueChanged(object sender, EventArgs e)
        {
            monthlyChartFill();
            monthlyTableFill();
        }

        private void monthlyChartFill()
        {
            foreach (var item in monthly_sales_chart.Series)
            {
                item.Points.Clear();
            }

            monthly_sales_count();
            for (int i = 0; i < months.Length; i++)
            {
                monthly_sales_chart.Series["MonthlySales"].Points.AddXY(months[i], monthlySales[i]);
            }

        }

        void Panel_Visibility()
        {
            NEW_SALES.Visible = false;
            ADD_PRODUCT.Visible = false;
            DELETE_PRODUCT.Visible = false;
            SALES_PER_DAY.Visible = false;
            SALES_PER_PRODUCT.Visible = false;
            UPDATE_INVENTORY.Visible = false;
            VIEW_INVENTORY.Visible = false;
            MONTHLY_SALES.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void role_operation()
        {
            switch (this.Role_label.Text)
            {
                case "Owner":
                    break;
                case "Cashier":
                    {
                        Monthly_sales_button.Enabled = false;
                    }
                    break;
                case "Inventory Manager":
                    {
                        Monthly_sales_button.Enabled = false;
                        newsales_button.Enabled = false;
                        Panel_Visibility();
                        ADD_PRODUCT.Visible = true;
                        title_label.Text = "ADD PRODUCT";
                    }
                    break;
                default:
                    break;
            }


        }

        private void customer_name_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void customer_came_label_Click(object sender, EventArgs e)
        {

        }

        private void items_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bill_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newsales_pname_label_Click(object sender, EventArgs e)
        {

        }

        private void items_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void newsales_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
using Point_of_Sale.DBconnections;
using Point_of_Sale.Entities;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale.DAO
{
    class StockDAO
    {
        ProductDAO productDAO = new ProductDAO();
        public void Insert_Stock(int productID, double stockQuantity, double purchasingCost, double sellingPrice, string date)
        {

            DBconnection db = new DBconnection();
            db.openConnection();
            string query = "INSERT INTO Stock ( ProductID , StockQuantity , PurchasingCost , SellingPrice , Date , StockStatus) VALUES (" + productID + " , " + stockQuantity + " , " + purchasingCost + " , " + sellingPrice + " , '" + date + "'  , 'InStock' )";
            db.ExecuteNonQueries(query);
            db.closeConnection();
        }
        public void Insert_Stock(double stockQuantity, double purchasingCost, double sellingPrice, string date)
        {

            DBconnection db = new DBconnection();
            db.openConnection();
            string query = "INSERT INTO Stock ( StockQuantity , PurchasingCost , SellingPrice , Date , , StockStatus) VALUES (" + stockQuantity + " , " + purchasingCost + " , " + sellingPrice + " , '" + date + "' , 'InStock')";
            db.ExecuteNonQueries(query);
            db.closeConnection();
        }
        public List<Stock> Select_Stock_by_ProductID_AND_Status(int id , string status)
        {
            DBconnection db = new DBconnection();
            List<Stock> stock_list = new List<Stock>();
            db.openConnection();
            string query = "SELECT * FROM Stock WHERE ProductID = " + id + " AND StockStatus = '" + status + "'";

            SQLiteDataReader dr = db.DataReader(query);
            while (dr.Read())
            {
                Stock obj = new Stock();

                obj.StockID = dr.GetInt32(0);
                obj.ProductID = dr.GetInt32(1);
                obj.StockQuantity = dr.GetDouble(2);
                obj.PurchasingCost = dr.GetDouble(3);
                obj.SellingPrice = dr.GetDouble(4);
                obj.Date = dr.GetString(5);
                obj.StockStatus = dr.GetString(6);
                stock_list.Add(obj);
            }
            db.closeConnection();
            return stock_list;
        }
        public List<Stock> Select_Stock_by_ProductID(int id)
        {
            DBconnection db = new DBconnection();
            List<Stock> stock_list = new List<Stock>();
            db.openConnection();
            string query = "SELECT * FROM Stock WHERE ProductID = " + id;

            SQLiteDataReader dr = db.DataReader(query);
            while (dr.Read())
            {
                Stock obj = new Stock();

                obj.StockID = dr.GetInt32(0);
                obj.ProductID = dr.GetInt32(1);
                obj.StockQuantity = dr.GetDouble(2);
                obj.PurchasingCost = dr.GetDouble(3);
                obj.SellingPrice = dr.GetDouble(4);
                obj.Date = dr.GetString(5);
                obj.StockStatus = dr.GetString(6);
                stock_list.Add(obj);
            }
            db.closeConnection();
            return stock_list;
        }

        public Stock Select_Stock_by_StockID(int id)
        {
            DBconnection db = new DBconnection();

            db.openConnection();
            string query = "SELECT * FROM Stock WHERE StockID = " + id;
            Stock obj = new Stock();
            SQLiteDataReader dr = db.DataReader(query);
            while (dr.Read())
            {


                obj.StockID = dr.GetInt32(0);
                obj.ProductID = dr.GetInt32(1);
                obj.StockQuantity = dr.GetDouble(2);
                obj.PurchasingCost = dr.GetDouble(3);
                obj.SellingPrice = dr.GetDouble(4);
                obj.Date = dr.GetString(5);

            }
            db.closeConnection();
            return obj;
        }

        public double Select_StockQuantity_by_StockID(int id)
        {
            DBconnection db = new DBconnection();

            db.openConnection();
            string query = "SELECT StockQuantity FROM Stock WHERE StockID = " + id;
            double quantity = 0;
            SQLiteDataReader dr = db.DataReader(query);
            while (dr.Read())
            {
                quantity = dr.GetDouble(0);
            }
            db.closeConnection();
            return quantity;
        }
        public int Select_ProductID_by_StockID(int id)
        {
            DBconnection db = new DBconnection();

            db.openConnection();
            string query = "SELECT ProductID FROM Stock WHERE StockID = " + id;
            int pid = 0;
            SQLiteDataReader dr = db.DataReader(query);
            while (dr.Read())
            {
                pid = dr.GetInt32(0);
            }
            db.closeConnection();
            return pid;
        }
       //to be change
      

        public double Select_ProductPrice_by_ProductID(int productID)
        {
            DBconnection db = new DBconnection();
            string query = "SELECT SellingPrice FROM Stock WHERE ProductID = " + productID;
            db.openConnection();
            SQLiteDataReader dr = db.DataReader(query);
            double price = 0;
            while (dr.Read())
            {
                price = dr.GetDouble(0);
            }
            db.closeConnection();
            return price;
        }

        public int Select_StockID_by_ProductName(string productName)
        {
            int productID = productDAO.Select_productID_by_productName(productName);
            DBconnection db = new DBconnection();
            string query = "SELECT StockID FROM Stock WHERE ProductID = " + productID;
            db.openConnection();
            SQLiteDataReader dr = db.DataReader(query);
            int stockID = 0;
            while (dr.Read())
            {
                stockID = dr.GetInt32(0);
            }
            db.closeConnection();
            return stockID;

        }

        //public int Select_ProductID_by_ProductName(string name)
        //{
        //    DBconnection db = new DBconnection();
        //    string query = "SELECT ProductID FROM Stocks WHERE ProductName = '" +name+"'";

        //    db.openConnection();
        //    SQLiteDataReader dr = db.DataReader(query);
        //    db.closeConnection();

        //}

        public void Update_Stock_tuple(Stock stock)
        {
            DBconnection db = new DBconnection();
            string query = "UPDATE Stock SET StockQuantity = " + stock.StockQuantity + " , PurchasingCost = "+stock.PurchasingCost+" , SellingPrice = "+stock.SellingPrice+ " WHERE StockID = "+stock.StockID;
            db.openConnection();
            db.ExecuteNonQueries(query);
            db.closeConnection();
        }

        public void Update_Stock_Quantity_by_StockID(double stockQuantity, int stockID)
        {
            DBconnection db = new DBconnection();
            string query = "UPDATE Stock SET StockQuantity = " + stockQuantity + " WHERE StockID = " + stockID;
            db.openConnection();
            db.ExecuteNonQueries(query);
            db.closeConnection();
        }

        public void Update_StockStatus()
        {
            DBconnection db = new DBconnection();
            string query = "UPDATE Stock SET StockStatus = 'OutofStock' WHERE StockQuantity <= 0 ";
            db.openConnection();
            db.ExecuteNonQueries(query);
            db.closeConnection();
        }

        public void Update_StockStatus_inStock()
        {
            DBconnection db = new DBconnection();
            string query = "UPDATE Stock SET StockStatus = 'InStock' WHERE StockQuantity > 0 ";
            db.openConnection();
            db.ExecuteNonQueries(query);
            db.closeConnection();
        }


        public void Delete_by_StockID(int StockID)
        {
            DBconnection db = new DBconnection();
            string query = "DELETE FROM Stock WHERE StockID = "+StockID;
            db.openConnection();
            db.ExecuteNonQueries(query);
            db.closeConnection();
        }
    }

}

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
    class ProductDAO
    {
        public void Insert_Product(string product_name)
        {
            
            DBconnection db = new DBconnection();
            string query = "INSERT INTO Product ( ProductName ) VALUES ('" + product_name + "')";
            db.openConnection();
            db.ExecuteNonQueries(query);
            db.closeConnection();
        }

        public int Select_ProductID()
        {
            DBconnection db = new DBconnection();
            List<Product> Products_List = new List<Product>();
            string query = "SELECT ProductID from Product where ProductID = (SELECT max(ProductID) FROM Product);";
            int id = 0;
            db.openConnection();
            SQLiteDataReader dr = db.DataReader(query);
            while(dr.Read())
            {
                 id = dr.GetInt32(0);
            }
            
            db.closeConnection();
            return id;
        }

        public List<Product> Select_products_by_productName(string name)
        {
            DBconnection db = new DBconnection();
            List<Product> Products_List = new List<Product>();
            string query = "SELECT * FROM Product Where ProductName = '" + name +"'";

            db.openConnection();
            SQLiteDataReader dr = db.DataReader(query);
            while (dr.Read())
            {
                Product obj = new Product();

                obj.ID = dr.GetInt32(0);
                obj.Product_Name = dr.GetString(1);

                Products_List.Add(obj);
            }
            db.closeConnection();
            return Products_List;
        }

        public int Select_productID_by_productName(string name)
        {
            DBconnection db = new DBconnection();
            List<Product> Products_List = new List<Product>();
            string query = "SELECT ProductID FROM Product Where ProductName = '" + name + "'";

            db.openConnection();
            SQLiteDataReader dr = db.DataReader(query);
            int id = 0;
            while (dr.Read())
            {
                id = dr.GetInt32(0);
            }
            db.closeConnection();
            return id;
        }
        public double Select_productQuantity_by_productID(int id)
        {
            DBconnection db = new DBconnection();
            List<Product> Products_List = new List<Product>();
            string query = "SELECT ProductQuantity FROM Product Where ProductID = " + id;

            db.openConnection();
            SQLiteDataReader dr = db.DataReader(query);
            double QTY = 0;
            while (dr.Read())
            {
                QTY = dr.GetDouble(0);
            }
            db.closeConnection();
            return QTY;
        }

        public string Select_ProductName_by_ProductID(int productID)
        {
            DBconnection db = new DBconnection();
            string query = "SELECT ProductName FROM Product WHERE ProductID = " + productID;
            db.openConnection();
            SQLiteDataReader dr = db.DataReader(query);
            string name = "";
            while (dr.Read())
            {
                name = dr.GetString(0);
            }
            db.closeConnection();
            return name;
        }



        public List<Product> Select_All_Products()
        {
            DBconnection db = new DBconnection();
            List<Product> Products_List = new List<Product>();
            string query = "SELECT * FROM Product";

            db.openConnection();
            SQLiteDataReader dr = db.DataReader(query);
            while (dr.Read())
            {
                Product obj = new Product();

                obj.ID = dr.GetInt32(0);
                obj.Product_Name = dr.GetString(1);

                Products_List.Add(obj);
            }
            db.closeConnection();
            return Products_List;
        }

        public List<string> Select_Product_Name()
        {
            DBconnection db = new DBconnection();
            string query = "SELECT ProductName FROM Product";
            List<string> product_name_list = new List<string>();

            db.openConnection();
            SQLiteDataReader dr = db.DataReader(query);
            while (dr.Read())
            {
                product_name_list.Add(dr.GetString(0));
            }
            db.closeConnection();
            return product_name_list;
        }

        public void Delete_by_id(int id)
        {
            DBconnection db = new DBconnection();          
            string query = "DELETE FROM Product WHERE ID = " + id;
            db.openConnection();
            db.ExecuteNonQueries(query);
            db.closeConnection();
        }
        public void update_productQuantity(double quantity , int pID)
        {
            DBconnection db = new DBconnection();
            string query = "Update Product Set ProductQuantity = " + quantity + " Where ProductID = " + pID;
            db.openConnection();
            db.ExecuteNonQueries(query);
            db.closeConnection();
        }
            
    }
}

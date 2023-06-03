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
    class SalesDAO
    {
        public void Insert_NewSales(int cID , string pName , double quantity , double total ,string date)
        {
            DBconnection db = new DBconnection();
            string query = "Insert into Sales (CustomerID , ProductName , ProductQuantity , Total , SalesDate) Values ( " +cID+ " , '" + pName + "' , " + quantity + " , " + total + " , '" + date +"')";
            db.openConnection();
            db.ExecuteNonQueries(query);
            db.closeConnection();
        }
        public List<Sales> Select_all_Sales()
        {
            DBconnection db = new DBconnection();
            List<Sales> sales = new List<Sales>();
            string query = "Select * from Sales";
            db.openConnection();
            SQLiteDataReader dr = db.DataReader(query);
            while (dr.Read())
            {
                Sales obj = new Sales();

                obj.SalesID = dr.GetInt32(0);
                obj.CustomerID = dr.GetInt32(1);
                obj.ProductName = dr.GetString(2);
                obj.ProductQuantity = dr.GetDouble(3);
                obj.Total = dr.GetDouble(4);
                obj.SalesDate = dr.GetString(5);

                sales.Add(obj);
            }

            return sales;
        }
        public List<Sales> Select_Sales_by_CustomerID(int id)
        {
            DBconnection db = new DBconnection();
            List<Sales> sales = new List<Sales>();
            string query = "Select * from Sales Where CustomerID = "+id;
            db.openConnection();
            SQLiteDataReader dr = db.DataReader(query);
            while(dr.Read())
            {
                Sales obj = new Sales();

                obj.SalesID = dr.GetInt32(0);
                obj.CustomerID = dr.GetInt32(1);
                obj.ProductName = dr.GetString(2);
                obj.ProductQuantity = dr.GetDouble(3);
                obj.Total = dr.GetDouble(4);
                obj.SalesDate = dr.GetString(5);

                sales.Add(obj);
            }

            return sales;
        }

        public List<Sales> Select_Sales_by_ProductName(string name)
        {
            DBconnection db = new DBconnection();
            List<Sales> sales = new List<Sales>();
            string query = "Select * from Sales Where ProductName = '" + name + "'";
            db.openConnection();
            SQLiteDataReader dr = db.DataReader(query);
            while (dr.Read())
            {
                Sales obj = new Sales();

                obj.SalesID = dr.GetInt32(0);
                obj.CustomerID = dr.GetInt32(1);
                obj.ProductName = dr.GetString(2);
                obj.ProductQuantity = dr.GetDouble(3);
                obj.Total = dr.GetDouble(4);
                obj.SalesDate = dr.GetString(5);

                sales.Add(obj);
            }

            return sales;
        }

        public List<Sales> Select_Sales_by_Date(string date)
        {
            DBconnection db = new DBconnection();
            List<Sales> sales = new List<Sales>();
            string query = "Select * from Sales Where SalesDate = '" + date + "'";
            db.openConnection();
            SQLiteDataReader dr = db.DataReader(query);
            while (dr.Read())
            {
                Sales obj = new Sales();

                obj.SalesID = dr.GetInt32(0);
                obj.CustomerID = dr.GetInt32(1);
                obj.ProductName = dr.GetString(2);
                obj.ProductQuantity = dr.GetDouble(3);
                obj.Total = dr.GetDouble(4);
                obj.SalesDate = dr.GetString(5);

                sales.Add(obj);
            }

            return sales;
        }
    }
}

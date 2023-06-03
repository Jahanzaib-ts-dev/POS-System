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
    class CustomerDAO
    {
        public void Insert_Customer(string cName , string tDate)
        {
            DBconnection db = new DBconnection();
            string query = "Insert into Customers (CustomerName , TransactionDate) Values ( '" + cName + "' , '" + tDate +"')";
            db.openConnection();
            db.ExecuteNonQueries(query);
            db.closeConnection();
        }
        public int Select_Last_CustomerID()
        {
            DBconnection db = new DBconnection();
            string query = "Select Max(CustomerID) from Customers";
            db.openConnection();
            SQLiteDataReader dr =  db.DataReader(query);
            int id = 0;
            while (dr.Read())
            {
                 id = dr.GetInt32(0);
            }
            
            db.closeConnection();
            return id;
        }

        public List<Customers> Select_Customers_by_Date(string date)
        {
            DBconnection db = new DBconnection();
            List<Customers> customers = new List<Customers>();
            string query = "Select * from Customers where TransactionDate = '" + date +"'";
            db.openConnection();
            SQLiteDataReader dr = db.DataReader(query);
            while(dr.Read())
            {
                Customers obj = new Customers();

                obj.CustomerID = dr.GetInt32(0);
                obj.CustomerName = dr.GetString(1);
                obj.TransactionDate = dr.GetString(2);

                customers.Add(obj);
            }
            return customers;

        }
    }
}

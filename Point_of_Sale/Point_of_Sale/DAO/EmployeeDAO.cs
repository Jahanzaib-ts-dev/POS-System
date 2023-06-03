using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_of_Sale.DBconnections;
using Point_of_Sale.Entities;

namespace Point_of_Sale.DAO
{
    class EmployeeDAO
    {
        
        public void Insert_Employee(string name , string role , string password , string date)
        {
            DBconnection db = new DBconnection();
            string query = "Insert into Employees ( Username , Role , Password , Date ) Values ('" + name + "' , '" + role + "' , '" + password + "' , '" + date +"' )";

            db.openConnection();
            db.ExecuteNonQueries(query);
            db.closeConnection();
        }

        public Employees Select_by_username_and_password(string username, string password)
        {
            DBconnection db = new DBconnection();
            string query = "Select * from Employees where Username = '" + username + "' AND Password = '" + password + "'";
            db.openConnection();
            SQLiteDataReader dr = db.DataReader(query);

            Employees employees = new Employees();

            while(dr.Read())
            {
                employees.EmployeeID = dr.GetInt32(0);
                employees.Username = dr.GetString(1);
                employees.Role = dr.GetString(2);
                employees.Password = dr.GetString(3);
            }
            db.closeConnection();
            if(employees.Username == null) { return null; }
            return employees;
        }
    }
}

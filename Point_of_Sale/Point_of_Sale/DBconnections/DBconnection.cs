using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale.DBconnections
{

    class DBconnection
    {
        SQLiteConnection conn;
        public void openConnection()
        {
            conn = new SQLiteConnection("Data Source = PointofSale.db");
            conn.Open();
        }

        public void closeConnection()
        {
            conn.Close();
        }
        public void ExecuteNonQueries(string query)
        {
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

        public SQLiteDataReader DataReader(string query)
        {
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SQLiteDataAdapter DataAdapter(string query)
        {
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            return adapter;
        }
    }
}

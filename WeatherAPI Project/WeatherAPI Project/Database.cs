using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace WeatherAPI_Project
{
    class Database
    {
        public SQLiteConnection connection;
        public Database()
        {

            connection = new SQLiteConnection("Data source = WeatherAPIDatabase.sqlite3"); //connection to the datasource
            if (!File.Exists("./WeatherAPIDatabase.sqlite3"))
            {
                SQLiteConnection.CreateFile("WeatherAPIDatabase.sqlite3");
                MessageBox.Show("Database Created");
            }
        }
        //class Meathod that opens connection to Sqlite Database
        public void Openconnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            else
            {
                //Do Nothing
            }

        }
        //Classe method that closes connection to the database
        public void Closeconnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            else
            {
                //Do nothing
            }
        }
    }
}

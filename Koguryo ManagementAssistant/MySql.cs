using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Koguryo_ManagementAssistant
{
    public class MySql
    {
        //to be changed upon compile
        private const String HOST = "127.0.0.1";
        private const String DATABASE = "kfmaa"; 
        private const String USER = "root";
        private const String PASS = "root";
        public static MySqlConnection dbConn;

        public static void InitializeDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = HOST;
            builder.UserID = USER;
            builder.Password = PASS;
            builder.Database = DATABASE;

            String connString = builder.ToString();

            builder = null;

            Console.WriteLine(connString);

            dbConn = new MySqlConnection(connString);

            Application.ApplicationExit += (sender, args) =>
            {
                if (dbConn != null)
                {
                    dbConn.Dispose();
                    dbConn = null;
                }
            };
        }


    }
}

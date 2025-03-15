using System;
using System.Data;
using MySqlConnector;

namespace MidProjectDb.BL
{
    public class DatabaseHelper
    {
        private string serverName = "127.0.0.1";
        private string port = "3306";
        private string databaseName = "midprojectdb";
        private string databaseUser = "root";
        private string databasePassword = "zain1234";

        private static DatabaseHelper _instance;
        private DatabaseHelper() { }

        public static DatabaseHelper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DatabaseHelper();
                return _instance;
            }
        }
        private MySqlConnection CreateConnection()
        {
            string connectionString =
                $"server={serverName};port={port};user={databaseUser};database={databaseName};password={databasePassword};AllowPublicKeyRetrieval=True;SslMode=none;";
            return new MySqlConnection(connectionString);
        }
        public DataTable GetData(string query)
        {
            DataTable dataTable = new DataTable();
            using (var connection = CreateConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                using (var adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }
        public int Update(string query)
        {
            int rowsAffected;
            using (var connection = CreateConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
    }
}

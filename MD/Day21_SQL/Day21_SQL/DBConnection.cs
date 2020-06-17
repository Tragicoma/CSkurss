using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace Day21_SQL
{
    class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;
        private string connectionString;
        private string sslM;


        public DBConnection()
        {
            server = "127.0.0.1";
            database = "ofiss";
            user = "root";
            password = "HerpDerp";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; " +
                "SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
        }
        public void Connect()
        {
            try
            {
                connection.Open();

                Console.WriteLine("Success");
             
                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void GetEmployees()
        {
            string stm = "SELECT employeeName, employeeLastName FROM employees";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            dataAdapter.SelectCommand = new MySqlCommand(stm, connection);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);


            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine(row.Field<String>(0) + " " + row.Field<String>(1));
            }
        }

        public void AddEmployee(string n, string ln, string dId, string id, string s)
        {

            try
            {
                connection.Open();
                MySqlCommand cmnd = new MySqlCommand();
                cmnd.Connection = connection;
                cmnd.CommandText = "INSERT INTO employees (employeeName, employeeLastName, departmentID,jobID,salary) " +
                    "VALUES(@employeeName,@employeeLastName,@departmentID,@jobID,@salary)";
                cmnd.Prepare();
                cmnd.Parameters.AddWithValue("@employeeName", n);
                cmnd.Parameters.AddWithValue("@employeeLastName", ln);
                cmnd.Parameters.AddWithValue("@jobID", id);
                cmnd.Parameters.AddWithValue("@departmentID", dId);
                cmnd.Parameters.AddWithValue("@salary", s);
                cmnd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

    }
}

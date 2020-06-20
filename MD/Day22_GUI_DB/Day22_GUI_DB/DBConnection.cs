using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Day22_GUI_DB
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

        public void GetEmployees(ListView listview,List<Employee> list)
        {
            string stm = "SELECT employeeId, employeeName, employeeLastName,departmentID,jobID,salary FROM employees";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            dataAdapter.SelectCommand = new MySqlCommand(stm, connection);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            listview.Items.Clear();
            list.Clear();

            foreach (DataRow row in table.Rows)
            {
                listview.Items.Add("(" +row.Field<int>(0)+")" +  " " + row.Field<string>(1) + " " + row.Field<string>(2));
                list.Add(new Employee(row.Field<int>(0), row.Field<string>(1), row.Field<string>(2), row.Field<int>(3), row.Field<int>(4), row.Field<int>(5)));
            }
        }

        public void AddEmployee(string n, string ln, string dId, string id, string s, List<Employee> list)
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
                RefreshList(list);
            }

            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public void RemoveEmployee(int id)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "DELETE from employees WHERE employeeId = " + id;
                cmd.ExecuteNonQuery();
            }

            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }


        public void RefreshList(List<Employee> list)
        {
            string stm = "SELECT employeeId, employeeName, employeeLastName,departmentID,jobID,salary FROM employees";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            dataAdapter.SelectCommand = new MySqlCommand(stm, connection);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            
            list.Clear();

            foreach (DataRow row in table.Rows)
            {
                list.Add(new Employee(row.Field<int>(0), row.Field<string>(1), row.Field<string>(2), row.Field<int>(3), row.Field<int>(4), row.Field<int>(5)));
                
            }
        }

        public void GetMinMax(Employee employee,int jobId)
        {
            string stm = "SELECT minSalary,maxSalary FROM jobs WHERE job jobID = " + jobId;
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            dataAdapter.SelectCommand = new MySqlCommand(stm, connection);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);

           
            foreach (DataRow row in table.Rows)
            {
                employee.SetMin(row.Field<int>(1));
                employee.SetMax(row.Field<int>(2));
            }
        }

    }

}


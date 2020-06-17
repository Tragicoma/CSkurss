using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Day21_Homework
{
    class DBStuff
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;
        private string connectionString;
        private string sslM;

        public DBStuff()
        {
            server = "127.0.0.1";
            database = "uni";
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

                Console.WriteLine("Connection Success");
                Console.WriteLine("------------------");

                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void GetStudents()
        {
            string stm = "SELECT studentName,studentSurname FROM students";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            dataAdapter.SelectCommand = new MySqlCommand(stm, connection);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);


            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine(row.Field<String>(0) + " " + row.Field<String>(1));
            }
        }

        public void AddStudent(Student student)
        {
            try
            {
                connection.Open();
                MySqlCommand cmnd = new MySqlCommand();
                cmnd.Connection = connection;
                cmnd.CommandText = "INSERT INTO students (studentName,studentSurname,studentCourse) " +
                    "VALUES(@studentName,@studentSurname,@studentCourse)";
                cmnd.Prepare();
                cmnd.Parameters.AddWithValue("@studentName", student.getName());
                cmnd.Parameters.AddWithValue("@studentSurname", student.getSurname());
                cmnd.Parameters.AddWithValue("@studentCourse", student.getCourse());
                cmnd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public void DeleteById(int id)
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM students WHERE studentId = " + id;
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
    }
}

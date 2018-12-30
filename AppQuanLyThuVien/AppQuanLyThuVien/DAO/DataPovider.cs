using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LB.DAO
{
    class DataPovider
    {


        private static DataPovider instance;
        private string connectionString = "Data Source=DESKTOP-R5U5ONO\\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True";

        public static DataPovider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataPovider();
                }
                return instance;
            }
            private set => instance = value;
        }
        private DataPovider() { }
        public DataTable ExcuteQuery(string query)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
            }
            return table;
        }
        public int ExcuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
        public int ExcuteScalarInt(string query)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                data = (int)command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
        public string ExcuteScalarString(string query)
        {
            string data = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                data = command.ExecuteScalar().ToString();
                connection.Close();
            }
            return data;
        }
    }
}

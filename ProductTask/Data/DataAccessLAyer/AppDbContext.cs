using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataAccessLAyer
{
    public class AppDbContext
    {

        string connection = "Server=HUAWEI;Database=ProductDb;Trusted_Connection=true;";
        public SqlConnection sqlConnection;

        public AppDbContext()
        {
            sqlConnection = new SqlConnection(connection);
        }

        public void NonQuery(string command)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            var result = sqlCommand.ExecuteNonQuery();

            if (result > 0)
            {
                Console.WriteLine($"Completed successfully: {result}");
            }
            else
            {
                Console.WriteLine("Something went wrong!");
            }
            sqlConnection.Close();
        }

        public DataTable Query(string selectCommand)
        {
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
    }
        
}

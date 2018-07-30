using StockManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DAL
{
    class CompanyRepository
    {
        private static string connectionString = @"server=DESKTOP-S6EBN26\SQLEXPRESS; database=SMS_BITM; integrated security=true;";

        SqlConnection _connection = new SqlConnection(connectionString);
        public bool Add(Company company)
        {
            string query = @"INSERT INTO [dbo].[Companies]  ([Name]) VALUES('" + category.Name + "')";

            SqlCommand command = new SqlCommand(query, _connection);

            _connection.Open();

            bool isAdded = command.ExecuteNonQuery() > 0;

            _connection.Close();

            if (isAdded)
            {
                return true;
            }
            return false;
        }

        public DataTable GetCompanies()
        {
            string query = @"SELECT * FROM AllCompanies";

            SqlCommand command = new SqlCommand(query, _connection);

            _connection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            _connection.Close();

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }
    }
}

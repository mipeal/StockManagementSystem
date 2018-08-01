using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Models;

namespace StockManagementSystem.DAL
{
    class CategoryRepository
    {
        private static string _connectionString = @"server=PC-301-04\SQLEXPRESS; database=SMS_BITM; integrated security=true;";

        SqlConnection _connection = new SqlConnection(_connectionString);
        public bool Add(Category category)
        {
            string query = @"INSERT INTO [dbo].[Categories]  ([Name]) VALUES('" + category.Name + "')";

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

        public DataTable GetCategories()
        {
            string query = @"SELECT * FROM Categories";

            SqlCommand command = new SqlCommand(query, _connection);

            _connection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            _connection.Close();

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }

        public bool Update(Category category)
        {
            string query = @"UPDATE [dbo].[Categories] SET [Name] ='"+category.Name+"' WHERE [Id]='"+category.Id+"'";

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
    }
}

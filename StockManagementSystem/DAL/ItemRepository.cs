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
    class ItemRepository
    {
        private static string _connectionString = @"server=DESKTOP-S6EBN26\SQLEXPRESS; database=SMS_BITM; integrated security=true;";

        SqlConnection _connection = new SqlConnection(_connectionString);

   

        public bool Add(Item item)
        {

            string query = @"INSERT INTO [dbo].[Items] ([Name],[ReOrderLevel],[CompanyId],[CategoryId])   VALUES('" + item.Name + "','" + item.ReOrderLevel + "','" + item.CompanyId + "','" + item.CategoryId + "')";

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

        public DataTable GetItems(int categoryId, int companyID)
        {
            string query = @"SELECT * FROM Items WHERE CategoryId ='"+categoryId+"' and CompanyId ='"+companyID+"'";

            SqlCommand command = new SqlCommand(query, _connection);

            _connection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            _connection.Close();

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }


        public DataTable GetItemsByCompany(int id)
        {
             string query = @"SELECT * FROM Items WHERE CompanyId ='" + id + "'";            
                          

            SqlCommand command = new SqlCommand(query, _connection);

            _connection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            _connection.Close();

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }
        public DataTable GetItemsByCategory(int id)
        {
            string query = @"SELECT * FROM Items WHERE CategoryId ='" + id + "'";


            SqlCommand command = new SqlCommand(query, _connection);

            _connection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            _connection.Close();

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }
        public DataTable GetItems()
        {
            string query = @"SELECT * FROM Items";

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

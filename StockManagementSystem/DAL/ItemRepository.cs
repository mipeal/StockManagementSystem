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
        private static string _connectionString = @"server=PC-301-04\SQLEXPRESS; database=SMS_BITM; integrated security=true;";

        SqlConnection _connection = new SqlConnection(_connectionString);

        public List<Category> GetCategories(List<Category> categories)
        {
            string query = @"SELECT * FROM Categories";

            SqlCommand command = new SqlCommand(query, _connection);

            _connection.Open();

            SqlDataReader dataReader = command.ExecuteReader();

            
            while (dataReader.Read())
            {
                Category category = new Category();
                category.Id = Convert.ToInt32(dataReader["Id"]);
                category.Name = dataReader["Name"].ToString();
                categories.Add(category);
            }

            _connection.Close();

            return categories;
        }

        public List<Company> GetCompanies(List<Company> companies)
        {
            string query = @"SELECT * FROM Companies";

            SqlCommand command = new SqlCommand(query, _connection);

            _connection.Open();

            SqlDataReader dataReader = command.ExecuteReader();


            while (dataReader.Read())
            {
                Company company =new Company();
                company.Id = Convert.ToInt32(dataReader["Id"]);
                company.Name = dataReader["Name"].ToString();
                companies.Add(company);
            }

            _connection.Close();

            return companies;
        }

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
    }
}

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
    class LoginRepository
    {
        private static string _connectionString = @"server=DESKTOP-S6EBN26\SQLEXPRESS; database=SMS_BITM; integrated security=true;";

        SqlConnection _connection = new SqlConnection(_connectionString);

        public bool CheckCredential(User user)
        {
            string query = @"SELECT * FROM Items USERS Username ='" + user.Username + "' and Password = '" + user.Password + "'";


            SqlCommand command = new SqlCommand(query, _connection);

            _connection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            _connection.Close();

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
    }
}

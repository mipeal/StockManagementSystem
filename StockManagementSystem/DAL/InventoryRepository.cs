using StockManagementSystem.Models.InventoryModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DAL
{
    class InventoryRepository
    {
        private static string _connectionString = @"server=DESKTOP-S6EBN26\SQLEXPRESS; database=SMS_BITM; integrated security=true;";

        SqlConnection _connection = new SqlConnection(_connectionString);


        public DataSet GetItemInventory(int itemId)
        {
            string query = @"SELECT * FROM V_GetAllItemInventory WHERE ItemId ='" + itemId + "'";


            SqlCommand command = new SqlCommand(query, _connection);

            _connection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            _connection.Close();

            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataSet);

            return dataSet;
        }

        public bool AddStockIn(Inventory item)
        {
            string query = @"INSERT INTO [dbo].[Inventory]  ([ItemId],[StockAvailable],[StockTransaction],[StockType],[TransactionDate])
                     VALUES ('" + item.ItemId + "','" + item.StockAvailable + "','" + item.StockTransaction + "','" + item.StockType + "','" + item.TransactionDate + "')";

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

        public bool AddStockOut(Inventory item)
        {

            string query = @"INSERT INTO [dbo].[Inventory]  ([ItemId],[StockAvailable],[StockTransaction],[StockType],[StockOutType],[TransactionDate])
                     VALUES ('" + item.ItemId + "','" + item.StockAvailable + "','" + item.StockTransaction + "','" + item.StockType + "','" + item.StockOutType + "','" + item.TransactionDate + "')";

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

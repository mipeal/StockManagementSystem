using StockManagementSystem.Models;
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

        public DataTable ViewSaleSummary(string fromDate, string toDate)
        {
            string query = @"  SELECT ItemName AS Name,  SUM(StockTransaction) AS [Sale Quantity]  FROM V_GetAllItemInventory  WHERE StockOutType = 1 AND TransactionDate BETWEEN '" + fromDate + "' AND '" + toDate + "'  GROUP BY ItemName";


            SqlCommand command = new SqlCommand(query, _connection);

            _connection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            _connection.Close();


            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataSet GetStockBalance(int itemId)
        {
            string query = @"SELECT top 1 StockAvailable FROM Inventory WHERE ItemId ='" + itemId + "' ORDER BY TransactionDate DESC";


            SqlCommand command = new SqlCommand(query, _connection);

            _connection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            _connection.Close();

            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataSet);

            return dataSet;
        }

        public DataTable SearchItemsSummaryByCategoryId(int categoryId)
        {
            string query = @"  SELECT Id,Name,Company,Category,[Available Quantity],[Reorder Level] FROM V_GetAllItemSummary WHERE CategoryId ='" + categoryId + "'";


            SqlCommand command = new SqlCommand(query, _connection);

            _connection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            _connection.Close();


            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }
        public DataTable SearchItemsSummaryByCompanyId(int companyId)
        {
            string query = @"  SELECT Id,Name,Company,Category,[Available Quantity],[Reorder Level] FROM V_GetAllItemSummary WHERE CompanyId ='" + companyId + "'";


            SqlCommand command = new SqlCommand(query, _connection);

            _connection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            _connection.Close();

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable SearchItemsSummary(int categoryId, int companyId)
        {
            string query = @"  SELECT Id,Name,Company,Category,[Available Quantity],[Reorder Level] FROM V_GetAllItemSummary WHERE CategoryId ='" + categoryId + "' AND CompanyId ='" + companyId + "'";


            SqlCommand command = new SqlCommand(query, _connection);

            _connection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            _connection.Close();

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            return dataTable;
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

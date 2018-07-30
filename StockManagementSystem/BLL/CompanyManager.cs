using StockManagementSystem.DAL;
using StockManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.BLL
{
    class CompanyManager
    {
        CompanyRepository _repository = new CompanyRepository();
        public bool Add(Company company )
        {
            if (company == null && company.Name.Length < 2)
            {
                throw new Exception("Sorry, Invalid Name Inserted!");
            }

            bool isAdded = _repository.Add(company);
            return isAdded;

        }

        public DataTable GetCompanies()
        {
            DataTable dataTable = _repository.GetCompanies();
            return dataTable;
        }
    }
}

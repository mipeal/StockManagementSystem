using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DAL;
using StockManagementSystem.Models;

namespace StockManagementSystem.BLL
{
    class LoginManager
    {
        LoginRepository _repository = new LoginRepository();
        public bool CheckCredential(User user)
        {
            if (user == null && user.Username.Length < 3 && user.Password.Length<8)
            {
                throw new Exception("Sorry, Invalid Credential Inserted!");
            }

            bool isChecked = _repository.CheckCredential(user);
            return isChecked;
        }
    }
}

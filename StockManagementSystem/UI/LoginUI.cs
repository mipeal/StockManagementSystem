using StockManagementSystem.BLL;
using StockManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.UI
{
    public partial class LoginUI : Form
    {
        User user = new User();
        LoginManager _loginManager = new LoginManager();
        public LoginUI()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            user.Username = usernameTextBox.Text;
            if (user.Username == String.Empty)
            {
                errorProvider.SetError(usernameTextBox, "Invalid credential provided!");
                return;
            }
            user.Password = passwordTextBox.Text;
            if (user.Password == String.Empty)
            {
                errorProvider.SetError(passwordTextBox, "Invalid credential provided!");
                return;
            }

            bool isChecked = _loginManager.CheckCredential(user);
            if (isChecked)
            {
                Reset(this.Controls);
                MessageBox.Show("Successfully Logged In!");
                Index index = new Index();
                index.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Connection Time-Out!");
            }
        }
        private void Reset(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                    tb.Text = "";
                else
                    Reset(ctrl.Controls);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trial2.Repo.Models;

namespace Trial2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                MessageBox.Show("Please Input username!");
            }
            else if (txtPassword.Text == "")
            {                    
                MessageBox.Show("Please input password!");
            }
            else
            {
                string cs = Program.connectionString;
                using (var db = new EmployeeJobTitleContext(cs))
                {
                    var user = db.Dbaccounts.Where(a => a.AccountId == txtUsername.Text
                    && a.AccountPassword == txtPassword.Text).FirstOrDefault();
                    if(user == null)
                    {
                        MessageBox.Show("Invalid username or password!");
                    }
                    else
                    {
                        //Correct username and password ==> check role
                        if(user.AccountRole == 1)
                        {
                            Form1 form1 = new Form1();
                            form1.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("You are not allowed to access this function!");
                        }
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trial2.Repo.Models;

namespace Trial2
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
            LoadJobTitle();
        }

        private void LoadJobTitle()
        {
            using (var db = new EmployeeJobTitleContext(Program.connectionString))
            {
                
                txtJobId.DisplayMember = "JobTitleName";
                txtJobId.ValueMember = "JobTitleID";
                txtJobId.DataSource = db.JobTitles.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckValid())
            {
                if (!CheckDuplicateId(txtEmpId.Text))
                {
                    using (var db = new EmployeeJobTitleContext(Program.connectionString))
                    {
                        var emp = new Employee()
                        {
                            EmployeeId = txtEmpId.Text,
                            EmployeeName = txtEmpName.Text,
                            DepartmentName = txtDeptName.Text,
                            YearOfBirth = (int)NumberYoB.Value,
                            JobTitleId = txtJobId.SelectedValue.ToString()
                        };
                        db.Employees.Add(emp);
                        db.SaveChanges();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("EmpId is duplicated!");
                }
            }
            else
            {
                MessageBox.Show("Your input data is not valid!");
            }
        }

        private bool CheckValid()
        {
            if (txtEmpId.Text == "" || txtEmpName.Text == "" || txtDeptName.Text == "")
                return false;
            if (NumberYoB.Value < 1960 || NumberYoB.Value > 2002)
                return false;
            if (txtEmpName.Text.Length < 10)
                return false;
            var words = txtEmpName.Text.Split();
            foreach(var w in words)
            {
                if (!char.IsUpper(w[0]))
                    return false;
            }

            return true;
        }

        private bool CheckDuplicateId(string empId)
        {
            using (var db = new EmployeeJobTitleContext(Program.connectionString))
            {
                if(db.Employees.Find(empId) == null)
                {
                    //not found
                    return false;
                }
                return true;
            }
        }
    }
}

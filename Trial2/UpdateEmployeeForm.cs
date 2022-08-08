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
    public partial class UpdateEmployeeForm : Form
    {
        public Employee employee { get; set; }
        public UpdateEmployeeForm()
        {
            InitializeComponent();
            LoadJobTitle();
            LoadOldData();
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

        private void LoadOldData()
        {
            Form1 frm = (Form1)Application.OpenForms["Form1"];
            var view1 = frm.dataGridView1.SelectedRows[0];
            txtEmpId.Text = view1.Cells["EmployeeID"].Value.ToString();
            txtEmpName.Text = view1.Cells["EmployeeName"].Value.ToString();
            NumberYoB.Value = (int)view1.Cells["YearOfBirth"].Value;
            txtDeptName.Text = view1.Cells["DepartmentName"].Value.ToString();
            txtJobId.Text = view1.Cells["JobTitleID"].Value.ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckValid())
            {
                if (CheckDuplicateId(txtEmpId.Text))
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
                        db.Employees.Update(emp);
                        db.SaveChanges();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("There is no such employee Id");
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
            foreach (var w in words)
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
                if (db.Employees.Find(empId) == null)
                {
                    //not found
                    return false;
                }
                return true;
            }
        }
        /*
         * EmployeeId = view1.Cells["EmployeeID"].Value.ToString(),
                EmployeeName = view1.Cells["EmployeeName"].Value.ToString(),
                YearOfBirth = (int)view1.Cells["YearOfBirth"].Value,
                DepartmentName = view1.Cells["DepartmentName"].Value.ToString(),
                JobTitleId = view1.Cells["JobTitleID"].Value.ToString()
private void btnDelete_Click(object sender, EventArgs e)
{
   if(dataGridView1.SelectedRows.Count > 0)
   {
       string empId = dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value.ToString();
       using (var db = new EmployeeJobTitleContext(Program.connectionString))
       {
           var deleteEmp = db.Employees.Find(empId);
           if(deleteEmp != null)
           {
               db.Employees.Remove(deleteEmp);
               db.SaveChanges();
           }

           LoadData();
       }
   }
   else
   {
       MessageBox.Show("Please select item to delete!");
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
*/
    }
}

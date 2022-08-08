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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoadData()
        {
            using (var db = new EmployeeJobTitleContext(Program.connectionString))
            {
                dataGridView1.DataSource = db.Employees.ToList();
            }
        }

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
            using (var db = new EmployeeJobTitleContext(Program.connectionString))
            {
                try
                {
                    if (dataGridView1.Rows[0].Cells["EmployeeName"] != null)
                    {
                        AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
                        addEmployeeForm.ShowDialog();
                        //Load data after dialog closed
                        LoadData();
                    };
                }catch(Exception ex1)
                {
                    try
                    {
                        if (dataGridView1.Rows[0].Cells["AccountID"] != null)
                        {
                            AddDbAccountForm addDbAccountForm = new AddDbAccountForm();
                            addDbAccountForm.ShowDialog();
                            //Load data after dialog closed
                            LoadData();
                        };
                    }catch(Exception ex2)
                    {

                    }
                }
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateEmployeeForm updateEmployeeForm = new UpdateEmployeeForm();
            
            
            updateEmployeeForm.ShowDialog();
            LoadData();
        }

        private void dbAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void jobTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dbAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var db = new EmployeeJobTitleContext(Program.connectionString))
            {
                dataGridView1.DataSource = db.Dbaccounts.ToList();
            }
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var db = new EmployeeJobTitleContext(Program.connectionString))
            {
                dataGridView1.DataSource = db.Employees.ToList();
            }
        }

        private void jobTitleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var db = new EmployeeJobTitleContext(Program.connectionString))
            {
                dataGridView1.DataSource = db.JobTitles.ToList();
            }
        }
    }
}

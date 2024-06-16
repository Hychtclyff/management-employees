using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using EmployeeManagementSystem.Class;

namespace EmployeeManagementSystem.Ui.Components
{
    public partial class Salary : UserControl
    {


        public Salary()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Salary_Load(object sender, EventArgs e)
        {
            LoadSalaries();
        }
        public void LoadSalaries()
        {
            DataTable dt = new DataTable();
            dt = SalaryData.SelectAll();
            dtSalaries.AutoGenerateColumns = false;
            dtSalaries.DataSource = dt;
            dtSalaries.Show();

        }

        private void salary_updateBtn_Click(object sender, EventArgs e)
        {
            SalaryData salary = new SalaryData(Convert.ToInt16(salary_employeeID.Text), Convert.ToDecimal(salary_salary.Text));

            if (salary.update() == 1)
            {
                MessageBox.Show("Update employee sukses");
            }
            else
            {
                MessageBox.Show("Update employee gagal");
            }
            LoadSalaries();


        }

        private void dtSalaries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtSalaries.Rows[e.RowIndex].Cells[0].Value != null)
            {
                salary_employeeID.Text = dtSalaries.Rows[e.RowIndex].Cells[0].Value.ToString();
                salary_name.Text = dtSalaries.Rows[e.RowIndex].Cells[1].Value.ToString();
             salary_position.Text = dtSalaries.Rows[e.RowIndex].Cells[2].Value.ToString();
                salary_salary.Text = dtSalaries.Rows[e.RowIndex].Cells[3].Value.ToString();





            }
            salary_salary.Enabled = true;
        }

        private void salary_clearBtn_Click(object sender, EventArgs e)
        {
            salary_employeeID.Text = string.Empty;
            salary_name.Text = string.Empty;
            salary_position.Text = string.Empty;
            salary_salary.Text = string.Empty;


            salary_salary.Enabled = false;

        }
    }
}

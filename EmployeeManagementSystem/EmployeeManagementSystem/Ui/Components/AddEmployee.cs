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
using System.IO;
using EmployeeManagementSystem.Class;

namespace EmployeeManagementSystem.Ui.Components
{
    public partial class AddEmployee : UserControl
    {

        bool _stateItem = false;
        public AddEmployee()
        {
            InitializeComponent();



        }

        private void addEmployee_addBtn_Click(object sender, EventArgs e)
        {
            addEmployee_id.Enabled = true;
            addEmployee_fullName.Enabled = true;
            addEmployee_gender.Enabled = true;
            addEmployee_phoneNum.Enabled = true;
            addEmployee_position.Enabled = true;
            addEmployee_status.Enabled = true;


            addEmployee_id.Text = string.Empty;
            addEmployee_fullName.Text = string.Empty;
            addEmployee_gender.Text = string.Empty;
            addEmployee_phoneNum.Text = string.Empty;
            addEmployee_position.Text = string.Empty;
            addEmployee_status.Text = string.Empty;

            save_btn.Enabled = true;
            create_btn.Enabled = false;
            update_btn.Enabled = false;
            delete_btn.Enabled = false;
          

            _stateItem = true;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees( Convert.ToInt32(addEmployee_id.Text),addEmployee_fullName.Text, addEmployee_gender.Text, addEmployee_phoneNum.Text, addEmployee_position.Text, addEmployee_status.Text);

            if (_stateItem)
            {
                if (emp.insert() == 1)
                {
                    MessageBox.Show("Insert employee sukses");
                }
                else
                {
                    MessageBox.Show("Insert employee gagal");
                }
            }
            else
            {
                if (emp.update() == 1)
                {
                    MessageBox.Show("Update employee sukses");
                }
                else
                {
                    MessageBox.Show("Update employee gagal");
                }
            }

            LoadEmployees();
            ResetEnable();

        }

        public void LoadEmployees()
        {
            DataTable dt = new DataTable();
            dt = Employees.SelectAll();
            dtEmployees.AutoGenerateColumns = false;
            dtEmployees.DataSource = dt;
            dtEmployees.Show();
        }

        public void ResetEnable()
        {
            addEmployee_id.Enabled = false;
            addEmployee_fullName.Enabled = false;
            addEmployee_gender.Enabled = false;
            addEmployee_phoneNum.Enabled = false;
            addEmployee_position.Enabled = false;
            addEmployee_status.Enabled = false;


            addEmployee_id.Text = string.Empty;
            addEmployee_fullName.Text = string.Empty;
            addEmployee_gender.Text = string.Empty;
            addEmployee_phoneNum.Text = string.Empty;
            addEmployee_position.Text = string.Empty;
            addEmployee_status.Text = string.Empty;

            save_btn.Enabled = false;
            create_btn.Enabled = true;
            update_btn.Enabled = true;
            delete_btn.Enabled = true;
          

            _stateItem = false;
        }

        private void addEmployee_clearBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            addEmployee_id.Enabled = true;
            addEmployee_fullName.Enabled = true;
            addEmployee_gender.Enabled = true;
            addEmployee_phoneNum.Enabled = true;
            addEmployee_position.Enabled = true;
            addEmployee_status.Enabled = true;


         

            save_btn.Enabled = true;
            create_btn.Enabled = false;
            update_btn.Enabled = false;
            delete_btn.Enabled = false;


            _stateItem = false;
        }

        private void dtEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtEmployees.Rows[e.RowIndex].Cells[0].Value != null)
            {
                addEmployee_id.Text = dtEmployees.Rows[e.RowIndex].Cells[0].Value.ToString();
                addEmployee_fullName.Text = dtEmployees.Rows[e.RowIndex].Cells[1].Value.ToString();
                addEmployee_gender.Text = dtEmployees.Rows[e.RowIndex].Cells[2].Value.ToString();
                addEmployee_phoneNum.Text = dtEmployees.Rows[e.RowIndex].Cells[3].Value.ToString();
                addEmployee_position.Text = dtEmployees.Rows[e.RowIndex].Cells[4].Value.ToString();
                addEmployee_status.Text = dtEmployees.Rows[e.RowIndex].Cells[5].Value.ToString();



            }
            create_btn.Enabled = false;
            update_btn.Enabled = true;
            delete_btn.Enabled = true;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees(Convert.ToInt32(addEmployee_id.Text),addEmployee_fullName.Text, addEmployee_gender.Text, addEmployee_phoneNum.Text, addEmployee_position.Text, addEmployee_status.Text);
            if (emp.delete() == 1)
            {
                MessageBox.Show("delete employee sukses");
            }
            else
            {
                MessageBox.Show("delete employee gagal");
            }
            LoadEmployees();
            ResetEnable();
        }
    }
    
}

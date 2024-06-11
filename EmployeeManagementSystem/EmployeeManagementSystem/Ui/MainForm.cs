using EmployeeManagementSystem.Ui.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace EmployeeManagementSystem.Ui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?"
                , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
        }

       


        private void salary_btn_Click_1(object sender, EventArgs e)
        {
            //userControl11.Visible = false;
            //  userControl21.Visible = true;
            //  userControl31.Visible = false;

            // UserControl2 addEmForm = userControl21 as UserControl2;

        }

        private void addEmployee_btn_Click(object sender, EventArgs e)
        {
             dashboard1.Visible = false;
             addEmployee1.Visible = true;
             //salary.Visible = true;

             AddEmployee employee = addEmployee1 as AddEmployee;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addEmployee1.Visible = false;

            Dashboard dashboard = dashboard1 as Dashboard;
        }
    }
}


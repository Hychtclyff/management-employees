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
using EmployeeManagementSystem.Assets;

namespace EmployeeManagementSystem.Ui
{
    public partial class Login : Form
    {



        public Login()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            if (user.getUsers(text_username.Text, text_password.Text))
            {
                MessageBox.Show("Login Berhasil");
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login gagal");
                text_username.Text = string.Empty;
                text_password.Text = string.Empty;
            }
        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            text_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }
    }
}

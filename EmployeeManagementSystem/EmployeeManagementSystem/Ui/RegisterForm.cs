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
    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();
        }




        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_loginBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signup_btn_Click_1(object sender, EventArgs e)
        {
            Users user = new Users();
            if (user.register(txt_reg_username.Text, txt_reg_password.Text))
            {
                MessageBox.Show("Register Berhasil");
                Login login = new Login();
                login.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login gagal");
                txt_reg_username.Text = string.Empty;
                txt_reg_password.Text = string.Empty;
            }
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txt_reg_password.PasswordChar = signup_showPass.Checked ? '\0' : '*';
        }
    }
}


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace EmployeeManagementSystem.Assets
{
    internal class Users
    {

        protected const String conString = "server=localhost;database=management_employe;uid=root;pwd=;";
        public bool getUsers(string usr, string pwd)
        {
            bool val = false;
            MySqlConnection connect = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username='" +     //mengatur perintah users
                usr + "' AND password='" + pwd + "'");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;

            try
            {
                connect.Open();
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    val = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }

            }
            return val;
        }

        public bool register(string username, string password)
        {
            bool result = false;
            MySqlConnection connect = new MySqlConnection(conString);

            string query = "INSERT INTO users (username, password) VALUES (@username, @password)";
            MySqlCommand cmd = new MySqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;
            try
            {
                connect.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                result = rowsAffected > 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return result;
        }

    }
}

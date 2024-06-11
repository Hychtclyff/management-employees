using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Class
{
    internal class Employees
    {
        int id;
        string name;
        string gender;
        string phone;
        string position;

        string status;

        protected const String consString = "server=localhost;database=management_employe;uid=root;pwd=;";


        public Employees(int id, string name, string gender, string phone,string position, string status)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;   
            this.phone = phone;
            this.position = position; 
            this.status = status;
        }
        public static DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            MySqlConnection connect = new MySqlConnection(consString);
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM employees", connect))
            {

                try
                {
                    connect.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                }
                catch (Exception e)
                {
                    string error = e.Message;

                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
            return dt;

        }
        public int insert()
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(consString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO employees (id,name,gender,phone,position,status) VALUES(@id,@name,@gender,@phone,@position,@status)");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@position", position);
            cmd.Parameters.AddWithValue("@status", status);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;
            try
            {
                connect.Open();
                result = cmd.ExecuteNonQuery();
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
        public int delete()
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(consString);
            MySqlCommand cmd = new MySqlCommand("DELETE FROM employees WHERE id = @id");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;
            try
            {
                connect.Open();
                result = cmd.ExecuteNonQuery();
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

        public int update()
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(consString);
            MySqlCommand cmd = new MySqlCommand("UPDATE employees SET name = @name, gender = @gender, phone = @phone, position = @position, status = @status WHERE id = @id");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@position", position);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;
            try
            {
                connect.Open();
                result = cmd.ExecuteNonQuery();
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

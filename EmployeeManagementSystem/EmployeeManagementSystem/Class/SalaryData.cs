using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EmployeeManagementSystem
{
    class SalaryData
    {
        int id;
        decimal salary;
        public SalaryData(int id, decimal salary)
        {
            this.id = id;
            this.salary = salary;   
        }

        protected const String conString = "server=localhost;database=management_employe;uid=root;pwd=;";
        public static DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            MySqlConnection connect = new MySqlConnection(conString);
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
        public int update()
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("UPDATE employees SET salary = @salary WHERE id = @id");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@salary", salary);


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

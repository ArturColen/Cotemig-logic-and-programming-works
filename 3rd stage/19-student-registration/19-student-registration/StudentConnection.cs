using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace _19_student_registration
{
    internal class StudentConnection
    {
        MySqlConnection connection;

        public void ConnectDatabase()
        {
            try
            {
                connection = new MySqlConnection("Persist Security info = false; server = localhost;" + "database = school; user = root; pwd = root;");
                connection.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ExecuteCommands(string sql)
        {
            try
            {
                ConnectDatabase();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable ExecuteQuery(string sql)
        {
            try
            {
                ConnectDatabase();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

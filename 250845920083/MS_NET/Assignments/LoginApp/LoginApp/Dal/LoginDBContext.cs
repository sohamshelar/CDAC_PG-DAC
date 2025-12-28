using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginApp.Dal
{
    public class LoginDBContext
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Dac83;Integrated Security=True";

        internal bool validateUser(string? username, string? password)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            String selectQuery = "SELECT COUNT(1) FROM users WHERE username = @username AND password = @password";

            SqlCommand cmd = new SqlCommand(selectQuery, conn);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            conn.Open();

            int count = (int)cmd.ExecuteScalar();

            conn.Close();

            return count > 0;
        }

        internal bool registerUser(string? username, string? password)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            string insertQuery ="insert into users (username ,password) values (@username ,@password)";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);

            cmd.Parameters.AddWithValue("@username",username);
            cmd.Parameters.AddWithValue("@password", password);

            conn.Open();

            int rowAffected=cmd.ExecuteNonQuery();

            conn.Close();
            return rowAffected > 0;
        }

        internal bool checkUsername(string? username)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            String selectQuery = "SELECT COUNT(1) FROM users WHERE username = @username";

            SqlCommand cmd = new SqlCommand(selectQuery, conn);

            cmd.Parameters.AddWithValue("@username", username);

            conn.Open();

            int count = (int)cmd.ExecuteScalar();

            conn.Close();

            return count > 0;

        }

        internal bool updatePassword(string? username, string? newPassword)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            String updateQuery = "UPDATE users SET password = @password WHERE username = @username";

            SqlCommand cmd = new SqlCommand(updateQuery, conn);

            cmd.Parameters.AddWithValue("@password", newPassword);
            cmd.Parameters.AddWithValue("@username", username);

            conn.Open();

            int rowAffected = cmd.ExecuteNonQuery();

            conn.Close();

            return rowAffected > 0;
        }
    }
}

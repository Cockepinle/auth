using System;
using System.Data.SqlClient;

namespace Authorizations
{
    public class UsersRepository
    {
        private string connectionString = "Server=Cockepinle\\SQLEXPRESS;Database=Test;Integrated Security=True;";

        public bool Authenticate(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM Users WHERE logins = @login AND passwords = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());
                return count == 1;
            }
        }
    }
}

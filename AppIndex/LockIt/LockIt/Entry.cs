using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace LockIt
{
    internal class Entry
    {
        private string connectionString = "Server=127.0.0.1;Port=6033;Database=LockIt_Database;User ID=root;Password=root;";

        public int AuthenticateUser(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT user_id, password FROM t_user WHERE username = @Username";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedHashedPassword = reader["password"].ToString();
                        if (BCrypt.Net.BCrypt.Verify(password, storedHashedPassword))
                        {
                            return Convert.ToInt32(reader["user_id"]);
                        }
                    }
                }
            }
            return -1; // Retourne -1 si l'authentification échoue
        }
        public DataTable GetPasswords(int userId)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT title, username, password FROM t_entry WHERE user_id = @UserId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserId", userId);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }
        public void AddPassword(int userId, string title, string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                string query = "INSERT INTO t_entry (title, username, password, user_id) VALUES (@Title, @Username, @Password, @UserId)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdatePassword(int userId, string title, string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                string query = "UPDATE t_entry SET username = @Username, password = @Password WHERE user_id = @UserId AND title = @Title";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.ExecuteNonQuery();
            }
        }
        public void DeletePassword(int userId, string title)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM t_entry WHERE user_id = @UserId AND title = @Title";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Erreur lors de la suppression du mot de passe: " + ex.Message);
                }
            }
        }

        public bool RegisterUser(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Vérifie si l'utilisateur existe déjà
                    string checkQuery = "SELECT COUNT(*) FROM t_user WHERE username = @Username";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@Username", username);
                    int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (userExists > 0)
                    {
                        // L'utilisateur existe déjà
                        return false;
                    }


                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                    // Insère le nouvel utilisateur
                    string insertQuery = "INSERT INTO t_user (username, password) VALUES (@Username, @Password)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                    insertCmd.Parameters.AddWithValue("@Username", username);
                    insertCmd.Parameters.AddWithValue("@Password", hashedPassword);
                    insertCmd.ExecuteNonQuery();

                    return true;
                }
                catch (MySqlException)
                {
                    Console.WriteLine("Erreur: " + "Le nom d'utilisateur est déjà utilisé");
                    return false;
                }
            }
        }
        public class PasswordHasher
        {
            public static string HashPassword(string password)
            {
                return BCrypt.Net.BCrypt.HashPassword(password);
            }

            public static bool VerifyPassword(string password, string hashedPassword)
            {
                return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
            }
        }
    }
}

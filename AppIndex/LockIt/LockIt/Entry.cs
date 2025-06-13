using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                string query = "SELECT user_id FROM t_user WHERE username = @Username AND password = @Password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
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
                string query = "INSERT INTO t_entry (title, username, password, user_id) VALUES (@Title, @Username, @Password, @UserId)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.ExecuteNonQuery();
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

                    // Insère le nouvel utilisateur
                    string insertQuery = "INSERT INTO t_user (username, password) VALUES (@Username, @Password)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                    insertCmd.Parameters.AddWithValue("@Username", username);
                    insertCmd.Parameters.AddWithValue("@Password", password);
                    insertCmd.ExecuteNonQuery();

                    return true;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Erreur: " + "Le nom d'utilisateur est déjà utilisé");
                    return false;
                }
            }
        }

    }
}

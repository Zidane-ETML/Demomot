using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockIt
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Signinbtn_Click(object sender, EventArgs e)
        {
            Signin signin = new();
            signin.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = UserName_Box.Text.Trim();
            string password = PassWord_box.Text.Trim();
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }
            var userFile = "users.txt";
            if (!File.Exists(userFile))
            {
                MessageBox.Show("Aucun utilisateur enregistré. Veuillez vous inscrire d'abord.");
                return;
            }
            var existingUsers = File.ReadAllLines(userFile);
            if (existingUsers.Any(line => line == $"{username}:{password}"))
            {
                MessageBox.Show("Connexion réussie !");

                PasswordManager passwordManagerForm = new();
                passwordManagerForm.FormClosed += (s, args) => this.Close(); // Ferme l'application lorsque PasswordManager est fermé
                passwordManagerForm.Show();
                this.Hide();
                // Ouvrir le gestionnaire de mots de passe ou autre action
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
            }
        }

        private void Hidebtn_Click(object sender, EventArgs e)
        {
            if (PassWord_box.UseSystemPasswordChar == true)
            {
                PassWord_box.UseSystemPasswordChar = false;
            }
            else
            {
                PassWord_box.UseSystemPasswordChar = true;
            }
        }
    }
}

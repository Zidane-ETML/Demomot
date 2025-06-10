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
    public partial class Signin : Form
    {
        private readonly string userFile = "users.txt";
        public Signin()
        {
            InitializeComponent();
        }
        private void Signinbtn_Click(object sender, EventArgs e)
        {
            string username = registeruserNamebox.Text.Trim();
            string password = registerPasswordbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            if (!File.Exists(userFile))
                File.Create(userFile).Close();

            var existingUsers = File.ReadAllLines(userFile);

            if (existingUsers.Any(line => line.StartsWith(username + ":")))
            {
                MessageBox.Show("Ce nom d'utilisateur est déjà utilisé.");
                return;
            }

            File.AppendAllText(userFile, $"{username}:{password}{Environment.NewLine}");
            MessageBox.Show("Inscription réussie !");
            this.Close();
        }
    }
}

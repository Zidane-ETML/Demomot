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

            Entry entry = new Entry();
            bool isRegistered = entry.RegisterUser(username, password);
            if (isRegistered)
            {
                MessageBox.Show("Inscription réussie )");
                this.Close();//Ferme le formulaire après avoir réussie l'inscription
            }
            else
            {
                MessageBox.Show("L'inscription a échoué. L'utilisateur existe peut-être déjà.");
            }
        }
    }
}

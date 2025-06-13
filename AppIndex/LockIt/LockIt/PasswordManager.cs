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
    public partial class PasswordManager : Form
    {
        private int userId;
        private void LoadPasswords()
        {
            Entry entry = new Entry();
            DataTable passwords = entry.GetPasswords(userId);

            dataGridView1.DataSource = passwords;

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["title"].HeaderText = "Titre";
                dataGridView1.Columns["username"].HeaderText = "Nom d'utilisateur";
                dataGridView1.Columns["password"].HeaderText = "Mot de passe";
            }
        }
        public PasswordManager(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
        private void SetupDataGridView()
        {
            // Utilise le nom correct du DataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.RowHeadersVisible = false;
        }


        private void Newbtn_Click(object sender, EventArgs e)
        {
            NewEntry newentry = new(userId);
            newentry.ShowDialog();

            LoadPasswords();
        }

        private void PasswordManager_Load_1(object sender, EventArgs e)
        {
            LoadPasswords();
        }
    }
}

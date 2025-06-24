using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string title = selectedRow.Cells["title"].Value.ToString();
                string username = selectedRow.Cells["username"].Value.ToString();
                string password = selectedRow.Cells["password"].Value.ToString();

                NewEntry modifyEntryForm = new NewEntry(userId, title, username, password);
                if (modifyEntryForm.ShowDialog() == DialogResult.OK)
                {
                    LoadPasswords();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une entrée à modifier.");
                LoadPasswords();
            }
            LoadPasswords();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string title = selectedRow.Cells["title"].Value.ToString();

                if (MessageBox.Show($"Êtes-vous sûr de vouloir supprimer l'entrée '{title}' ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Entry entry = new Entry();
                    entry.DeletePassword(userId, title);

                    LoadPasswords();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une entrée à supprimer.");
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPasswords();
        }

        private void LinkCreator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string githubUrl = "https://github.com/Zidane-ETML";

            Process.Start(new ProcessStartInfo(githubUrl) { UseShellExecute = true });
        }
    }
}

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
    public partial class NewEntry : Form
    {
        private int userId;
        public NewEntry(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void NewEntry_Load(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string title = NewTitle.Text;
            string username = NewUsername.Text;
            string password = NewPassword.Text;

            Entry entry = new Entry();
            entry.AddPassword(userId, title, username, password);

            this.Close();
        }
        public static string GeneratePassword(int length = 12)
        {
            const string validChars = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnpqrstuvwxyz23456789!@#$%^&*()";
            var random = new Random();
            return new string(Enumerable.Repeat(validChars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void Generatebtn_Click(object sender, EventArgs e)
        {
            NewPassword.Text = GeneratePassword();
        }
    }
}

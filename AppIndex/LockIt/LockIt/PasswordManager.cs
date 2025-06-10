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
        public PasswordManager()
        {
            InitializeComponent();
        }

        private void Newbtn_Click(object sender, EventArgs e)
        {
            NewEntry newentry = new();
            newentry.ShowDialog();
        }
        
    }
}

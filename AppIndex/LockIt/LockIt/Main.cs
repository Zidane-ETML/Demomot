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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void NewDatabase(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new();
            sfd.FileName = "DataBase.mpm";
            sfd.Filter = "Fichier MPM de MyPasswordManager | *.mpm";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var dbFile = sfd.FileName;
                LockIt newDatabaseForm = new();

                if (newDatabaseForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}

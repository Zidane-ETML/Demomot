namespace LockIt
{
    partial class PasswordManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            Newbtn = new ToolStripMenuItem();
            Editbtn = new ToolStripMenuItem();
            Deletebtn = new ToolStripMenuItem();
            Savebtn = new ToolStripMenuItem();
            Datagrid = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Datagrid).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SandyBrown;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(459, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Newbtn, Editbtn, Deletebtn, Savebtn });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(37, 20);
            fichierToolStripMenuItem.Text = "File";
            // 
            // Newbtn
            // 
            Newbtn.Name = "Newbtn";
            Newbtn.Size = new Size(138, 22);
            Newbtn.Text = "New";
            Newbtn.Click += Newbtn_Click;
            // 
            // Editbtn
            // 
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(138, 22);
            Editbtn.Text = "Edit";
            // 
            // Deletebtn
            // 
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(138, 22);
            Deletebtn.Text = "Delete";
            // 
            // Savebtn
            // 
            Savebtn.Name = "Savebtn";
            Savebtn.ShortcutKeys = Keys.Control | Keys.S;
            Savebtn.Size = new Size(138, 22);
            Savebtn.Text = "Save";
            // 
            // Datagrid
            // 
            Datagrid.BackgroundColor = SystemColors.Control;
            Datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Datagrid.GridColor = SystemColors.InactiveBorder;
            Datagrid.Location = new Point(0, 27);
            Datagrid.Name = "Datagrid";
            Datagrid.Size = new Size(459, 284);
            Datagrid.TabIndex = 1;
            // 
            // PasswordManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 311);
            Controls.Add(Datagrid);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(475, 350);
            MinimizeBox = false;
            MinimumSize = new Size(475, 350);
            Name = "PasswordManager";
            Text = "PasswordManager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Datagrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem Newbtn;
        private DataGridView Datagrid;
        private ToolStripMenuItem Editbtn;
        private ToolStripMenuItem Deletebtn;
        private ToolStripMenuItem Savebtn;
    }
}
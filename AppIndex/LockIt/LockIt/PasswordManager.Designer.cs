using System.Windows.Forms;

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
            refreshToolStripMenuItem = new ToolStripMenuItem();
            Title = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            LinkCreator = new LinkLabel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SandyBrown;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, refreshToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(459, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Newbtn, Editbtn, Deletebtn });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(37, 20);
            fichierToolStripMenuItem.Text = "File";
            // 
            // Newbtn
            // 
            Newbtn.Name = "Newbtn";
            Newbtn.Size = new Size(107, 22);
            Newbtn.Text = "New";
            Newbtn.Click += Newbtn_Click;
            // 
            // Editbtn
            // 
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(107, 22);
            Editbtn.Text = "Edit";
            Editbtn.Click += Editbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(107, 22);
            Deletebtn.Text = "Delete";
            Deletebtn.Click += Deletebtn_Click;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(58, 20);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // Title
            // 
            Title.HeaderText = "";
            Title.Name = "Title";
            // 
            // Username
            // 
            Username.HeaderText = "";
            Username.Name = "Username";
            // 
            // Password
            // 
            Password.HeaderText = "";
            Password.Name = "Password";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(0, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(459, 284);
            dataGridView1.TabIndex = 1;
            // 
            // LinkCreator
            // 
            LinkCreator.AutoSize = true;
            LinkCreator.Location = new Point(344, 287);
            LinkCreator.Name = "LinkCreator";
            LinkCreator.Size = new Size(103, 15);
            LinkCreator.TabIndex = 2;
            LinkCreator.TabStop = true;
            LinkCreator.Text = "Created by Zidane";
            LinkCreator.LinkClicked += LinkCreator_LinkClicked;
            // 
            // PasswordManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 311);
            Controls.Add(LinkCreator);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(475, 350);
            MinimizeBox = false;
            MinimumSize = new Size(475, 350);
            Name = "PasswordManager";
            Text = "PasswordManager";
            Load += PasswordManager_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem Newbtn;
        private ToolStripMenuItem Editbtn;
        private ToolStripMenuItem Deletebtn;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridView dataGridView1;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private LinkLabel LinkCreator;
    }
}
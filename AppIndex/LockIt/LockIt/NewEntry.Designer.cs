namespace LockIt
{
    partial class NewEntry
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
            NewEntryLayout = new TableLayoutPanel();
            NewUsername = new TextBox();
            NewTitle = new TextBox();
            Titlelbl = new Label();
            Usernamelbl = new Label();
            Passwordlbl = new Label();
            NewPassword = new TextBox();
            Generatebtn = new Button();
            Addbtn = new Button();
            NewEntryLayout.SuspendLayout();
            SuspendLayout();
            // 
            // NewEntryLayout
            // 
            NewEntryLayout.ColumnCount = 2;
            NewEntryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            NewEntryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            NewEntryLayout.Controls.Add(NewUsername, 1, 1);
            NewEntryLayout.Controls.Add(NewTitle, 1, 0);
            NewEntryLayout.Controls.Add(Titlelbl, 0, 0);
            NewEntryLayout.Controls.Add(Usernamelbl, 0, 1);
            NewEntryLayout.Controls.Add(Passwordlbl, 0, 2);
            NewEntryLayout.Controls.Add(NewPassword, 1, 2);
            NewEntryLayout.Location = new Point(1, 1);
            NewEntryLayout.Name = "NewEntryLayout";
            NewEntryLayout.RowCount = 3;
            NewEntryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            NewEntryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            NewEntryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            NewEntryLayout.Size = new Size(315, 336);
            NewEntryLayout.TabIndex = 0;
            // 
            // NewUsername
            // 
            NewUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NewUsername.Location = new Point(160, 156);
            NewUsername.MaxLength = 60;
            NewUsername.Name = "NewUsername";
            NewUsername.Size = new Size(152, 23);
            NewUsername.TabIndex = 5;
            // 
            // NewTitle
            // 
            NewTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NewTitle.Location = new Point(160, 44);
            NewTitle.MaxLength = 50;
            NewTitle.Name = "NewTitle";
            NewTitle.Size = new Size(152, 23);
            NewTitle.TabIndex = 4;
            // 
            // Titlelbl
            // 
            Titlelbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Titlelbl.AutoSize = true;
            Titlelbl.Location = new Point(3, 48);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(151, 15);
            Titlelbl.TabIndex = 0;
            Titlelbl.Text = "Title";
            // 
            // Usernamelbl
            // 
            Usernamelbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Usernamelbl.AutoSize = true;
            Usernamelbl.Location = new Point(3, 160);
            Usernamelbl.Name = "Usernamelbl";
            Usernamelbl.Size = new Size(151, 15);
            Usernamelbl.TabIndex = 1;
            Usernamelbl.Text = "Username";
            // 
            // Passwordlbl
            // 
            Passwordlbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Passwordlbl.AutoSize = true;
            Passwordlbl.Location = new Point(3, 272);
            Passwordlbl.Name = "Passwordlbl";
            Passwordlbl.Size = new Size(151, 15);
            Passwordlbl.TabIndex = 2;
            Passwordlbl.Text = "Password";
            // 
            // NewPassword
            // 
            NewPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NewPassword.Location = new Point(160, 268);
            NewPassword.MaxLength = 60;
            NewPassword.Name = "NewPassword";
            NewPassword.Size = new Size(152, 23);
            NewPassword.TabIndex = 3;
            NewPassword.UseSystemPasswordChar = true;
            // 
            // Generatebtn
            // 
            Generatebtn.Location = new Point(4, 343);
            Generatebtn.Name = "Generatebtn";
            Generatebtn.Size = new Size(75, 23);
            Generatebtn.TabIndex = 1;
            Generatebtn.Text = "Generate";
            Generatebtn.UseVisualStyleBackColor = true;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(238, 343);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(75, 23);
            Addbtn.TabIndex = 2;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // NewEntry
            // 
            AcceptButton = Addbtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 372);
            Controls.Add(Addbtn);
            Controls.Add(Generatebtn);
            Controls.Add(NewEntryLayout);
            Name = "NewEntry";
            Text = "NewEntry";
            Load += NewEntry_Load;
            NewEntryLayout.ResumeLayout(false);
            NewEntryLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel NewEntryLayout;
        private Label Titlelbl;
        private TextBox NewUsername;
        private TextBox NewTitle;
        private Label Usernamelbl;
        private Label Passwordlbl;
        private TextBox NewPassword;
        private Button Generatebtn;
        private Button Addbtn;
    }
}
using System.Windows.Forms;

namespace LockIt
{
    partial class Signin
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
            registeruserNamebox = new TextBox();
            registerPasswordbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Signinbtn = new Button();
            Hidebtn = new Button();
            SuspendLayout();
            // 
            // registeruserNamebox
            // 
            registeruserNamebox.Location = new Point(115, 113);
            registeruserNamebox.Name = "registeruserNamebox";
            registeruserNamebox.Size = new Size(236, 23);
            registeruserNamebox.TabIndex = 0;
            // 
            // registerPasswordbox
            // 
            registerPasswordbox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            registerPasswordbox.Location = new Point(115, 174);
            registerPasswordbox.Name = "registerPasswordbox";
            registerPasswordbox.Size = new Size(236, 23);
            registerPasswordbox.TabIndex = 1;
            registerPasswordbox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 95);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 156);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // Signinbtn
            // 
            Signinbtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Signinbtn.Location = new Point(193, 203);
            Signinbtn.Name = "Signinbtn";
            Signinbtn.Size = new Size(75, 23);
            Signinbtn.TabIndex = 6;
            Signinbtn.Text = "Sign in";
            Signinbtn.UseVisualStyleBackColor = true;
            Signinbtn.Click += Signinbtn_Click;
            // 
            // Hidebtn
            // 
            Hidebtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Hidebtn.ImeMode = ImeMode.NoControl;
            Hidebtn.Location = new Point(357, 173);
            Hidebtn.MaximumSize = new Size(51, 23);
            Hidebtn.MinimumSize = new Size(51, 23);
            Hidebtn.Name = "Hidebtn";
            Hidebtn.Size = new Size(51, 23);
            Hidebtn.TabIndex = 7;
            Hidebtn.Text = "Hide";
            Hidebtn.UseVisualStyleBackColor = true;
            Hidebtn.Click += Hidebtn_Click;
            // 
            // Signin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 311);
            Controls.Add(Hidebtn);
            Controls.Add(Signinbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(registerPasswordbox);
            Controls.Add(registeruserNamebox);
            MaximizeBox = false;
            MaximumSize = new Size(475, 350);
            MinimizeBox = false;
            MinimumSize = new Size(475, 350);
            Name = "Signin";
            Text = "Signin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox registeruserNamebox;
        private TextBox registerPasswordbox;
        private Label label1;
        private Label label2;
        private Button Signinbtn;
        private Button Hidebtn;
    }
}
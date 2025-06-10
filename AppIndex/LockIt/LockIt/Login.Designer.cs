namespace LockIt
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            UserName_Box = new TextBox();
            PassWord_box = new TextBox();
            UserName = new Label();
            Password = new Label();
            Loginbtn = new Button();
            Signinbtn = new Button();
            Hidebtn = new Button();
            SuspendLayout();
            // 
            // UserName_Box
            // 
            resources.ApplyResources(UserName_Box, "UserName_Box");
            UserName_Box.Name = "UserName_Box";
            // 
            // PassWord_box
            // 
            resources.ApplyResources(PassWord_box, "PassWord_box");
            PassWord_box.Name = "PassWord_box";
            PassWord_box.UseSystemPasswordChar = true;
            // 
            // UserName
            // 
            resources.ApplyResources(UserName, "UserName");
            UserName.Name = "UserName";
            // 
            // Password
            // 
            resources.ApplyResources(Password, "Password");
            Password.Name = "Password";
            // 
            // Loginbtn
            // 
            resources.ApplyResources(Loginbtn, "Loginbtn");
            Loginbtn.Name = "Loginbtn";
            Loginbtn.UseVisualStyleBackColor = true;
            Loginbtn.Click += Loginbtn_Click;
            Loginbtn.Enter += Loginbtn_Click;
            // 
            // Signinbtn
            // 
            resources.ApplyResources(Signinbtn, "Signinbtn");
            Signinbtn.Name = "Signinbtn";
            Signinbtn.UseVisualStyleBackColor = true;
            Signinbtn.Click += Signinbtn_Click;
            // 
            // Hidebtn
            // 
            resources.ApplyResources(Hidebtn, "Hidebtn");
            Hidebtn.Name = "Hidebtn";
            Hidebtn.UseVisualStyleBackColor = true;
            Hidebtn.Click += Hidebtn_Click;
            // 
            // Login
            // 
            AcceptButton = Loginbtn;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Hidebtn);
            Controls.Add(Signinbtn);
            Controls.Add(Loginbtn);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(PassWord_box);
            Controls.Add(UserName_Box);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            Load += Login_Load;
            Enter += Loginbtn_Click;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private TextBox UserName_Box;
        private TextBox PassWord_box;
        private Label UserName;
        private Label Password;
        private Button Loginbtn;
        private Button Signinbtn;
        private Button Hidebtn;
    }
}
namespace LockIt
{
    partial class LockIt
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockIt));
            this.Title = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbxMasterPassword = new System.Windows.Forms.TextBox();
            this.MainPassText = new System.Windows.Forms.Label();
            this.Envoyer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Gill Sans MT", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(240, 97);
            this.Title.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(176, 60);
            this.Title.TabIndex = 0;
            this.Title.Text = "LOCKIT";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxMasterPassword
            // 
            this.tbxMasterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMasterPassword.Location = new System.Drawing.Point(184, 314);
            this.tbxMasterPassword.Name = "tbxMasterPassword";
            this.tbxMasterPassword.Size = new System.Drawing.Size(279, 24);
            this.tbxMasterPassword.TabIndex = 1;
            this.tbxMasterPassword.UseSystemPasswordChar = true;
            this.tbxMasterPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainPassText
            // 
            this.MainPassText.AutoSize = true;
            this.MainPassText.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPassText.Location = new System.Drawing.Point(183, 288);
            this.MainPassText.Name = "MainPassText";
            this.MainPassText.Size = new System.Drawing.Size(280, 23);
            this.MainPassText.TabIndex = 2;
            this.MainPassText.Text = "Veuillez écrire votre mot de passe maitre";
            // 
            // Envoyer
            // 
            this.Envoyer.AccessibleName = "";
            this.Envoyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Envoyer.Location = new System.Drawing.Point(286, 376);
            this.Envoyer.Name = "Envoyer";
            this.Envoyer.Size = new System.Drawing.Size(75, 23);
            this.Envoyer.TabIndex = 3;
            this.Envoyer.Text = "Envoyer";
            this.Envoyer.UseVisualStyleBackColor = true;
            this.Envoyer.Click += new System.EventHandler(this.button1_Click);
            // 
            // LockIt
            // 
            this.AcceptButton = this.Envoyer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(25F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.Envoyer);
            this.Controls.Add(this.MainPassText);
            this.Controls.Add(this.tbxMasterPassword);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "LockIt";
            this.Text = "LockIt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox tbxMasterPassword;
        private System.Windows.Forms.Label MainPassText;
        private System.Windows.Forms.Button Envoyer;
    }
}


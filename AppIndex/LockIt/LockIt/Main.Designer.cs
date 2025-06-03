namespace LockIt
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entréeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneEntréeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierNomDutilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.entréeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.fermerToolStripMenuItem,
            this.enregistrerToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.NewDatabase);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fermerToolStripMenuItem.Text = "Fermer";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            // 
            // entréeToolStripMenuItem
            // 
            this.entréeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneEntréeToolStripMenuItem,
            this.copierNomDutilisateurToolStripMenuItem,
            this.copierMotDePasseToolStripMenuItem});
            this.entréeToolStripMenuItem.Name = "entréeToolStripMenuItem";
            this.entréeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.entréeToolStripMenuItem.Text = "Entrée";
            // 
            // ajouterUneEntréeToolStripMenuItem
            // 
            this.ajouterUneEntréeToolStripMenuItem.Name = "ajouterUneEntréeToolStripMenuItem";
            this.ajouterUneEntréeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.ajouterUneEntréeToolStripMenuItem.Text = "Ajouter une entrée";
            // 
            // copierNomDutilisateurToolStripMenuItem
            // 
            this.copierNomDutilisateurToolStripMenuItem.Name = "copierNomDutilisateurToolStripMenuItem";
            this.copierNomDutilisateurToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.copierNomDutilisateurToolStripMenuItem.Text = "Copier Nom d\'utilisateur";
            // 
            // copierMotDePasseToolStripMenuItem
            // 
            this.copierMotDePasseToolStripMenuItem.Name = "copierMotDePasseToolStripMenuItem";
            this.copierMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.copierMotDePasseToolStripMenuItem.Text = "Copier mot de passe";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "LockIt";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entréeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneEntréeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierNomDutilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierMotDePasseToolStripMenuItem;
    }
}
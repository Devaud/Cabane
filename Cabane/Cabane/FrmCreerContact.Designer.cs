namespace Cabane
{
    partial class FrmCreerContact
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBXNom = new System.Windows.Forms.TextBox();
            this.TBXPrenom = new System.Windows.Forms.TextBox();
            this.TBXEmail = new System.Windows.Forms.TextBox();
            this.TBXTel = new System.Windows.Forms.TextBox();
            this.TBXSiteWeb = new System.Windows.Forms.TextBox();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cabaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeCabaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCabaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creationContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Téléphone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Site web :";
            // 
            // TBXNom
            // 
            this.TBXNom.Location = new System.Drawing.Point(75, 39);
            this.TBXNom.MaxLength = 50;
            this.TBXNom.Name = "TBXNom";
            this.TBXNom.Size = new System.Drawing.Size(132, 20);
            this.TBXNom.TabIndex = 5;
            this.TBXNom.TextChanged += new System.EventHandler(this.TBXNom_TextChanged);
            // 
            // TBXPrenom
            // 
            this.TBXPrenom.Location = new System.Drawing.Point(75, 67);
            this.TBXPrenom.MaxLength = 50;
            this.TBXPrenom.Name = "TBXPrenom";
            this.TBXPrenom.Size = new System.Drawing.Size(132, 20);
            this.TBXPrenom.TabIndex = 6;
            this.TBXPrenom.TextChanged += new System.EventHandler(this.TBXNom_TextChanged);
            // 
            // TBXEmail
            // 
            this.TBXEmail.Location = new System.Drawing.Point(75, 94);
            this.TBXEmail.MaxLength = 50;
            this.TBXEmail.Name = "TBXEmail";
            this.TBXEmail.Size = new System.Drawing.Size(132, 20);
            this.TBXEmail.TabIndex = 7;
            this.TBXEmail.TextChanged += new System.EventHandler(this.TBXNom_TextChanged);
            // 
            // TBXTel
            // 
            this.TBXTel.Location = new System.Drawing.Point(75, 120);
            this.TBXTel.MaxLength = 50;
            this.TBXTel.Name = "TBXTel";
            this.TBXTel.Size = new System.Drawing.Size(132, 20);
            this.TBXTel.TabIndex = 8;
            this.TBXTel.TextChanged += new System.EventHandler(this.TBXNom_TextChanged);
            // 
            // TBXSiteWeb
            // 
            this.TBXSiteWeb.Location = new System.Drawing.Point(75, 147);
            this.TBXSiteWeb.MaxLength = 50;
            this.TBXSiteWeb.Name = "TBXSiteWeb";
            this.TBXSiteWeb.Size = new System.Drawing.Size(132, 20);
            this.TBXSiteWeb.TabIndex = 9;
            this.TBXSiteWeb.TextChanged += new System.EventHandler(this.TBXNom_TextChanged);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(23, 180);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.BtnAnnuler.TabIndex = 10;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Enabled = false;
            this.BtnAjouter.Location = new System.Drawing.Point(132, 180);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(75, 23);
            this.BtnAjouter.TabIndex = 11;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.cabaneToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(219, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconnexionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deconnexionToolStripMenuItem.Text = "Deconnexion";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // cabaneToolStripMenuItem
            // 
            this.cabaneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeCabaneToolStripMenuItem,
            this.gestionCabaneToolStripMenuItem});
            this.cabaneToolStripMenuItem.Name = "cabaneToolStripMenuItem";
            this.cabaneToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.cabaneToolStripMenuItem.Text = "Cabane";
            // 
            // listeCabaneToolStripMenuItem
            // 
            this.listeCabaneToolStripMenuItem.Name = "listeCabaneToolStripMenuItem";
            this.listeCabaneToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.listeCabaneToolStripMenuItem.Text = "Liste cabane";
            this.listeCabaneToolStripMenuItem.Click += new System.EventHandler(this.listeCabaneToolStripMenuItem_Click);
            // 
            // gestionCabaneToolStripMenuItem
            // 
            this.gestionCabaneToolStripMenuItem.Name = "gestionCabaneToolStripMenuItem";
            this.gestionCabaneToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.gestionCabaneToolStripMenuItem.Text = "Gestion cabane";
            this.gestionCabaneToolStripMenuItem.Click += new System.EventHandler(this.gestionCabaneToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeContactsToolStripMenuItem,
            this.creationContactToolStripMenuItem});
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.contactToolStripMenuItem.Text = "Contact";
            // 
            // listeContactsToolStripMenuItem
            // 
            this.listeContactsToolStripMenuItem.Name = "listeContactsToolStripMenuItem";
            this.listeContactsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.listeContactsToolStripMenuItem.Text = "Liste contacts";
            this.listeContactsToolStripMenuItem.Click += new System.EventHandler(this.listeContactsToolStripMenuItem_Click);
            // 
            // creationContactToolStripMenuItem
            // 
            this.creationContactToolStripMenuItem.Checked = true;
            this.creationContactToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.creationContactToolStripMenuItem.Enabled = false;
            this.creationContactToolStripMenuItem.Name = "creationContactToolStripMenuItem";
            this.creationContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.creationContactToolStripMenuItem.Text = "Creation contact";
            // 
            // FrmCreerContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 215);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.TBXSiteWeb);
            this.Controls.Add(this.TBXTel);
            this.Controls.Add(this.TBXEmail);
            this.Controls.Add(this.TBXPrenom);
            this.Controls.Add(this.TBXNom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmCreerContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter contact";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBXNom;
        private System.Windows.Forms.TextBox TBXPrenom;
        private System.Windows.Forms.TextBox TBXEmail;
        private System.Windows.Forms.TextBox TBXTel;
        private System.Windows.Forms.TextBox TBXSiteWeb;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cabaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeCabaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCabaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creationContactToolStripMenuItem;
    }
}
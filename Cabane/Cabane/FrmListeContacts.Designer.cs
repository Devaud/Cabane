namespace Cabane
{
    partial class FrmContacts
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CabanetoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeCabanesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCabaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creationContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.LBcontacts = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.CabanetoolStripMenuItem1,
            this.contactToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(247, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.deconnexionToolStripMenuItem.Text = "Deconnexion";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // CabanetoolStripMenuItem1
            // 
            this.CabanetoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeCabanesToolStripMenuItem,
            this.gestionCabaneToolStripMenuItem});
            this.CabanetoolStripMenuItem1.Name = "CabanetoolStripMenuItem1";
            this.CabanetoolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.CabanetoolStripMenuItem1.Text = "Cabane";
            // 
            // listeCabanesToolStripMenuItem
            // 
            this.listeCabanesToolStripMenuItem.Name = "listeCabanesToolStripMenuItem";
            this.listeCabanesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.listeCabanesToolStripMenuItem.Text = "Liste cabanes";
            this.listeCabanesToolStripMenuItem.Click += new System.EventHandler(this.listeCabanesToolStripMenuItem_Click);
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
            this.listeContactsToolStripMenuItem.Checked = true;
            this.listeContactsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.listeContactsToolStripMenuItem.Enabled = false;
            this.listeContactsToolStripMenuItem.Name = "listeContactsToolStripMenuItem";
            this.listeContactsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.listeContactsToolStripMenuItem.Text = "Liste contacts";
            // 
            // creationContactToolStripMenuItem
            // 
            this.creationContactToolStripMenuItem.Name = "creationContactToolStripMenuItem";
            this.creationContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.creationContactToolStripMenuItem.Text = "Creation contact";
            this.creationContactToolStripMenuItem.Click += new System.EventHandler(this.creationContactToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des contacts :";
            // 
            // LBcontacts
            // 
            this.LBcontacts.FormattingEnabled = true;
            this.LBcontacts.Location = new System.Drawing.Point(22, 56);
            this.LBcontacts.Name = "LBcontacts";
            this.LBcontacts.Size = new System.Drawing.Size(193, 173);
            this.LBcontacts.TabIndex = 2;
            // 
            // FrmContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 280);
            this.Controls.Add(this.LBcontacts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmContacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmContacts_FormClosed);
            this.Load += new System.EventHandler(this.FrmContacts_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LBcontacts;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CabanetoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeCabanesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCabaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creationContactToolStripMenuItem;
    }
}
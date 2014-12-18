namespace Cabane
{
    partial class FrmListeCabane
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
            this.lbxCabanes = new System.Windows.Forms.ListBox();
            this.tbxRecherche = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cabaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeCabanesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCabaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeContactToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.creationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxCabanes
            // 
            this.lbxCabanes.FormattingEnabled = true;
            this.lbxCabanes.Items.AddRange(new object[] {
            "aaaa",
            "bbb",
            "ccc",
            "ddd",
            "eee"});
            this.lbxCabanes.Location = new System.Drawing.Point(2, 53);
            this.lbxCabanes.Name = "lbxCabanes";
            this.lbxCabanes.Size = new System.Drawing.Size(283, 238);
            this.lbxCabanes.TabIndex = 0;
            this.lbxCabanes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbxRecherche
            // 
            this.tbxRecherche.Location = new System.Drawing.Point(12, 27);
            this.tbxRecherche.Name = "tbxRecherche";
            this.tbxRecherche.Size = new System.Drawing.Size(162, 20);
            this.tbxRecherche.TabIndex = 1;
            this.tbxRecherche.TextChanged += new System.EventHandler(this.tbxRecherche_TextChanged);
            this.tbxRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxRecherche_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(197, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconnexionToolStripMenuItem,
            this.quitterToolStripMenuItem1});
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
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem1.Text = "Quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            // 
            // cabaneToolStripMenuItem
            // 
            this.cabaneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeCabanesToolStripMenuItem,
            this.gestionCabaneToolStripMenuItem});
            this.cabaneToolStripMenuItem.Name = "cabaneToolStripMenuItem";
            this.cabaneToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.cabaneToolStripMenuItem.Text = "Cabane";
            // 
            // listeCabanesToolStripMenuItem
            // 
            this.listeCabanesToolStripMenuItem.Checked = true;
            this.listeCabanesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.listeCabanesToolStripMenuItem.Enabled = false;
            this.listeCabanesToolStripMenuItem.Name = "listeCabanesToolStripMenuItem";
            this.listeCabanesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.listeCabanesToolStripMenuItem.Text = "Liste cabane";
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
            this.listeContactToolStripMenuItem1,
            this.creationToolStripMenuItem});
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.contactToolStripMenuItem.Text = "Contact";
            // 
            // listeContactToolStripMenuItem1
            // 
            this.listeContactToolStripMenuItem1.Name = "listeContactToolStripMenuItem1";
            this.listeContactToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.listeContactToolStripMenuItem1.Text = "Liste contact";
            this.listeContactToolStripMenuItem1.Click += new System.EventHandler(this.listeToolStripMenuItem1_Click);
            // 
            // creationToolStripMenuItem
            // 
            this.creationToolStripMenuItem.Name = "creationToolStripMenuItem";
            this.creationToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.creationToolStripMenuItem.Text = "Creation contact";
            this.creationToolStripMenuItem.Click += new System.EventHandler(this.creationToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.cabaneToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(284, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fichierToolStripMenuItem1
            // 
            this.fichierToolStripMenuItem1.Name = "fichierToolStripMenuItem1";
            this.fichierToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem1.Text = "Fichier";
            // 
            // FrmListeCabane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 294);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxRecherche);
            this.Controls.Add(this.lbxCabanes);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "FrmListeCabane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des cabanes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmListeCabane_FormClosed);
            this.Load += new System.EventHandler(this.FrmListeCabane_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCabanes;
        private System.Windows.Forms.TextBox tbxRecherche;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem listesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCabaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeCabanesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cabaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creationToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeContactToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
    }
}
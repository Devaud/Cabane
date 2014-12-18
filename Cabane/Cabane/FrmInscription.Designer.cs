namespace Cabane
{
    partial class FrmInscription
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
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.lblMDP = new System.Windows.Forms.Label();
            this.lblValidMDP = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.TBXPrenom = new System.Windows.Forms.TextBox();
            this.TBXNom = new System.Windows.Forms.TextBox();
            this.TBXPseudo = new System.Windows.Forms.TextBox();
            this.TBXMDP = new System.Windows.Forms.TextBox();
            this.TBXValideMDP = new System.Windows.Forms.TextBox();
            this.TBXEmail = new System.Windows.Forms.TextBox();
            this.TBXTel = new System.Windows.Forms.TextBox();
            this.BtnValider = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrenom
            // 
            this.lblPrenom.Location = new System.Drawing.Point(16, 44);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(111, 13);
            this.lblPrenom.TabIndex = 0;
            this.lblPrenom.Text = "Prénom :";
            this.lblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNom
            // 
            this.lblNom.Location = new System.Drawing.Point(16, 69);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(111, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPseudo
            // 
            this.lblPseudo.Location = new System.Drawing.Point(16, 93);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(111, 13);
            this.lblPseudo.TabIndex = 2;
            this.lblPseudo.Text = "Pseudo :";
            this.lblPseudo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMDP
            // 
            this.lblMDP.Location = new System.Drawing.Point(16, 119);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(111, 13);
            this.lblMDP.TabIndex = 3;
            this.lblMDP.Text = "Mot de passe :";
            this.lblMDP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValidMDP
            // 
            this.lblValidMDP.Location = new System.Drawing.Point(16, 144);
            this.lblValidMDP.Name = "lblValidMDP";
            this.lblValidMDP.Size = new System.Drawing.Size(111, 13);
            this.lblValidMDP.TabIndex = 4;
            this.lblValidMDP.Text = "Valider mot de passe :";
            this.lblValidMDP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(16, 170);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(111, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email :";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTel
            // 
            this.lblTel.Location = new System.Drawing.Point(16, 195);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(111, 13);
            this.lblTel.TabIndex = 6;
            this.lblTel.Text = "Téléphone";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBXPrenom
            // 
            this.TBXPrenom.Location = new System.Drawing.Point(133, 44);
            this.TBXPrenom.MaxLength = 30;
            this.TBXPrenom.Name = "TBXPrenom";
            this.TBXPrenom.Size = new System.Drawing.Size(131, 20);
            this.TBXPrenom.TabIndex = 7;
            this.TBXPrenom.TextChanged += new System.EventHandler(this.TBXPrenom_TextChanged);
            // 
            // TBXNom
            // 
            this.TBXNom.Location = new System.Drawing.Point(134, 69);
            this.TBXNom.MaxLength = 30;
            this.TBXNom.Name = "TBXNom";
            this.TBXNom.Size = new System.Drawing.Size(131, 20);
            this.TBXNom.TabIndex = 8;
            this.TBXNom.TextChanged += new System.EventHandler(this.TBXPrenom_TextChanged);
            // 
            // TBXPseudo
            // 
            this.TBXPseudo.Location = new System.Drawing.Point(134, 93);
            this.TBXPseudo.MaxLength = 30;
            this.TBXPseudo.Name = "TBXPseudo";
            this.TBXPseudo.Size = new System.Drawing.Size(131, 20);
            this.TBXPseudo.TabIndex = 9;
            this.TBXPseudo.TextChanged += new System.EventHandler(this.TBXPrenom_TextChanged);
            // 
            // TBXMDP
            // 
            this.TBXMDP.Location = new System.Drawing.Point(134, 119);
            this.TBXMDP.MaxLength = 30;
            this.TBXMDP.Name = "TBXMDP";
            this.TBXMDP.Size = new System.Drawing.Size(131, 20);
            this.TBXMDP.TabIndex = 10;
            this.TBXMDP.TextChanged += new System.EventHandler(this.TBXPrenom_TextChanged);
            // 
            // TBXValideMDP
            // 
            this.TBXValideMDP.Location = new System.Drawing.Point(134, 144);
            this.TBXValideMDP.MaxLength = 30;
            this.TBXValideMDP.Name = "TBXValideMDP";
            this.TBXValideMDP.Size = new System.Drawing.Size(131, 20);
            this.TBXValideMDP.TabIndex = 11;
            this.TBXValideMDP.TextChanged += new System.EventHandler(this.TBXPrenom_TextChanged);
            // 
            // TBXEmail
            // 
            this.TBXEmail.Location = new System.Drawing.Point(134, 170);
            this.TBXEmail.MaxLength = 50;
            this.TBXEmail.Name = "TBXEmail";
            this.TBXEmail.Size = new System.Drawing.Size(131, 20);
            this.TBXEmail.TabIndex = 12;
            this.TBXEmail.TextChanged += new System.EventHandler(this.TBXPrenom_TextChanged);
            // 
            // TBXTel
            // 
            this.TBXTel.Location = new System.Drawing.Point(134, 195);
            this.TBXTel.MaxLength = 30;
            this.TBXTel.Name = "TBXTel";
            this.TBXTel.Size = new System.Drawing.Size(131, 20);
            this.TBXTel.TabIndex = 13;
            this.TBXTel.TextChanged += new System.EventHandler(this.TBXPrenom_TextChanged);
            // 
            // BtnValider
            // 
            this.BtnValider.Enabled = false;
            this.BtnValider.Location = new System.Drawing.Point(155, 221);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(109, 23);
            this.BtnValider.TabIndex = 14;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = true;
            this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(16, 222);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(109, 23);
            this.BtnAnnuler.TabIndex = 15;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(276, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.connexionToolStripMenuItem.Text = "Connexion";
            this.connexionToolStripMenuItem.Click += new System.EventHandler(this.connexionToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // FrmInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 265);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.BtnValider);
            this.Controls.Add(this.TBXTel);
            this.Controls.Add(this.TBXEmail);
            this.Controls.Add(this.TBXValideMDP);
            this.Controls.Add(this.TBXMDP);
            this.Controls.Add(this.TBXPseudo);
            this.Controls.Add(this.TBXNom);
            this.Controls.Add(this.TBXPrenom);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblValidMDP);
            this.Controls.Add(this.lblMDP);
            this.Controls.Add(this.lblPseudo);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmInscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmInscription_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.Label lblMDP;
        private System.Windows.Forms.Label lblValidMDP;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox TBXPrenom;
        private System.Windows.Forms.TextBox TBXNom;
        private System.Windows.Forms.TextBox TBXPseudo;
        private System.Windows.Forms.TextBox TBXMDP;
        private System.Windows.Forms.TextBox TBXValideMDP;
        private System.Windows.Forms.TextBox TBXEmail;
        private System.Windows.Forms.TextBox TBXTel;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}
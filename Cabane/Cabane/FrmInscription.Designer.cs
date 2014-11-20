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
            this.SuspendLayout();
            // 
            // lblPrenom
            // 
            this.lblPrenom.Location = new System.Drawing.Point(12, 13);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(111, 13);
            this.lblPrenom.TabIndex = 0;
            this.lblPrenom.Text = "Prénom :";
            this.lblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNom
            // 
            this.lblNom.Location = new System.Drawing.Point(12, 38);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(111, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPseudo
            // 
            this.lblPseudo.Location = new System.Drawing.Point(12, 62);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(111, 13);
            this.lblPseudo.TabIndex = 2;
            this.lblPseudo.Text = "Pseudo :";
            this.lblPseudo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMDP
            // 
            this.lblMDP.Location = new System.Drawing.Point(12, 88);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(111, 13);
            this.lblMDP.TabIndex = 3;
            this.lblMDP.Text = "Mot de passe :";
            this.lblMDP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValidMDP
            // 
            this.lblValidMDP.Location = new System.Drawing.Point(12, 113);
            this.lblValidMDP.Name = "lblValidMDP";
            this.lblValidMDP.Size = new System.Drawing.Size(111, 13);
            this.lblValidMDP.TabIndex = 4;
            this.lblValidMDP.Text = "Valider mot de passe :";
            this.lblValidMDP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(12, 139);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(111, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email :";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblTel
            // 
            this.lblTel.Location = new System.Drawing.Point(12, 164);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(111, 13);
            this.lblTel.TabIndex = 6;
            this.lblTel.Text = "Téléphone";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBXPrenom
            // 
            this.TBXPrenom.Location = new System.Drawing.Point(129, 13);
            this.TBXPrenom.MaxLength = 30;
            this.TBXPrenom.Name = "TBXPrenom";
            this.TBXPrenom.Size = new System.Drawing.Size(131, 20);
            this.TBXPrenom.TabIndex = 7;
            // 
            // TBXNom
            // 
            this.TBXNom.Location = new System.Drawing.Point(130, 38);
            this.TBXNom.MaxLength = 30;
            this.TBXNom.Name = "TBXNom";
            this.TBXNom.Size = new System.Drawing.Size(131, 20);
            this.TBXNom.TabIndex = 8;
            // 
            // TBXPseudo
            // 
            this.TBXPseudo.Location = new System.Drawing.Point(130, 62);
            this.TBXPseudo.MaxLength = 30;
            this.TBXPseudo.Name = "TBXPseudo";
            this.TBXPseudo.Size = new System.Drawing.Size(131, 20);
            this.TBXPseudo.TabIndex = 9;
            // 
            // TBXMDP
            // 
            this.TBXMDP.Location = new System.Drawing.Point(130, 88);
            this.TBXMDP.MaxLength = 30;
            this.TBXMDP.Name = "TBXMDP";
            this.TBXMDP.Size = new System.Drawing.Size(131, 20);
            this.TBXMDP.TabIndex = 10;
            // 
            // TBXValideMDP
            // 
            this.TBXValideMDP.Location = new System.Drawing.Point(130, 113);
            this.TBXValideMDP.MaxLength = 30;
            this.TBXValideMDP.Name = "TBXValideMDP";
            this.TBXValideMDP.Size = new System.Drawing.Size(131, 20);
            this.TBXValideMDP.TabIndex = 11;
            // 
            // TBXEmail
            // 
            this.TBXEmail.Location = new System.Drawing.Point(130, 139);
            this.TBXEmail.MaxLength = 50;
            this.TBXEmail.Name = "TBXEmail";
            this.TBXEmail.Size = new System.Drawing.Size(131, 20);
            this.TBXEmail.TabIndex = 12;
            // 
            // TBXTel
            // 
            this.TBXTel.Location = new System.Drawing.Point(130, 164);
            this.TBXTel.MaxLength = 30;
            this.TBXTel.Name = "TBXTel";
            this.TBXTel.Size = new System.Drawing.Size(131, 20);
            this.TBXTel.TabIndex = 13;
            // 
            // BtnValider
            // 
            this.BtnValider.Location = new System.Drawing.Point(15, 190);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(109, 23);
            this.BtnValider.TabIndex = 14;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = true;
            this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(152, 190);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(109, 23);
            this.BtnAnnuler.TabIndex = 15;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // FrmInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 226);
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
            this.Name = "FrmInscription";
            this.Text = "Inscription";
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
    }
}
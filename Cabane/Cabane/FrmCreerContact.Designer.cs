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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Téléphone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Site web :";
            // 
            // TBXNom
            // 
            this.TBXNom.Location = new System.Drawing.Point(75, 12);
            this.TBXNom.MaxLength = 50;
            this.TBXNom.Name = "TBXNom";
            this.TBXNom.Size = new System.Drawing.Size(132, 20);
            this.TBXNom.TabIndex = 5;
            this.TBXNom.TextChanged += new System.EventHandler(this.TBXNom_TextChanged);
            // 
            // TBXPrenom
            // 
            this.TBXPrenom.Location = new System.Drawing.Point(75, 40);
            this.TBXPrenom.MaxLength = 50;
            this.TBXPrenom.Name = "TBXPrenom";
            this.TBXPrenom.Size = new System.Drawing.Size(132, 20);
            this.TBXPrenom.TabIndex = 6;
            this.TBXPrenom.TextChanged += new System.EventHandler(this.TBXNom_TextChanged);
            // 
            // TBXEmail
            // 
            this.TBXEmail.Location = new System.Drawing.Point(75, 67);
            this.TBXEmail.MaxLength = 50;
            this.TBXEmail.Name = "TBXEmail";
            this.TBXEmail.Size = new System.Drawing.Size(132, 20);
            this.TBXEmail.TabIndex = 7;
            this.TBXEmail.TextChanged += new System.EventHandler(this.TBXNom_TextChanged);
            // 
            // TBXTel
            // 
            this.TBXTel.Location = new System.Drawing.Point(75, 93);
            this.TBXTel.MaxLength = 50;
            this.TBXTel.Name = "TBXTel";
            this.TBXTel.Size = new System.Drawing.Size(132, 20);
            this.TBXTel.TabIndex = 8;
            this.TBXTel.TextChanged += new System.EventHandler(this.TBXNom_TextChanged);
            // 
            // TBXSiteWeb
            // 
            this.TBXSiteWeb.Location = new System.Drawing.Point(75, 120);
            this.TBXSiteWeb.MaxLength = 50;
            this.TBXSiteWeb.Name = "TBXSiteWeb";
            this.TBXSiteWeb.Size = new System.Drawing.Size(132, 20);
            this.TBXSiteWeb.TabIndex = 9;
            this.TBXSiteWeb.TextChanged += new System.EventHandler(this.TBXNom_TextChanged);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(23, 153);
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
            this.BtnAjouter.Location = new System.Drawing.Point(132, 153);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(75, 23);
            this.BtnAjouter.TabIndex = 11;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // FrmCreerContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 188);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmCreerContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter contact";
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
    }
}
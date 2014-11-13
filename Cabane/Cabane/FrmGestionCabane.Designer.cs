namespace Cabane
{
    partial class FrmGestionCabane
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
            this.TCgestionCabane = new System.Windows.Forms.TabControl();
            this.TPajoutCabane = new System.Windows.Forms.TabPage();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.CBdouche = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NUDlits = new System.Windows.Forms.NumericUpDown();
            this.TBprix = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBnpa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBlocalite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBadresse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBaltitude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBnom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TPmodifierCabane = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TCgestionCabane.SuspendLayout();
            this.TPajoutCabane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDlits)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCgestionCabane
            // 
            this.TCgestionCabane.Controls.Add(this.TPajoutCabane);
            this.TCgestionCabane.Controls.Add(this.TPmodifierCabane);
            this.TCgestionCabane.Location = new System.Drawing.Point(12, 39);
            this.TCgestionCabane.Name = "TCgestionCabane";
            this.TCgestionCabane.SelectedIndex = 0;
            this.TCgestionCabane.Size = new System.Drawing.Size(434, 224);
            this.TCgestionCabane.TabIndex = 1;
            // 
            // TPajoutCabane
            // 
            this.TPajoutCabane.Controls.Add(this.BtnAnnuler);
            this.TPajoutCabane.Controls.Add(this.BtnAjouter);
            this.TPajoutCabane.Controls.Add(this.CBdouche);
            this.TPajoutCabane.Controls.Add(this.label8);
            this.TPajoutCabane.Controls.Add(this.label7);
            this.TPajoutCabane.Controls.Add(this.NUDlits);
            this.TPajoutCabane.Controls.Add(this.TBprix);
            this.TPajoutCabane.Controls.Add(this.label6);
            this.TPajoutCabane.Controls.Add(this.TBnpa);
            this.TPajoutCabane.Controls.Add(this.label5);
            this.TPajoutCabane.Controls.Add(this.TBlocalite);
            this.TPajoutCabane.Controls.Add(this.label4);
            this.TPajoutCabane.Controls.Add(this.TBadresse);
            this.TPajoutCabane.Controls.Add(this.label3);
            this.TPajoutCabane.Controls.Add(this.TBaltitude);
            this.TPajoutCabane.Controls.Add(this.label2);
            this.TPajoutCabane.Controls.Add(this.TBnom);
            this.TPajoutCabane.Controls.Add(this.label1);
            this.TPajoutCabane.Location = new System.Drawing.Point(4, 22);
            this.TPajoutCabane.Name = "TPajoutCabane";
            this.TPajoutCabane.Padding = new System.Windows.Forms.Padding(3);
            this.TPajoutCabane.Size = new System.Drawing.Size(426, 198);
            this.TPajoutCabane.TabIndex = 0;
            this.TPajoutCabane.Text = "Ajouter une cabane";
            this.TPajoutCabane.UseVisualStyleBackColor = true;
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(208, 159);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.BtnAnnuler.TabIndex = 17;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(77, 159);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(100, 23);
            this.BtnAjouter.TabIndex = 16;
            this.BtnAjouter.Text = "Ajouter la cabane";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // CBdouche
            // 
            this.CBdouche.FormattingEnabled = true;
            this.CBdouche.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.CBdouche.Location = new System.Drawing.Point(275, 85);
            this.CBdouche.Name = "CBdouche";
            this.CBdouche.Size = new System.Drawing.Size(121, 21);
            this.CBdouche.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Douche :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nombre lits :";
            // 
            // NUDlits
            // 
            this.NUDlits.Location = new System.Drawing.Point(276, 50);
            this.NUDlits.Name = "NUDlits";
            this.NUDlits.Size = new System.Drawing.Size(120, 20);
            this.NUDlits.TabIndex = 12;
            // 
            // TBprix
            // 
            this.TBprix.Location = new System.Drawing.Point(275, 122);
            this.TBprix.Name = "TBprix";
            this.TBprix.Size = new System.Drawing.Size(120, 20);
            this.TBprix.TabIndex = 11;
            this.TBprix.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Prix :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TBnpa
            // 
            this.TBnpa.Location = new System.Drawing.Point(276, 15);
            this.TBnpa.Name = "TBnpa";
            this.TBnpa.Size = new System.Drawing.Size(120, 20);
            this.TBnpa.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "NPA :";
            // 
            // TBlocalite
            // 
            this.TBlocalite.Location = new System.Drawing.Point(77, 122);
            this.TBlocalite.Name = "TBlocalite";
            this.TBlocalite.Size = new System.Drawing.Size(100, 20);
            this.TBlocalite.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Localité :";
            // 
            // TBadresse
            // 
            this.TBadresse.Location = new System.Drawing.Point(77, 85);
            this.TBadresse.Name = "TBadresse";
            this.TBadresse.Size = new System.Drawing.Size(100, 20);
            this.TBadresse.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adresse :";
            // 
            // TBaltitude
            // 
            this.TBaltitude.Location = new System.Drawing.Point(77, 52);
            this.TBaltitude.Name = "TBaltitude";
            this.TBaltitude.Size = new System.Drawing.Size(100, 20);
            this.TBaltitude.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altitude :";
            // 
            // TBnom
            // 
            this.TBnom.Location = new System.Drawing.Point(77, 19);
            this.TBnom.Name = "TBnom";
            this.TBnom.Size = new System.Drawing.Size(100, 20);
            this.TBnom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // TPmodifierCabane
            // 
            this.TPmodifierCabane.AutoScroll = true;
            this.TPmodifierCabane.Location = new System.Drawing.Point(4, 22);
            this.TPmodifierCabane.Name = "TPmodifierCabane";
            this.TPmodifierCabane.Padding = new System.Windows.Forms.Padding(3);
            this.TPmodifierCabane.Size = new System.Drawing.Size(426, 198);
            this.TPmodifierCabane.TabIndex = 1;
            this.TPmodifierCabane.Text = "Modifier une cabane";
            this.TPmodifierCabane.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // FrmGestionCabane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 303);
            this.Controls.Add(this.TCgestionCabane);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmGestionCabane";
            this.Text = "FrmGestionCabane";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGestionCabane_FormClosed);
            this.TCgestionCabane.ResumeLayout(false);
            this.TPajoutCabane.ResumeLayout(false);
            this.TPajoutCabane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDlits)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TCgestionCabane;
        private System.Windows.Forms.TabPage TPajoutCabane;
        private System.Windows.Forms.TextBox TBprix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBnpa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBlocalite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBadresse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBaltitude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBnom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage TPmodifierCabane;
        private System.Windows.Forms.ComboBox CBdouche;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NUDlits;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.Button BtnAnnuler;
    }
}
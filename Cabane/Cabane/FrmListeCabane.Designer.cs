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
            this.label1 = new System.Windows.Forms.Label();
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
            this.lbxCabanes.Location = new System.Drawing.Point(2, 24);
            this.lbxCabanes.Name = "lbxCabanes";
            this.lbxCabanes.Size = new System.Drawing.Size(283, 238);
            this.lbxCabanes.TabIndex = 0;
            this.lbxCabanes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbxRecherche
            // 
            this.tbxRecherche.Location = new System.Drawing.Point(107, 2);
            this.tbxRecherche.Name = "tbxRecherche";
            this.tbxRecherche.Size = new System.Drawing.Size(150, 20);
            this.tbxRecherche.TabIndex = 1;
            this.tbxRecherche.TextChanged += new System.EventHandler(this.tbxRecherche_TextChanged);
            this.tbxRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxRecherche_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recherche :";
            // 
            // FrmListeCabane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxRecherche);
            this.Controls.Add(this.lbxCabanes);
            this.Name = "FrmListeCabane";
            this.Text = "Liste des cabanes";
            this.Load += new System.EventHandler(this.FrmListeCabane_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCabanes;
        private System.Windows.Forms.TextBox tbxRecherche;
        private System.Windows.Forms.Label label1;
    }
}
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
            this.lbxCabanes.Location = new System.Drawing.Point(1, 0);
            this.lbxCabanes.Name = "lbxCabanes";
            this.lbxCabanes.Size = new System.Drawing.Size(283, 264);
            this.lbxCabanes.TabIndex = 0;
            this.lbxCabanes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FrmListeCabane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbxCabanes);
            this.Name = "FrmListeCabane";
            this.Text = "Liste des cabanes";
            this.Load += new System.EventHandler(this.FrmListeCabane_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCabanes;
    }
}
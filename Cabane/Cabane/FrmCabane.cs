using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabane
{
    public partial class FrmCabane : Form
    {
       

        public FrmCabane()
        {
            InitializeComponent();
        }

        private void FrmCabane_Load(object sender, EventArgs e)
        {
            manipdb db = new manipdb();
             db.connexion("127.0.0.1", "root", "cabanes", "");
        }

        private void gestionCabaneToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmGestionCabane gestion = new FrmGestionCabane();
            gestion.Show(this);
            this.Hide();
        }

        private void inscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInscription ins = new FrmInscription();
            ins.Show(this);
        }
    }
}

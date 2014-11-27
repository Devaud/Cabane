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

        manipdb db = new manipdb();
        private void FrmCabane_Load(object sender, EventArgs e)
        {
            
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

        private void listeDesCabanesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListeCabane ins = new FrmListeCabane();
            ins.Show(this);
           
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            db.connexion("127.0.0.1", "root", "cabanes", "");
            db.Login(tbx_pseudo.Text, tbx_pwd.Text);
            db.fermer();
        }

    }
}

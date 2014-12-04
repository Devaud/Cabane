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
            int id_user = 0;

            db.connexion("127.0.0.1", "root", "cabanes", "");
            id_user = db.Login(tbx_pseudo.Text, tbx_pwd.Text);

            if(id_user == -1)
            {
                MessageBox.Show("Pseudo faux ou MDP faux", "Login Echoué", MessageBoxButtons.OK);
            }
            else
            {
                tbx_pseudo.Visible = false;
                label3.Visible = false;
                tbx_pwd.Visible = false;
                btn_login.Visible = false;

                lbl_pseudo.Text = "Pseudo USER"; //Nom du user recupere des la base
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void créationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCreerContact creerContact = new FrmCreerContact();
            creerContact.Show(this);
        }

    }
}

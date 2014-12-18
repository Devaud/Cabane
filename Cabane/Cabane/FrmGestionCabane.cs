using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cabane
{
    public partial class FrmGestionCabane : Form
    {
        public FrmGestionCabane()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (TBnom.Text != "" && TBadresse.Text != "" && TBaltitude.Text != "" && TBlocalite.Text != "" && TBnpa.Text != "" && TBprix.Text != "")
            {
                manipdb db = new manipdb();
                //MySqlConnection var = new MySqlConnection();
                
                db.connexion("127.0.0.1", "root", "cabanes");

                

                var nom = TBnom.Text;
                var adresse = TBadresse.Text;
                var altitude = TBaltitude.Text;
                var localite = TBlocalite.Text;
                var npa = TBnpa.Text;
                var prix = TBprix.Text;
                var photo = "";
                var nbLits = NUDlits.Value;

                var douche = false; 
                
                if(CBdouche.SelectedText == "Oui")
                {
                    douche = true;
                }
                else
                {
                    douche = false;
                }
                var result = false;


                result = db.addCabane(nom, adresse, photo, localite, npa, nbLits, prix, altitude, douche);
                db.fermer();
            }
        }

        private void FrmGestionCabane_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }


        


        private void cabanesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListeCabane cabane = new FrmListeCabane();
            cabane.Show(this);
            this.Hide();
        }

        private void listeContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContacts contact = new FrmContacts();
            contact.Show(this);
            this.Hide();
        }

        private void creationContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCreerContact creercontact = new FrmCreerContact();
            creercontact.Show(this);
            this.Hide();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

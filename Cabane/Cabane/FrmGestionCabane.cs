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
        manipdb db = new manipdb();
        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (TBnom.Text != "" && TBadresse.Text != "" && TBaltitude.Text != "" && TBlocalite.Text != "" && TBnpa.Text != "" && TBprix.Text != "")
            {

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

                if (CBdouche.SelectedText == "Oui")
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
        private void btnContactCabane_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbContact.SelectedIndices.Count; i++)
            {
                for (int y = 0; y < lsbCabanes.SelectedIndices.Count; y++)
                {
                    db.connexion("127.0.0.1", "root", "cabanes", "");

                    int u = lsbContact.SelectedIndices[i];
                    string idContact = contacts[u][0];
                    int z = lsbCabanes.SelectedIndices[y];
                    string idCabane = cabanes[z][0];

                    if (db.check_contact_cabanes(idContact, idCabane, 1))
                    {
                        db.connexion("127.0.0.1", "root", "cabanes", "");
                        db.insert_contact_cabanes(idContact, idCabane);
                    }
                }
            }
        }

        List<List<String>> cabanes = new List<List<String>>();
        List<List<String>> contacts = new List<List<String>>();
        private void FrmGestionCabane_Load(object sender, EventArgs e)
        {


            db.connexion("127.0.0.1", "root", "cabanes", "");
            contacts = db.list_contacts();
            for (int i = 0; i < contacts.Count(); i++)
            {
                lsbContact.Items.Add(contacts[i][1]);
            }
            db.fermer();

            db.connexion("127.0.0.1", "root", "cabanes", "");
            cabanes = db.list_cabanes();
            for (int i = 0; i < cabanes.Count(); i++)
            {
                lsbCabanes.Items.Add(cabanes[i][1]);
            }

            db.fermer();
        }

        private void btnCabaneContact_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbCabanes.SelectedIndices.Count; i++)
            {
                for (int y = 0; y < lsbContact.SelectedIndices.Count; y++)
                {
                    db.connexion("127.0.0.1", "root", "cabanes", "");

                    int u = lsbCabanes.SelectedIndices[i];
                    string idCabane = cabanes[u][0];
                    int z = lsbContact.SelectedIndices[y];
                    string idContact = contacts[z][0];

                    if (db.check_contact_cabanes(idContact, idCabane, 0))
                    {
                        db.connexion("127.0.0.1", "root", "cabanes", "");
                        db.insert_contact_cabanes(idContact, idCabane);
                    }
                }
            }
        }

        private void lsbCabanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            FrmGestionCabane.ActiveForm.Text = lsbCabanes.SelectedItems.Count.ToString();
        }
    }
}

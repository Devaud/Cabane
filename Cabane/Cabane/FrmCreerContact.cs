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
    public partial class FrmCreerContact : Form
    {
        string server, uid, database;
        List<TextBox> TBXList = new List<TextBox>();

        public FrmCreerContact()
        {
            InitializeComponent();

            server = "127.0.0.1";
            uid = "root";
            database = "cabanes";

            TBXList.Add(TBXNom);
            TBXList.Add(TBXPrenom);
            TBXList.Add(TBXEmail);
            TBXList.Add(TBXTel);

        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            // Déclaration et affectation des variables
            manipdb db = new manipdb();
            string nom, prenom, email, tel, website;

            nom = TBXNom.Text;
            prenom = TBXPrenom.Text;
            email = TBXEmail.Text;
            tel = TBXTel.Text;
            website = TBXSiteWeb.Text;

            if(website == "")
            {
                website = null;
            }

            // Gestion avec la base de données
            db.connexion(server, uid, database);
            if (db.addContact(nom, prenom, email, tel, website))
            {
                MessageBox.Show("Contact ajouter avec succès");
            }
            else
            {
                MessageBox.Show("Impossible de créer le contact");
            }
            db.fermer();
            
        }

        private void TBXNom_TextChanged(object sender, EventArgs e)
        {
            // Récupère le nombre d'élément se trouvant dans la liste
            int ListSize = TBXList.Count;

            // Boucle pour parcourir tout les éléments de la liste
            for (int i = 0; i < ListSize; i++)
            {
                TextBox tbx = TBXList[i]; // Récupère l'élément à la position i
                if (tbx.Text == "")
                {
                    BtnAjouter.Enabled = false;
                }
                else
                {
                    BtnAjouter.Enabled = true;
                }
            }
            
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listeCabaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListeCabane cabane = new FrmListeCabane();
            cabane.Show(this);
            this.Hide();
        }

        private void gestionCabaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionCabane gestionCabane = new FrmGestionCabane();
            gestionCabane.Show(this);
            this.Hide();
        }

        private void listeContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContacts contact = new FrmContacts();
            contact.Show(this);
            this.Hide();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

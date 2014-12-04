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

        public FrmCreerContact()
        {
            InitializeComponent();

            server = "127.0.0.1";
            uid = "root";
            database = "cabanes";
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
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

            db.connexion(server, uid, database);
            if (db.addContact(nom, prenom, email, tel, website))
            {
                MessageBox.Show("Contact ajouter avec succès");
                this.Close();
            }
            else
            {
                MessageBox.Show("Impossible de créer le contact");
            }
            db.fermer();
            
        }

        private void TBXNom_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

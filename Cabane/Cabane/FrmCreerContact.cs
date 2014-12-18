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
        // global variable
        string server, uid, database;
        List<TextBox> TBXList = new List<TextBox>();

        /**
         * Constructor
         * */
        public FrmCreerContact()
        {
            InitializeComponent();

            // Initialize variable
            server = "127.0.0.1";
            uid = "root";
            database = "cabanes";

            // Add item in the list
            TBXList.Add(TBXNom);
            TBXList.Add(TBXPrenom);
            TBXList.Add(TBXEmail);
            TBXList.Add(TBXTel);

        }

        /**
         * Event button add
         * @param Object sender object which call this event
         * @param EventArgs e
         * */
        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            // Initialize variable
            manipdb db = new manipdb();
            string lastname, firstname, email, tel, website;

            lastname = TBXNom.Text;
            firstname = TBXPrenom.Text;
            email = TBXEmail.Text;
            tel = TBXTel.Text;
            website = (TBXSiteWeb.Text == "") ? null : TBXSiteWeb.Text; // Test if website is empty

            

            // Data base
            db.connexion(server, uid, database); // Connection with database
            if (db.addContact(lastname, firstname, email, tel, website)) // Add Contact
            {
                MessageBox.Show("Contact ajouter avec succès"); // Success Message
                db.fermer(); // Close stream
                this.Close(); // Close window
            }
            else
            {
                MessageBox.Show("Impossible de créer le contact"); // Error message
            }
            db.fermer(); // Close stream
        }

        /**
         * Event textbox change
         * @param Object sender object which call this event
         * @param EventArgs e
         * */
        private void TBXNom_TextChanged(object sender, EventArgs e)
        {
            // Count item in the list
            int ListSize = TBXList.Count;

            // Check item in the list
            for (int i = 0; i < ListSize; i++)
            {
                TextBox tbx = TBXList[i]; // Récupère l'élément à la position i
                BtnAjouter.Enabled = (tbx.Text == "") ? false : true;
            }
            
        }

        /**
         * Event button cancel
         * @param Object sender object which call this event
         * @param EventArgs e
         * */
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close(); // close the window
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

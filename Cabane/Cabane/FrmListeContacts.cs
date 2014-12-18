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
    public partial class FrmContacts : Form
    {
        string server, uid, pwd, database;
        public FrmContacts()
        {
            InitializeComponent();

            server = "127.0.0.1";
            uid = "cabaneAdmin";
            pwd = "groupB";
            database = "cabanes";
        }

        private void FrmContacts_Load(object sender, EventArgs e)
        {
            manipdb db = new manipdb();
            List<String> contacts = new List<String>();
            int i = 0;

            contacts = db.afficheContact();

            while(i<contacts.Count)
            {
                LBcontacts.Items.Add(Convert.ToString(contacts[i]));
                i++;
            }

        }

        private void listeCabanesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void FrmContacts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}

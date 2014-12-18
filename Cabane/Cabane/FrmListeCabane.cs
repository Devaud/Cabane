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
    public partial class FrmListeCabane : Form
    {
        string server, uid, database, pwd; 
        manipdb db = new manipdb();

        public FrmListeCabane()
        {
            InitializeComponent();

            server = "127.0.0.1";
            uid = "cabaneAdmin";
            pwd = "groupB";
            database = "cabanes";

            lbxCabanes.Items.Clear();
            List<String> str = new List<String>();
            int i = 0;
           

            db.connexion(server, uid, database, pwd);
            str = db.List_nom_cabannes();
            db.fermer();

            while (str.Count() != i)
            {
                lbxCabanes.Items.Add(str[i]);
                i++;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmListeCabane_Load(object sender, EventArgs e)
        {

        }

        private void tbxRecherche_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbxRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbxCabanes.Items.Clear();
            List<String> search = new List<String>();
            int i = 0;


            db.connexion(server, uid, database, pwd);
            search = db.SearchCabane(tbxRecherche.Text);
            db.fermer();

            while (search.Count() != i)
            {
                lbxCabanes.Items.Add(search[i]);
                i++;
            }
        }

        private void gestionCabaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionCabane cabane = new FrmGestionCabane();
            cabane.Show(this);
            this.Hide();
        }

        private void listeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmContacts contact = new FrmContacts();
            contact.Show(this);
            this.Hide();
        }


        private void creationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCreerContact creercontact = new FrmCreerContact();
            creercontact.Show(this);
            this.Hide();
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmListeCabane_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

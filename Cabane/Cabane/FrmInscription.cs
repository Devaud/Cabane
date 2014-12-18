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
    public partial class FrmInscription : Form
    {
        // Global variable
        string server, uid, database, pwd;
        List<TextBox> TBXList = new List<TextBox>(); // List of textbox

        public FrmInscription()
        {
            InitializeComponent();

            // Initialize server info
            server = "127.0.0.1";
            uid = "cabaneAdmin";
            pwd = "groupB";
            database = "cabanes";
            
            // Add Item in the list
            TBXList.Add(TBXNom);
            TBXList.Add(TBXPseudo);
            TBXList.Add(TBXPrenom);
            TBXList.Add(TBXMDP);
            TBXList.Add(TBXEmail);
            TBXList.Add(TBXTel);
            TBXList.Add(TBXValideMDP);

        }

        /**
         * Action button validation
         * @param object sender Object wich call this function
         * @param EventArgs e
         * */
        private void BtnValider_Click(object sender, EventArgs e)
        {
            // Create object for db
            manipdb db = new manipdb();
            string lastname, firstname, pseudo, pwd, pwd2, email, tel;

            // Initialize variable
            lastname = TBXNom.Text;
            firstname = TBXPrenom.Text;
            pseudo = TBXPseudo.Text;
            pwd = TBXMDP.Text;
            pwd2 = TBXValideMDP.Text;
            email = TBXEmail.Text;
            tel = TBXTel.Text;

            // Password verifiaction.
            if (pwd == pwd2)
            {
                db.connexion(server, uid, database, pwd); // Create connection
                db.setUser(firstname, lastname, pseudo, pwd, email, tel); // Execute request
                db.fermer(); // Close db

                this.Close(); // Close this window
            }
        }

        /**
         * Action button cancel
         * @param object sender Object which call this function
         * @param EventArgs e
         * */
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            FrmCabane cabane = new FrmCabane();
            cabane.Show(this);
            this.Hide();
        } 

        /**
         * Event when an edit change
         * @param object sender Object which call this function
         * @parma EventArgs e
         * */
        private void TBXPrenom_TextChanged(object sender, EventArgs e)
        {
            // Count items in list
            int ListSize = TBXList.Count;

            //Read all items in the list
            for (int i = 0; i < ListSize; i++)
            {
                TextBox tbx = TBXList[i]; // Keep the item which pos. at i
                if (tbx.Text == "")
                {
                    BtnValider.Enabled = false;
                }
                else
                {
                    BtnValider.Enabled = true;
                }
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCabane cabane = new FrmCabane();
            cabane.Show(this);
            this.Hide();
        }

        private void FrmInscription_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

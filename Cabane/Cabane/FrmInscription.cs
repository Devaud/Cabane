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
        string server, uid, database, pwd;
        public FrmInscription()
        {
            InitializeComponent();

            server = "127.0.0.1";
            uid = "root";
            database = "cabanes";
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            manipdb db = new manipdb();
            string nom, prenom, pseudo, mdp, mdp2, email, telephone;

            nom = TBXNom.Text;
            prenom = TBXPrenom.Text;
            pseudo = TBXPseudo.Text;
            mdp = TBXMDP.Text;
            mdp2 = TBXValideMDP.Text;
            email = TBXEmail.Text;
            telephone = TBXTel.Text;

            if (mdp == mdp2)
            {
                db.connexion(server, uid, database);
                db.setUser(prenom, nom, pseudo, mdp, email, telephone);
                db.close();
            }
        }
    }
}

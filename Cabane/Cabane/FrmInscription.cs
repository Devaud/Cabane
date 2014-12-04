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
        List<TextBox> TBXList = new List<TextBox>();

        public FrmInscription()
        {
            InitializeComponent();

            server = "127.0.0.1";
            uid = "root";
            database = "cabanes";

            TBXList.Add(TBXNom);
            TBXList.Add(TBXPseudo);
            TBXList.Add(TBXPrenom);
            TBXList.Add(TBXMDP);
            TBXList.Add(TBXEmail);
            TBXList.Add(TBXTel);
            TBXList.Add(TBXValideMDP);

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
                db.fermer();

                this.Close();
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInscription_Load(object sender, EventArgs e)
        {

        }

        private void TBXPrenom_TextChanged(object sender, EventArgs e)
        {
            // Récupère le nombre d'élément se trouvant dans la liste
            int ListSize = TBXList.Count;

            // Boucle pour parcourir tout les éléments de la liste
            for (int i = 0; i < ListSize; i++)
            {
                TextBox tbx = TBXList[i]; // Récupère l'élément à la position i
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
    }
}

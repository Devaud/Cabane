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
        public FrmListeCabane()
        {
            InitializeComponent();

            server = "127.0.0.1";
            uid = "root";
            database = "cabanes";

            lbxCabanes.Items.Clear();
            List<String> str = new List<String>();
            int i = 0;
            manipdb db = new manipdb();

            db.connexion(server, uid, database);
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
    }
}

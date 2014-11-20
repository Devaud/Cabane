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
        public FrmListeCabane()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmListeCabane_Load(object sender, EventArgs e)
        {
            manipdb db = new manipdb();

            //FrmListeCabane.ActiveForm.Text = 
            db.connexion("127.0.0.1", "root", "cabanes", "");
            db.List_nom_cabannes();
            db.fermer();

        }
    }
}

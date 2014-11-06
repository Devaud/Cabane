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
    public partial class FrmCabane : Form
    {
       

        public FrmCabane()
        {
            InitializeComponent();
        }

        private void FrmCabane_Load(object sender, EventArgs e)
        {
            manipdb db = new manipdb(); 

            label1.Text = db.connexion("127.0.0.1", "root", "myblogdb");
        }
    }
}

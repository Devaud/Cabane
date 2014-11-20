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
        public FrmContacts()
        {
            InitializeComponent();
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
    }
}

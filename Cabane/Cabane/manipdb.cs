using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
//using System.Windows.Forms.MessageBox;



namespace Cabane
{
    class manipdb
    {
        private MySqlConnection conn; //Objet de connexion a la db
        private MySqlDataReader rdr; // Objet pour lire les informations retournée par une requete
        private MySqlCommand cmd; // Objet qui permet de faire une requete
        private MySqlDataAdapter MyAdapter;
        private String nomConnexion;

        public manipdb()
        {
            conn = new MySqlConnection();

            rdr = null;
        }

        public bool ajoutCabane(string nom, string adresse, string photo, string localite, string npa, decimal nbLits, string prix, string altitude, bool douche)
        {
            MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();
            MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();

            string SQL;

            conn.ConnectionString = "server=localhost; userid=root;password=;database=kyjk_cabaneGroupeB;";
            conn.Open();



            try
            {

                SQL = "insert into cabane(nom,adresse,photo,localite,NPA,nbLits,prixNuit,altitude,douches) values('"+nom+"', '"+adresse+"', '"+photo+"','"+localite+"','"+npa+"','"+nbLits+"','"+prix+"','"+altitude+"','"+douche+"')";
                cmd.Connection = conn;
                cmd.CommandText = SQL;
                cmd.ExecuteNonQuery();




                conn.Close();
                return true; 
            }

                
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        public string connexion(string serveur, string uid, string database, string pwd)
        {
            try
            {
                nomConnexion = "server="+serveur+";uid="+uid+";pwd="+pwd+";database="+database+";";

                conn.ConnectionString = nomConnexion;
                conn.Open();
                return "Ok";
            }
            catch(MySqlException ex)
            {
                return ex.Message;
            }
        }
    }
}

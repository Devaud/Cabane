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
        private String nomConnexion;
        private string SQL;

        public manipdb()
        {
            conn = new MySqlConnection();
            cmd = new MySqlCommand();
            rdr = null;
        }

        public void connexion(string serveur, string uid, string database, string pwd = "")
        {
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            cmd = new MySql.Data.MySqlClient.MySqlCommand();
            try
            {
                nomConnexion = "server="+serveur+";uid="+uid+";pwd="+pwd+";database="+database+";";

                conn.ConnectionString = nomConnexion;
                conn.Open();
                
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        public void fermer()
        {
            conn.Close();
        }

       public void setUser(string prenom, string nom, string pseudo, string mdp, string email, string telephone)
        {
            

            try
            {
                SQL = "insert into personnes(pseudo,mdp,nom,prenom,email,telephone) values('" + pseudo + "', '" + mdp + "', '" + nom + "','" + prenom + "','" + email + "','" + telephone + "')";
                cmd.Connection = this.conn;
                cmd.CommandText = SQL;
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
       public bool ajoutCabane(string nom, string adresse, string photo, string localite, string npa, decimal nbLits, string prix, string altitude, bool douche)
       {
           

           try
           {

               SQL = "insert into cabane(nom,adresse,photo,localite,NPA,nbLits,prixNuit,altitude,douches) values('" + nom + "', '" + adresse + "', '" + photo + "','" + localite + "','" + npa + "','" + nbLits + "','" + prix + "','" + altitude + "','" + douche + "')";
               cmd.Connection = this.conn;
               cmd.CommandText = SQL;
               cmd.ExecuteNonQuery();
               return true;
           }


           catch (MySql.Data.MySqlClient.MySqlException ex)
           {
               MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return false;
           }

       }

        public List<String> List_nom_cabannes()
        {
            List<String> str = new List<String>();

           
            try
            {
                SQL = "select nom from cabane";
                cmd.Connection = this.conn;
                cmd.CommandText = SQL;
                cmd.ExecuteNonQuery();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    str.Add(rdr.GetString(0));
                 
                }
                return str;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void Login(string pseudo, string mdp)
        {
            try
            {
                
                SQL = "SELECT idPersonne FROM personnes WHERE pseudo='" + pseudo + "' AND mdp='" + mdp + "';";
                cmd.Connection = this.conn;
                cmd.CommandText = SQL;
                rdr = cmd.ExecuteReader();

            }
            catch(MySqlException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            
        }

        public List<String> afficheContact(){
          

            List<String> contacts = new List<String>();
            string SQL;

            conn.ConnectionString = "server=localhost; userid=root;password=;database=cabanes;";
            conn.Open();

            try
            {

                SQL = "SELECT nom,prenom,telephone,email,siteWeb FROM contact";
                cmd.Connection = conn;
                cmd.CommandText = SQL;
               cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    contacts.Add(reader.GetFieldValue<String>(0) + ' ' + reader.GetFieldValue<String>(1));
                    //i++;
                }
                return contacts;      
                
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
                
            }
        }
     }

    
}

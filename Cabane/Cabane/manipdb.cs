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
        private MySqlDataReader rdr; // Objet pour lire les informations retourn�e par une requete
        private MySqlCommand cmd; // Objet qui permet de faire une requete
        private String nomConnexion;
        private string SQL;
        public bool connected;

        /**
         * Constructor of manipdb
         * */
        public manipdb()
        {
            // Initialisation des variables
            conn = new MySqlConnection();
            cmd = new MySqlCommand();
            rdr = null;
        }

        /**
         * Connection with mysql server
         * @param string server Address server
         * @param string uid user name on the server
         * @param string database database name
         * @param string pwd user password
         * */
        public void connexion(string server, string uid, string database, string pwd = "")
        {
            conn = new MySql.Data.MySqlClient.MySqlConnection();// Create MySqlConnection Object
            cmd = new MySql.Data.MySqlClient.MySqlCommand(); // Create MySqlCommand Object

            try
            {
                nomConnexion = "server=" + server + ";uid=" + uid + ";pwd=" + pwd + ";database=" + database + ";"; // Connection name
                conn.ConnectionString = nomConnexion; // Initialize connection between apps and MySql server
                conn.Open(); // Open the stream between apps and MySql
                
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message); // Error message
                
            }
        }

        /**
         * Close the connection
         * */
        public void fermer()
        {
            conn.Close();
        }

        /**
         * Insert user in the db
         * @param string firstName User firstname
         * @param string LastName User lasname
         * @param string pseudo User pseudo
         * @param string pwd User password
         * @param string email User email
         * @param string tel User telefone
         * */
       public void setUser(string firstName, string LastName, string pseudo, string pwd, string email, string tel)
        {
            

            try
            {
                // Create request for insert user
                SQL = "insert into personnes(pseudo,mdp,nom,prenom,email,telephone) values('" + pseudo + "', '" + pwd + "', '" + LastName + "','" + firstName + "','" + email + "','" + tel + "')";
                cmd.Connection = this.conn;
                cmd.CommandText = SQL; // Use the sql request
                cmd.Prepare(); // Prepare sql request
                cmd.ExecuteNonQuery(); // Execute sql request
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Error message
            }
        }
        
        /**
         * Add caban in the db
         * @param string name Cabane name
         * @param string address Cabane address
         * @param string picture Picture of the cabane
         * @param string localite Cabane localite
         * @param string npa Cabane npa
         * @param decimal nbLits Number of bed
         * @param string prix price by night
         * @param string altitude Cabane altitude
         * @param bool douche Cabane with shower or not
         * 
         * @return bool true if the cabane is added with success
         * */
       public bool addCabane(string name, string address, string picture, string localite, string npa, decimal nbLits, string prix, string altitude, bool douche)
       {
           try
           {
               // Create request for insert cabane 
               SQL = "insert into cabane(nom,adresse,photo,localite,NPA,nbLits,prixNuit,altitude,douches) values('" + name + "', '" + address + "', '" + picture + "','" + localite + "','" + npa + "','" + nbLits + "','" + prix + "','" + altitude + "','" + douche + "')";
               cmd.Connection = this.conn;
               cmd.CommandText = SQL; // Use the sql request
               cmd.ExecuteNonQuery(); // Execute sql request
               return true;
           }
           catch (MySql.Data.MySqlClient.MySqlException ex)
           {
               MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Error message
               return false;
           }

       }

        /**
         * Make a list of cabane name
         * 
         * @return List<String> list of string
         * */
        public List<String> List_nom_cabannes()
        {
            List<String> str = new List<String>();
            try
            {
                // Create request for select name cabane
                SQL = "select nom from cabane";
                cmd.Connection = this.conn;
                cmd.CommandText = SQL; // Use the sql request
                cmd.ExecuteNonQuery(); // Execute sql request
                rdr = cmd.ExecuteReader(); // Create the reader

                // Use the reader while data exist
                while (rdr.Read())
                {
                    str.Add(rdr.GetString(0)); // Add data in list
                 
                }
                return str; // return list
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Error message
                return null;
            }
        }

        /**
         * Login
         * @param string pseudo User pseudo
         * @param string pwd User password
         * @result int id
         * */
        public int Login(string pseudo, string pwd)
        {
            int result = -1;   
            try
            {
                // Create request for select idPersonne personnes
                SQL = "SELECT idPersonne FROM personnes WHERE pseudo='" + pseudo + "' AND mdp='" + pwd + "';";
                cmd.Connection = this.conn;
                cmd.CommandText = SQL; // Use the sql request
                rdr = cmd.ExecuteReader();// Create the reader

                // Use the reader while data exist
                while(rdr.Read())
                {
                    result = Convert.ToInt32(rdr.GetString(0));
                    
                    
                }
                connected = true;
            }
            catch(MySqlException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Error message
                connected = false;
                
                
            }
            finally
            {
                conn.Close(); // Close the stream
            }

            return result;
        }


        /**
         * List of contact
         * @result List<String> Contact list
         * */
        public List<String> afficheContact(){
            List<String> contacts = new List<String>();
            string SQL;

            conn.ConnectionString = "server=localhost; userid=root;password=;database=cabanes;";
            conn.Open();

            try
            {
                // Create request for select contact info
                SQL = "SELECT nom,prenom,telephone,email,siteWeb FROM contact";
                cmd.Connection = conn;
                cmd.CommandText = SQL; // Use the sql request
                cmd.ExecuteNonQuery(); // Execute sql request
                rdr = cmd.ExecuteReader(); // Create the reader

                // Use the reader while data exist
                while (rdr.Read())
                {
                    contacts.Add(rdr.GetFieldValue<String>(0) + ' ' + rdr.GetFieldValue<String>(1));
                }
                return contacts;      
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Error Message
                return null;
            }
            finally
            {
                conn.Close(); // Close the stream
                
            }
        }

        /**
         * Add contact
         * @param string lastName contact lastname
         * @param string firstName contact firstname
         * @param string email contact email
         * @param string tel contact tel
         * @param string siteweb contact siteweb link
         * 
         * @return bool true if the contact is added with success
         * */
        public bool addContact(string lastName, string firstName, string email, string tel, string siteweb = null)
        {
            try
            {
                // Create request for insert contact
                SQL = "INSERT INTO contact (nom, prenom, email, telephone, siteWeb) VALUES ('" + lastName + "', '" + firstName + "', '" + email + "', '" + tel + "', '" + siteweb + "')";
                cmd.Connection = this.conn;
                cmd.CommandText = SQL; // Use the sql request
                cmd.Prepare(); // Prepare the sql request
                cmd.ExecuteNonQuery(); // Execute sql request

                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Error Message
                return false;
            }
        }

        /**
         * Search Cabane
         * @param string searchedItem Item which is searched
         * 
         * @return List<String> list of cabane
         * */
        public List<String> SearchCabane(string searchedItem)
        {
            List<String> searchChar = new List<String>();

            try
            {
                // Create request for Select cabane which is searched
                string search = "SELECT nom from cabane WHERE nom like \"%" + searchedItem + "%\"";
                cmd.Connection = this.conn;
                cmd.CommandText = search; // Use the sql request
                cmd.ExecuteNonQuery(); // Execute sql request
                rdr = cmd.ExecuteReader(); // Create the reader

                // Use the reader while data exist
                while (rdr.Read())
                {
                    searchChar.Add(rdr.GetString(0));
                }
                return searchChar;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Error Message
                return null;
            }

        }
    }

   

    
}

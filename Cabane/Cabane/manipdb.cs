﻿using System;
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
        private string SQL;

        public manipdb()
        {
            conn = new MySqlConnection();
            cmd = new MySqlCommand();
            rdr = null;
        }

        public void connexion(string serveur, string uid, string database, string pwd = "")
        {
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
            }

            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return str;
        }

        public void close()
        {
            conn.Close();
        }


    }

    
}

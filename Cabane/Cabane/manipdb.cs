using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Cabane
{
    class manipdb
    {
        private MySqlConnection conn; //Objet de connexion a la db
        private MySqlDataReader rdr; // Objet pour lire les informations retournée par une requete
        private MySqlCommand cmd; // Objet qui permet de faire une requete
        private String nomConnexion;

        public manipdb()
        {
            conn = new MySqlConnection();
            rdr = null;
        }

        public string connexion(string serveur, string uid, string database, string pwd="")
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

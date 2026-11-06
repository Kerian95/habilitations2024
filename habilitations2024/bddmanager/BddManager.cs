using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace habilitations2024.bddmanager
{
    public class BddManager
    {
        private static BddManager instance = null;
        private MySqlConnection connection;

        private BddManager(string stringConnect)
        {
            connection = new MySqlConnection(stringConnect);
            connection.Open();
        }

        public static BddManager GetInstance(string stringConnect)
        {
            if (instance == null)
            {
                instance = new BddManager(stringConnect);
            }
            return instance;
        }

        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters = null)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
            }
            command.Prepare();
            command.ExecuteNonQuery();
        }

        public List<object[]> ReqSelect(string stringQuery, Dictionary<string, object> parameters = null)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
            }
            command.Prepare();
            List<object[]> records = new List<object[]>();            // la liste des lignes à renvoyer
            using (MySqlDataReader reader = command.ExecuteReader())   // exécute le SELECT : le curseur
            {
                int nbCols = reader.FieldCount;                        // nombre de colonnes du SELECT
                while (reader.Read())                                  // pour chaque ligne du résultat
                {
                    object[] attributs = new object[nbCols];           // un tableau vide de la bonne taille
                    reader.GetValues(attributs);                       // rempli avec toutes les valeurs de la ligne
                    records.Add(attributs);                            // ajouté à la liste
                }
            }                                                          // le curseur est fermé ici
            return records;
        }
    }
}
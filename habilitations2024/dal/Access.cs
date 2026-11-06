using System;
using habilitations2024.bddmanager;

namespace habilitations2024.dal
{
    public class Access
    {
        // chaîne de connexion à la bdd
        private static readonly string connectionString = "server=localhost;port=3306;user id=habilitations;password=motdepasseuser;database=habilitations;AllowPublicKeyRetrieval=True;SslMode=Disabled;";
        // instance unique de la classe
        private static Access instance = null;
        // objet d'accès aux données
        public BddManager Manager { get; }

        // constructeur privé (singleton)
        private Access()
        {
            try
            {
                Manager = BddManager.GetInstance(connectionString);
            }
            catch (Exception)
            {
                Environment.Exit(0);   // connexion impossible : on ferme l'application
            }
        }

        // récupère l'instance unique
        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }
    }
}
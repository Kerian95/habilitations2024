using System;
using System.Collections.Generic;
using habilitations2024.model;

namespace habilitations2024.dal
{
    public class ProfilAccess
    {
        // instance unique de l'accès aux données
        private readonly Access access = null;

        // constructeur : récupère l'accès aux données
        public ProfilAccess()
        {
            access = Access.GetInstance();
        }

        // récupère et retourne les profils
        public List<Profil> GetLesProfils()
        {
            List<Profil> lesProfils = new List<Profil>();
            string req = "SELECT idprofil, nom FROM profil ORDER BY nom;";
            try
            {
                List<object[]> records = access.Manager.ReqSelect(req);
                if (records != null)
                {
                    foreach (object[] record in records)
                    {
                        // case 0 = idprofil, case 1 = nom : on les transtype
                        Profil profil = new Profil((int)record[0], (string)record[1]);
                        lesProfils.Add(profil);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
            return lesProfils;
        }
    }
}
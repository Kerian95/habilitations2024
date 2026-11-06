using System;
using System.Collections.Generic;
using habilitations2024.model;

namespace habilitations2024.dal
{
    public class DeveloppeurAccess
    {
        // instance unique de l'accès aux données
        private readonly Access access = null;

        // constructeur : récupère l'accès aux données
        public DeveloppeurAccess()
        {
            access = Access.GetInstance();
        }

        // récupère et retourne les développeurs (avec le nom de leur profil)
        public List<Developpeur> GetLesDeveloppeurs()
        {
            List<Developpeur> lesDeveloppeurs = new List<Developpeur>();
            string req = "SELECT d.iddeveloppeur, d.nom, d.prenom, d.tel, d.mail, p.idprofil, p.nom "
                       + "FROM developpeur d JOIN profil p ON d.idprofil = p.idprofil "
                       + "ORDER BY d.nom, d.prenom;";
            try
            {
                List<object[]> records = access.Manager.ReqSelect(req);
                if (records != null)
                {
                    foreach (object[] record in records)
                    {
                        Profil profil = new Profil((int)record[5], (string)record[6]);
                        Developpeur developpeur = new Developpeur((int)record[0], (string)record[1],
                            (string)record[2], (string)record[3], (string)record[4], profil);
                        lesDeveloppeurs.Add(developpeur);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
            return lesDeveloppeurs;
        }

        // demande de suppression d'un développeur
        public void DelDeveloppeur(Developpeur developpeur)
        {
            string req = "DELETE FROM developpeur WHERE iddeveloppeur = @iddeveloppeur;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@iddeveloppeur", developpeur.Iddeveloppeur }
            };
            ExecuteUpdate(req, parameters);
        }

        // demande d'ajout d'un développeur
        public void AddDeveloppeur(Developpeur developpeur)
        {
            string req = "INSERT INTO developpeur(nom, prenom, tel, mail, idprofil) "
                       + "VALUES (@nom, @prenom, @tel, @mail, @idprofil);";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@nom", developpeur.Nom },
                { "@prenom", developpeur.Prenom },
                { "@tel", developpeur.Tel },
                { "@mail", developpeur.Mail },
                { "@idprofil", developpeur.Profil.Idprofil }
            };
            ExecuteUpdate(req, parameters);
        }

        // demande de modification d'un développeur
        public void UpdateDeveloppeur(Developpeur developpeur)
        {
            string req = "UPDATE developpeur SET nom = @nom, prenom = @prenom, tel = @tel, "
                       + "mail = @mail, idprofil = @idprofil WHERE iddeveloppeur = @iddeveloppeur;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@iddeveloppeur", developpeur.Iddeveloppeur },
                { "@nom", developpeur.Nom },
                { "@prenom", developpeur.Prenom },
                { "@tel", developpeur.Tel },
                { "@mail", developpeur.Mail },
                { "@idprofil", developpeur.Profil.Idprofil }
            };
            ExecuteUpdate(req, parameters);
        }

        // demande de modification du pwd (haché en SHA2 directement dans la requête)
        public void UpdatePwd(Developpeur developpeur)
        {
            string req = "UPDATE developpeur SET pwd = SHA2(@pwd, 256) WHERE iddeveloppeur = @iddeveloppeur;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@iddeveloppeur", developpeur.Iddeveloppeur },
                { "@pwd", developpeur.Pwd }
            };
            ExecuteUpdate(req, parameters);
        }

        // contrôle si l'admin existe (nom, prénom, pwd) avec le profil 'admin'
        public bool ControleAuthentification(Admin admin)
        {
            string req = "SELECT d.iddeveloppeur FROM developpeur d JOIN profil p ON d.idprofil = p.idprofil "
                       + "WHERE d.nom = @nom AND d.prenom = @prenom AND d.pwd = SHA2(@pwd, 256) AND p.nom = 'admin';";
            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        { "@nom", admin.Nom },
        { "@prenom", admin.Prenom },
        { "@pwd", admin.Pwd }
    };
            try
            {
                List<object[]> records = access.Manager.ReqSelect(req, parameters);
                // vrai si au moins une ligne a été trouvée
                return (records != null && records.Count > 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
            return false;
        }

        // exécute une requête de mise à jour en capturant les erreurs
        private void ExecuteUpdate(string req, Dictionary<string, object> parameters)
        {
            try
            {
                access.Manager.ReqUpdate(req, parameters);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }
    }
}
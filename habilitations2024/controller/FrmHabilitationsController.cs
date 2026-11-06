using System.Collections.Generic;
using habilitations2024.dal;
using habilitations2024.model;

namespace habilitations2024.controller
{
    public class FrmHabilitationsController
    {
        // objet d'accès aux opérations possibles sur Developpeur
        private readonly DeveloppeurAccess developpeurAccess;
        // objet d'accès aux opérations possibles sur Profil
        private readonly ProfilAccess profilAccess;

        // récupère les accès aux données
        public FrmHabilitationsController()
        {
            developpeurAccess = new DeveloppeurAccess();
            profilAccess = new ProfilAccess();
        }

        // récupère et retourne la liste des développeurs
        public List<Developpeur> GetLesDeveloppeurs()
        {
            return developpeurAccess.GetLesDeveloppeurs();
        }

        // récupère et retourne la liste des profils
        public List<Profil> GetLesProfils()
        {
            return profilAccess.GetLesProfils();
        }

        // demande de suppression d'un développeur
        public void DelDeveloppeur(Developpeur developpeur)
        {
            developpeurAccess.DelDeveloppeur(developpeur);
        }

        // demande d'ajout d'un développeur
        public void AddDeveloppeur(Developpeur developpeur)
        {
            developpeurAccess.AddDeveloppeur(developpeur);
        }

        // demande de modification d'un développeur
        public void UpdateDeveloppeur(Developpeur developpeur)
        {
            developpeurAccess.UpdateDeveloppeur(developpeur);
        }

        // demande de changement de pwd
        public void UpdatePwd(Developpeur developpeur)
        {
            developpeurAccess.UpdatePwd(developpeur);
        }
    }
}
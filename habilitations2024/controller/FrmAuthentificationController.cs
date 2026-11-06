using habilitations2024.dal;
using habilitations2024.model;

namespace habilitations2024.controller
{
    public class FrmAuthentificationController
    {
        // objet d'accès aux opérations possibles sur Developpeur
        private readonly DeveloppeurAccess developpeurAccess;

        // récupère l'accès aux données
        public FrmAuthentificationController()
        {
            developpeurAccess = new DeveloppeurAccess();
        }

        // contrôle si l'admin a le droit de se connecter
        public bool ControleAuthentification(Admin admin)
        {
            return developpeurAccess.ControleAuthentification(admin);
        }
    }
}
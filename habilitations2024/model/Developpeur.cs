namespace habilitations2024.model
{
    public class Developpeur
    {
        public Developpeur(int iddeveloppeur, string nom, string prenom, string tel, string mail, Profil profil)
        {
            this.Iddeveloppeur = iddeveloppeur;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Profil = profil;
        }

        public int Iddeveloppeur { get; }    // jamais modifié
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string Pwd { get; set; }      // rempli seulement pour changer le mot de passe
        public Profil Profil { get; set; }   // un OBJET Profil, pas juste un idprofil
    }
}
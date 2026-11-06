namespace habilitations2024.model
{
    public class Profil
    {
        public Profil(int idprofil, string nom)
        {
            this.Idprofil = idprofil;
            this.Nom = nom;
        }

        public int Idprofil { get; }   // lecture seule
        public string Nom { get; }     // lecture seule

        // Quand on affiche un Profil (dans le combo ou le tableau), on veut juste son nom
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
namespace GestionBibliotheque.Models
{
    public class Auteur
    {
        public int IdAuteur { get; set; }
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public string Nationalite { get; set; } = string.Empty;
    }
}


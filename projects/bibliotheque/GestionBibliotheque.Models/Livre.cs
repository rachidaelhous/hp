namespace GestionBibliotheque.Models
{
    public class Livre
    {
        public int IdLivre { get; set; }
        public string Titre { get; set; } = string.Empty;
        public int AnneePublication { get; set; }
        public string ISBN { get; set; } = string.Empty;
        public bool Disponible { get; set; }
    }
}


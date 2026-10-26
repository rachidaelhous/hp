using System;

namespace GestionBibliotheque.Models
{
    public class Emprunt
    {
        public int IdEmprunt { get; set; }
        public int IdLivre { get; set; }
        public string NomEmprunteur { get; set; } = string.Empty;
        public DateTime DateEmprunt { get; set; }
        public DateTime DateRetourPrevue { get; set; }
        public DateTime? DateRetourReelle { get; set; }
        public decimal Penalite { get; set; }
    }

}

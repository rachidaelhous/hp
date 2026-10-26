using GestionBibliotheque.Models;
using GestionBibliotheque.DAL;
using System.Collections.Generic;

namespace GestionBibliotheque.BLL.Managers
{
    public class LivreManager
    {
        private readonly LivreDAL _livreDal = new LivreDAL();

        public List<Livre> GetAll()
        {
            return _livreDal.GetAll();
        }

        public List<Livre> GetDisponibles()
        {
            return _livreDal.GetDisponibles();
        }

        public void Add(Livre livre)
        {
            if (string.IsNullOrWhiteSpace(livre.Titre))
                throw new Exception("Le titre est obligatoire");

            _livreDal.Add(livre);
        }

        public void Update(Livre livre)
        {
            if (livre.IdLivre <= 0)
                throw new Exception("Livre invalide");

            _livreDal.Update(livre);
        }

        public void Delete(int idLivre)
        {
            if (idLivre <= 0)
                throw new Exception("Id invalide");

            _livreDal.Delete(idLivre);
        }
    }
}


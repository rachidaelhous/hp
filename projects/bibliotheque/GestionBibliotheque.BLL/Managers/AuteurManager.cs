using GestionBibliotheque.Models;
using GestionBibliotheque.DAL;
using System.Collections.Generic;

namespace GestionBibliotheque.BLL.Managers
{
    public class AuteurManager
    {
        private readonly AuteurDAL _auteurDal = new AuteurDAL();

        public List<Auteur> GetAll()
        {
            return _auteurDal.GetAll();
        }

        public void Add(Auteur auteur)
        {
            if (string.IsNullOrWhiteSpace(auteur.Nom))
                throw new Exception("Nom obligatoire");

            _auteurDal.Add(auteur);
        }

        public void Update(Auteur auteur)
        {
            _auteurDal.Update(auteur);
        }

        public void Delete(int idAuteur)
        {
            _auteurDal.Delete(idAuteur);
        }
    }
}


using GestionBibliotheque.DAL;
using GestionBibliotheque.Models;
using System;
using System.Collections.Generic;

namespace GestionBibliotheque.BLL.Managers
{
    public class EmpruntManager
    {
        private readonly EmpruntDAL _dal = new();
        private const decimal TARIF_PAR_JOUR = 2.0m;

        public void Emprunter(Emprunt e)
        {
            if (_dal.HasEmpruntActif(e.IdLivre))
                throw new Exception("Ce livre est déjà emprunté.");

            _dal.Add(e);
        }

        public void Retourner(Emprunt e)
        {
            e.Penalite = CalculerPenalite(
                e.DateRetourPrevue,
                e.DateRetourReelle!.Value);

            _dal.Retourner(e);
        }

        public decimal CalculerPenalite(DateTime prevue, DateTime reelle)
        {
            int joursRetard = (reelle.Date - prevue.Date).Days;
            return joursRetard > 0 ? joursRetard * TARIF_PAR_JOUR : 0;
        }

        public List<Emprunt> GetAll()
        {
            return _dal.GetActifs();
        }

        // pour ComboBox
        public List<Livre> GetLivresDisponibles()
        {
            return new LivreDAL().GetDisponibles();
        }
    }
}

using GestionBibliotheque.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace GestionBibliotheque.DAL
{
    public class LivreDAL
    {
        // Tous les livres
        public List<Livre> GetAll()
        {
            List<Livre> livres = new();

            using SqlConnection cn = DatabaseHelper.GetConnection();
            cn.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Livres", cn);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                livres.Add(new Livre
                {
                    IdLivre = (int)rd["IdLivre"],
                    Titre = rd["Titre"].ToString(),
                    AnneePublication = rd["AnneePublication"] == DBNull.Value
                        ? 0
                        : (int)rd["AnneePublication"],
                    ISBN = rd["ISBN"].ToString(),
                    Disponible = (bool)rd["Disponible"]
                });
            }

            return livres;
        }

        // ✅ Livres disponibles (IMPORTANT pour EmpruntManager)

        public List<Livre> GetDisponibles()
        {
            List<Livre> livres = new();

            using SqlConnection cn = DatabaseHelper.GetConnection();
            cn.Open();

            using SqlCommand cmd = new SqlCommand(
                "SELECT IdLivre, Titre FROM Livres WHERE Disponible = 1", cn);

            using SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                livres.Add(new Livre
                {
                    IdLivre = (int)rd["IdLivre"],
                    Titre = rd["Titre"].ToString()
                });
            }

            return livres;
        }

        // Ajouter
        public void Add(Livre livre)
        {
            using SqlConnection cn = DatabaseHelper.GetConnection();
            cn.Open();

            SqlCommand cmd = new SqlCommand(
                @"INSERT INTO Livres (Titre, AnneePublication, ISBN, Disponible)
                  VALUES (@t,@a,@i,@d)", cn);

            cmd.Parameters.AddWithValue("@t", livre.Titre);
            cmd.Parameters.AddWithValue("@a", livre.AnneePublication);
            cmd.Parameters.AddWithValue("@i", livre.ISBN);
            cmd.Parameters.AddWithValue("@d", livre.Disponible);

            cmd.ExecuteNonQuery();
        }

        // Modifier
        public void Update(Livre livre)
        {
            using SqlConnection cn = DatabaseHelper.GetConnection();
            cn.Open();

            SqlCommand cmd = new SqlCommand(
                @"UPDATE Livres 
                  SET Titre=@t, AnneePublication=@a, ISBN=@i, Disponible=@d 
                  WHERE IdLivre=@id", cn);

            cmd.Parameters.AddWithValue("@id", livre.IdLivre);
            cmd.Parameters.AddWithValue("@t", livre.Titre);
            cmd.Parameters.AddWithValue("@a", livre.AnneePublication);
            cmd.Parameters.AddWithValue("@i", livre.ISBN);
            cmd.Parameters.AddWithValue("@d", livre.Disponible);

            cmd.ExecuteNonQuery();
        }

        // Supprimer
        public void Delete(int id)
        {
            using SqlConnection cn = DatabaseHelper.GetConnection();
            cn.Open();

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Livres WHERE IdLivre=@id", cn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        // Changer disponibilité
        public void SetDisponible(int idLivre, bool dispo)
        {
            using SqlConnection cn = DatabaseHelper.GetConnection();
            cn.Open();

            SqlCommand cmd = new SqlCommand(
                "UPDATE Livres SET Disponible=@d WHERE IdLivre=@id", cn);

            cmd.Parameters.AddWithValue("@id", idLivre);
            cmd.Parameters.AddWithValue("@d", dispo);

            cmd.ExecuteNonQuery();
        }
    }
}

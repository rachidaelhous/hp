using GestionBibliotheque.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace GestionBibliotheque.DAL
{
    public class AuteurDAL
    {
        public List<Auteur> GetAll()
        {
            List<Auteur> auteurs = new List<Auteur>();

            using SqlConnection cn = DatabaseHelper.GetConnection();
            cn.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Auteurs", cn);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                auteurs.Add(new Auteur
                {
                    IdAuteur = (int)rd["IdAuteur"],
                    Nom = rd["Nom"].ToString(),
                    Prenom = rd["Prenom"].ToString(),
                    Nationalite = rd["Nationalite"]?.ToString()
                });
            }

            return auteurs;
        }

        public void Add(Auteur a)
        {
            using SqlConnection cn = DatabaseHelper.GetConnection();
            cn.Open();

            SqlCommand cmd = new SqlCommand(
                @"INSERT INTO Auteurs (Nom, Prenom, Nationalite)
                  VALUES (@n, @p, @nat)", cn);

            cmd.Parameters.AddWithValue("@n", a.Nom);
            cmd.Parameters.AddWithValue("@p", a.Prenom);
            cmd.Parameters.AddWithValue("@nat", a.Nationalite);

            cmd.ExecuteNonQuery();
        }

        public void Update(Auteur a)
        {
            using SqlConnection cn = DatabaseHelper.GetConnection();
            cn.Open();

            SqlCommand cmd = new SqlCommand(
                @"UPDATE Auteurs
                  SET Nom=@n, Prenom=@p, Nationalite=@nat
                  WHERE IdAuteur=@id", cn);

            cmd.Parameters.AddWithValue("@id", a.IdAuteur);
            cmd.Parameters.AddWithValue("@n", a.Nom);
            cmd.Parameters.AddWithValue("@p", a.Prenom);
            cmd.Parameters.AddWithValue("@nat", a.Nationalite);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using SqlConnection cn = DatabaseHelper.GetConnection();
            cn.Open();

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Auteurs WHERE IdAuteur=@id", cn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}

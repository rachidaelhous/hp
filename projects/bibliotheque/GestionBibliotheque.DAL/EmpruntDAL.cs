using GestionBibliotheque.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace GestionBibliotheque.DAL
{
    public class EmpruntDAL
    {
        // Vérifier si un livre est déjà emprunté
        public bool HasEmpruntActif(int idLivre)
        {
            using SqlConnection cn = DatabaseHelper.GetConnection();
            cn.Open();

            SqlCommand cmd = new SqlCommand(
                @"SELECT COUNT(*) 
                  FROM Emprunts 
                  WHERE IdLivre = @id AND DateRetourReelle IS NULL", cn);

            cmd.Parameters.AddWithValue("@id", idLivre);

            return (int)cmd.ExecuteScalar() > 0;
        }

        // ADD (pas Insert)
        public void Add(Emprunt e)
        {
            using SqlConnection cn = DatabaseHelper.GetConnection();
            cn.Open();

            SqlCommand cmd = new SqlCommand(
                @"INSERT INTO Emprunts
                  (IdLivre, NomEmprunteur, DateEmprunt, DateRetourPrevue)
                  VALUES (@livre, @nom, @de, @dr)", cn);

            cmd.Parameters.AddWithValue("@livre", e.IdLivre);
            cmd.Parameters.AddWithValue("@nom", e.NomEmprunteur);
            cmd.Parameters.AddWithValue("@de", e.DateEmprunt);
            cmd.Parameters.AddWithValue("@dr", e.DateRetourPrevue);

            cmd.ExecuteNonQuery();
        }

        // Retourner un livre
        public void Retourner(Emprunt e)
        {
            using SqlConnection cn = DatabaseHelper.GetConnection();
            cn.Open();

            SqlCommand cmd = new SqlCommand(
                @"UPDATE Emprunts
                  SET DateRetourReelle = @retour,
                      Penalite = @penalite
                  WHERE IdEmprunt = @id", cn);

            cmd.Parameters.AddWithValue("@id", e.IdEmprunt);
            cmd.Parameters.AddWithValue("@retour", e.DateRetourReelle);
            cmd.Parameters.AddWithValue("@penalite", e.Penalite);

            cmd.ExecuteNonQuery();
        }

        // Tous les emprunts
        public List<Emprunt> GetAll()
        {
            List<Emprunt> list = new();

            using SqlConnection cn = DatabaseHelper.GetConnection();
            cn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Emprunts", cn);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                list.Add(new Emprunt
                {
                    IdEmprunt = (int)rd["IdEmprunt"],
                    IdLivre = (int)rd["IdLivre"],
                    NomEmprunteur = rd["NomEmprunteur"].ToString(),
                    DateEmprunt = (DateTime)rd["DateEmprunt"],
                    DateRetourPrevue = (DateTime)rd["DateRetourPrevue"],
                    DateRetourReelle = rd["DateRetourReelle"] == DBNull.Value
                        ? null
                        : (DateTime?)rd["DateRetourReelle"],
                    Penalite = rd["Penalite"] == DBNull.Value
                        ? 0
                        : (decimal)rd["Penalite"]
                });
            }

            return list;
        }

        // Emprunts actifs
        public List<Emprunt> GetActifs()
        {
            List<Emprunt> list = new();

            using SqlConnection cn = DatabaseHelper.GetConnection();
            cn.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Emprunts WHERE DateRetourReelle IS NULL", cn);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                list.Add(new Emprunt
                {
                    IdEmprunt = (int)rd["IdEmprunt"],
                    IdLivre = (int)rd["IdLivre"],
                    NomEmprunteur = rd["NomEmprunteur"].ToString(),
                    DateEmprunt = (DateTime)rd["DateEmprunt"],
                    DateRetourPrevue = (DateTime)rd["DateRetourPrevue"]
                });
            }

            return list;
        }
    }
}

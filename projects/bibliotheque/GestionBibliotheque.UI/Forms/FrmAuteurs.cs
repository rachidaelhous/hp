using GestionBibliotheque.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionBibliotheque.UI.Forms
{
    public partial class FrmAuteurs : Form
    {
        private List<Auteur> auteurs = new List<Auteur>();
        private int compteurId = 1;

        public FrmAuteurs()
        {
            InitializeComponent();

            btnAjouter.Click += btnAjouter_Click;
            btnModifier.Click += btnModifier_Click;
            btnSupprimer.Click += btnSupprimer_Click;
            btnFermer.Click += btnFermer_Click;

            RafraichirGrid();
        }

        private void RafraichirGrid()
        {
            dgvAuteurs.DataSource = null;
            dgvAuteurs.DataSource = auteurs;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Auteur auteur = new Auteur
            {
                IdAuteur = compteurId++,
                Nom = txtNom.Text,
                Prenom = txtPrenom.Text,
                Nationalite = txtNationalite.Text
            };

            auteurs.Add(auteur);
            RafraichirGrid();
            Nettoyer();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvAuteurs.SelectedRows.Count == 0) return;

            Auteur auteur = (Auteur)dgvAuteurs.SelectedRows[0].DataBoundItem;

            auteur.Nom = txtNom.Text;
            auteur.Prenom = txtPrenom.Text;
            auteur.Nationalite = txtNationalite.Text;

            RafraichirGrid();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvAuteurs.SelectedRows.Count == 0) return;

            Auteur auteur = (Auteur)dgvAuteurs.SelectedRows[0].DataBoundItem;
            auteurs.Remove(auteur);
            RafraichirGrid();
            Nettoyer();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Nettoyer()
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtNationalite.Clear();
        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}


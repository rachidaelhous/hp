using GestionBibliotheque.BLL.Managers;
using GestionBibliotheque.Models;
using System;
using System.Windows.Forms;

namespace GestionBibliotheque.UI.Forms
{
    public partial class FrmEmprunts : Form
    {
        private readonly EmpruntManager _empruntManager = new();
        private readonly LivreManager _livreManager = new();

        public FrmEmprunts()
        {
            InitializeComponent();
            ChargerLivres();
            InitialiserDates();
        }

        // =========================
        // Initialisation
        // =========================
        private void ChargerLivres()
        {
            cmbLivres.DataSource = _livreManager.GetDisponibles();
            cmbLivres.DisplayMember = "Titre";
            cmbLivres.ValueMember = "IdLivre";
            cmbLivres.SelectedIndex = -1;
        }

        private void InitialiserDates()
        {
            dtpDateEmprunt.Value = DateTime.Today;
            dtpDateRetourPrevue.Value = DateTime.Today.AddDays(7);
            dtpDateRetourReelle.Value = DateTime.Today;
        }

        // =========================
        // Emprunter
        // =========================
        private void btnEmprunter_Click(object sender, EventArgs e)
        {
            if (cmbLivres.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtNomEmprunteur.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            try
            {
                Emprunt e1 = new Emprunt
                {
                    IdLivre = (int)cmbLivres.SelectedValue,
                    NomEmprunteur = txtNomEmprunteur.Text,
                    DateEmprunt = dtpDateEmprunt.Value,
                    DateRetourPrevue = dtpDateRetourPrevue.Value
                };

                _empruntManager.Emprunter(e1);
                MessageBox.Show("Emprunt enregistré avec succès.");

                ChargerLivres();
                ViderChamps();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================
        // Retourner
        // =========================
        private void btnRetourner_Click(object sender, EventArgs e)
        {
            if (cmbLivres.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un livre.");
                return;
            }

            Emprunt e1 = new Emprunt
            {
                IdLivre = (int)cmbLivres.SelectedValue,
                DateRetourPrevue = dtpDateRetourPrevue.Value,
                DateRetourReelle = dtpDateRetourReelle.Value
            };

            _empruntManager.Retourner(e1);

            MessageBox.Show("Livre retourné.");
            ChargerLivres();
            ViderChamps();
        }

        // =========================
        // Utilitaires
        // =========================
        private void ViderChamps()
        {
            txtNomEmprunteur.Clear();
            cmbLivres.SelectedIndex = -1;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

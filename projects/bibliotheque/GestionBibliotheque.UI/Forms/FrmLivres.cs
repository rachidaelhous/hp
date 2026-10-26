using GestionBibliotheque.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionBibliotheque.UI.Forms
{
    public partial class FrmLivres : Form
    {
        private List<Livre> livres = new List<Livre>();
        private int compteurId = 1;

        public FrmLivres()
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
            dgvLivres.DataSource = null;
            dgvLivres.DataSource = livres;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Livre livre = new Livre
            {
                IdLivre = compteurId++,
                Titre = txtTitre.Text,
                ISBN = txtISBN.Text,
                AnneePublication = int.Parse(txtAnnee.Text),
                Disponible = chkDisponible.Checked
            };

            livres.Add(livre);
            RafraichirGrid();
            Nettoyer();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvLivres.SelectedRows.Count == 0) return;

            Livre livre = (Livre)dgvLivres.SelectedRows[0].DataBoundItem;

            livre.Titre = txtTitre.Text;
            livre.ISBN = txtISBN.Text;
            livre.AnneePublication = int.Parse(txtAnnee.Text);
            livre.Disponible = chkDisponible.Checked;

            RafraichirGrid();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvLivres.SelectedRows.Count == 0) return;

            Livre livre = (Livre)dgvLivres.SelectedRows[0].DataBoundItem;
            livres.Remove(livre);
            RafraichirGrid();
            Nettoyer();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Nettoyer()
        {
            txtTitre.Clear();
            txtISBN.Clear();
            txtAnnee.Clear();
            chkDisponible.Checked = false;
        }

        
    }
}

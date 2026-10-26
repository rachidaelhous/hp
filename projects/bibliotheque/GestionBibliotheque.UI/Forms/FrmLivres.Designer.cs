using System.Windows.Forms;

namespace GestionBibliotheque.UI.Forms
{
    partial class FrmLivres
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView dgvLivres;
        private GroupBox grpLivre;
        private TextBox txtTitre;
        private TextBox txtISBN;
        private TextBox txtAnnee;
        private CheckBox chkDisponible;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSupprimer;
        private Button btnFermer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvLivres = new DataGridView();
            grpLivre = new GroupBox();
            lblTitre = new Label();
            txtTitre = new TextBox();
            lblISBN = new Label();
            txtISBN = new TextBox();
            lblAnnee = new Label();
            txtAnnee = new TextBox();
            chkDisponible = new CheckBox();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            btnFermer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLivres).BeginInit();
            grpLivre.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLivres
            // 
            dgvLivres.ColumnHeadersHeight = 34;
            dgvLivres.Location = new Point(328, 20);
            dgvLivres.Name = "dgvLivres";
            dgvLivres.ReadOnly = true;
            dgvLivres.RowHeadersWidth = 62;
            dgvLivres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLivres.Size = new Size(480, 300);
            dgvLivres.TabIndex = 1;
            // 
            // grpLivre
            // 
            grpLivre.Controls.Add(lblTitre);
            grpLivre.Controls.Add(txtTitre);
            grpLivre.Controls.Add(lblISBN);
            grpLivre.Controls.Add(txtISBN);
            grpLivre.Controls.Add(lblAnnee);
            grpLivre.Controls.Add(txtAnnee);
            grpLivre.Controls.Add(chkDisponible);
            grpLivre.Location = new Point(20, 20);
            grpLivre.Name = "grpLivre";
            grpLivre.Size = new Size(302, 220);
            grpLivre.TabIndex = 0;
            grpLivre.TabStop = false;
            grpLivre.Text = "Informations du livre";
            // 
            // lblTitre
            // 
            lblTitre.Location = new Point(15, 30);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(81, 28);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Titre";
            // 
            // txtTitre
            // 
            txtTitre.Location = new Point(169, 27);
            txtTitre.Name = "txtTitre";
            txtTitre.Size = new Size(127, 31);
            txtTitre.TabIndex = 1;
            // 
            // lblISBN
            // 
            lblISBN.Location = new Point(15, 70);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(70, 28);
            lblISBN.TabIndex = 2;
            lblISBN.Text = "ISBN";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(169, 67);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(127, 31);
            txtISBN.TabIndex = 3;
            // 
            // lblAnnee
            // 
            lblAnnee.Location = new Point(15, 110);
            lblAnnee.Name = "lblAnnee";
            lblAnnee.Size = new Size(81, 31);
            lblAnnee.TabIndex = 4;
            lblAnnee.Text = "Année";
            // 
            // txtAnnee
            // 
            txtAnnee.Location = new Point(169, 110);
            txtAnnee.Name = "txtAnnee";
            txtAnnee.Size = new Size(127, 31);
            txtAnnee.TabIndex = 5;
            // 
            // chkDisponible
            // 
            chkDisponible.Location = new Point(90, 145);
            chkDisponible.Name = "chkDisponible";
            chkDisponible.Size = new Size(172, 31);
            chkDisponible.TabIndex = 6;
            chkDisponible.Text = "Disponible";
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(40, 260);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(94, 46);
            btnAjouter.TabIndex = 2;
            btnAjouter.Text = "Ajouter";
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(140, 260);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(142, 46);
            btnModifier.TabIndex = 3;
            btnModifier.Text = "Modifier";
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(40, 325);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(144, 38);
            btnSupprimer.TabIndex = 4;
            btnSupprimer.Text = "Supprimer";
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(206, 320);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(116, 48);
            btnFermer.TabIndex = 5;
            btnFermer.Text = "Fermer";
            btnFermer.Click += btnFermer_Click_1;
            // 
            // FrmLivres
            // 
            ClientSize = new Size(820, 400);
            Controls.Add(grpLivre);
            Controls.Add(dgvLivres);
            Controls.Add(btnAjouter);
            Controls.Add(btnModifier);
            Controls.Add(btnSupprimer);
            Controls.Add(btnFermer);
            Name = "FrmLivres";
            Text = "Gestion des Livres";
            ((System.ComponentModel.ISupportInitialize)dgvLivres).EndInit();
            grpLivre.ResumeLayout(false);
            grpLivre.PerformLayout();
            ResumeLayout(false);
        }

        private Label lblTitre;
        private Label lblISBN;
        private Label lblAnnee;
    }
}

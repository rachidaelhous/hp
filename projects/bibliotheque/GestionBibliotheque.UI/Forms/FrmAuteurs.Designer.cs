using System.Windows.Forms;

namespace GestionBibliotheque.UI.Forms
{
    partial class FrmAuteurs
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView dgvAuteurs;
        private GroupBox grpAuteur;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private TextBox txtNationalite;
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
            dgvAuteurs = new DataGridView();
            grpAuteur = new GroupBox();
            lblNom = new Label();
            txtNom = new TextBox();
            lblPrenom = new Label();
            txtPrenom = new TextBox();
            lblNationalite = new Label();
            txtNationalite = new TextBox();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            btnFermer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAuteurs).BeginInit();
            grpAuteur.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAuteurs
            // 
            dgvAuteurs.ColumnHeadersHeight = 34;
            dgvAuteurs.Location = new Point(353, 20);
            dgvAuteurs.Name = "dgvAuteurs";
            dgvAuteurs.ReadOnly = true;
            dgvAuteurs.RowHeadersWidth = 62;
            dgvAuteurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuteurs.Size = new Size(615, 300);
            dgvAuteurs.TabIndex = 1;
            // 
            // grpAuteur
            // 
            grpAuteur.Controls.Add(lblNom);
            grpAuteur.Controls.Add(txtNom);
            grpAuteur.Controls.Add(lblPrenom);
            grpAuteur.Controls.Add(txtPrenom);
            grpAuteur.Controls.Add(lblNationalite);
            grpAuteur.Controls.Add(txtNationalite);
            grpAuteur.Location = new Point(20, 20);
            grpAuteur.Name = "grpAuteur";
            grpAuteur.Size = new Size(301, 200);
            grpAuteur.TabIndex = 0;
            grpAuteur.TabStop = false;
            grpAuteur.Text = "Informations de l’auteur";
            // 
            // lblNom
            // 
            lblNom.Location = new Point(15, 30);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(100, 23);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nom";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(174, 27);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(100, 31);
            txtNom.TabIndex = 1;
            // 
            // lblPrenom
            // 
            lblPrenom.Location = new Point(15, 70);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(100, 23);
            lblPrenom.TabIndex = 2;
            lblPrenom.Text = "Prénom";
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(174, 67);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(100, 31);
            txtPrenom.TabIndex = 3;
            // 
            // lblNationalite
            // 
            lblNationalite.Location = new Point(15, 110);
            lblNationalite.Name = "lblNationalite";
            lblNationalite.Size = new Size(100, 23);
            lblNationalite.TabIndex = 4;
            lblNationalite.Text = "Nationalité";
            // 
            // txtNationalite
            // 
            txtNationalite.Location = new Point(174, 110);
            txtNationalite.Name = "txtNationalite";
            txtNationalite.Size = new Size(100, 31);
            txtNationalite.TabIndex = 5;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(1, 260);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(114, 38);
            btnAjouter.TabIndex = 2;
            btnAjouter.Text = "Ajouter";
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(140, 260);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(110, 38);
            btnModifier.TabIndex = 3;
            btnModifier.Text = "Modifier";
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(300, 340);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(114, 37);
            btnSupprimer.TabIndex = 4;
            btnSupprimer.Text = "Supprimer";
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(420, 340);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(120, 37);
            btnFermer.TabIndex = 5;
            btnFermer.Text = "Fermer";
            btnFermer.Click += btnFermer_Click_1;
            // 
            // FrmAuteurs
            // 
            ClientSize = new Size(1071, 400);
            Controls.Add(grpAuteur);
            Controls.Add(dgvAuteurs);
            Controls.Add(btnAjouter);
            Controls.Add(btnModifier);
            Controls.Add(btnSupprimer);
            Controls.Add(btnFermer);
            Name = "FrmAuteurs";
            Text = "Gestion des Auteurs";
            ((System.ComponentModel.ISupportInitialize)dgvAuteurs).EndInit();
            grpAuteur.ResumeLayout(false);
            grpAuteur.PerformLayout();
            ResumeLayout(false);
        }

        private Label lblNom;
        private Label lblPrenom;
        private Label lblNationalite;
    }
}

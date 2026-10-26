namespace GestionBibliotheque.UI.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnLivres = new Button();
            btnAuteurs = new Button();
            btnEmprunts = new Button();
            btnQuitter = new Button();
            SuspendLayout();
            // 
            // btnLivres
            // 
            btnLivres.Location = new Point(143, 102);
            btnLivres.Name = "btnLivres";
            btnLivres.Size = new Size(426, 34);
            btnLivres.TabIndex = 0;
            btnLivres.Text = "Gérer les Livres";
            btnLivres.UseVisualStyleBackColor = true;
            btnLivres.Click += btnLivres_Click_1;
            // 
            // btnAuteurs
            // 
            btnAuteurs.Location = new Point(143, 168);
            btnAuteurs.Name = "btnAuteurs";
            btnAuteurs.Size = new Size(426, 34);
            btnAuteurs.TabIndex = 1;
            btnAuteurs.Text = "Gérer les Auteurs";
            btnAuteurs.UseVisualStyleBackColor = true;
            btnAuteurs.Click += btnAuteurs_Click;
            // 
            // btnEmprunts
            // 
            btnEmprunts.Location = new Point(143, 242);
            btnEmprunts.Name = "btnEmprunts";
            btnEmprunts.Size = new Size(426, 34);
            btnEmprunts.TabIndex = 2;
            btnEmprunts.Text = "Gérer les Emprunts";
            btnEmprunts.UseVisualStyleBackColor = true;
            btnEmprunts.Click += btnEmprunts_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(498, 342);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(175, 34);
            btnQuitter.TabIndex = 3;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQuitter);
            Controls.Add(btnEmprunts);
            Controls.Add(btnAuteurs);
            Controls.Add(btnLivres);
            Name = "FrmMain";
            Text = "Gestion de la Bibliothèque";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLivres;
        private Button btnAuteurs;
        private Button btnEmprunts;
        private Button btnQuitter;
    }
}

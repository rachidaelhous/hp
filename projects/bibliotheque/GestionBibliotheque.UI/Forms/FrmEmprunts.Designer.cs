namespace GestionBibliotheque.UI.Forms
{
    partial class FrmEmprunts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpEmprunt = new GroupBox();
            txtPenalite = new TextBox();
            label6 = new Label();
            dtpDateRetourReelle = new DateTimePicker();
            label5 = new Label();
            dtpDateRetourPrevue = new DateTimePicker();
            label4 = new Label();
            dtpDateEmprunt = new DateTimePicker();
            label3 = new Label();
            cmbLivres = new ComboBox();
            label2 = new Label();
            txtNomEmprunteur = new TextBox();
            label1 = new Label();
            btnEmprunter = new Button();
            btnRetourner = new Button();
            btnFermer = new Button();
            dgvEmprunts = new DataGridView();
            grpEmprunt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmprunts).BeginInit();
            SuspendLayout();
            // 
            // grpEmprunt
            // 
            grpEmprunt.Controls.Add(txtPenalite);
            grpEmprunt.Controls.Add(label6);
            grpEmprunt.Controls.Add(dtpDateRetourReelle);
            grpEmprunt.Controls.Add(label5);
            grpEmprunt.Controls.Add(dtpDateRetourPrevue);
            grpEmprunt.Controls.Add(label4);
            grpEmprunt.Controls.Add(dtpDateEmprunt);
            grpEmprunt.Controls.Add(label3);
            grpEmprunt.Controls.Add(cmbLivres);
            grpEmprunt.Controls.Add(label2);
            grpEmprunt.Controls.Add(txtNomEmprunteur);
            grpEmprunt.Controls.Add(label1);
            grpEmprunt.Location = new Point(12, 12);
            grpEmprunt.Name = "grpEmprunt";
            grpEmprunt.Size = new Size(430, 330);
            grpEmprunt.TabIndex = 0;
            grpEmprunt.TabStop = false;
            grpEmprunt.Text = "Informations de l'emprunt";
            // 
            // txtPenalite
            // 
            txtPenalite.Location = new Point(210, 265);
            txtPenalite.Name = "txtPenalite";
            txtPenalite.Size = new Size(190, 31);
            txtPenalite.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 265);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 1;
            label6.Text = "Pénalité";
            // 
            // dtpDateRetourReelle
            // 
            dtpDateRetourReelle.Location = new Point(210, 212);
            dtpDateRetourReelle.Name = "dtpDateRetourReelle";
            dtpDateRetourReelle.Size = new Size(190, 31);
            dtpDateRetourReelle.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 215);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 1;
            label5.Text = "Date retour réelle";
            // 
            // dtpDateRetourPrevue
            // 
            dtpDateRetourPrevue.Location = new Point(210, 167);
            dtpDateRetourPrevue.Name = "dtpDateRetourPrevue";
            dtpDateRetourPrevue.Size = new Size(190, 31);
            dtpDateRetourPrevue.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 170);
            label4.Name = "label4";
            label4.Size = new Size(161, 25);
            label4.TabIndex = 3;
            label4.Text = "Date retour prévue";
            // 
            // dtpDateEmprunt
            // 
            dtpDateEmprunt.Location = new Point(210, 122);
            dtpDateEmprunt.Name = "dtpDateEmprunt";
            dtpDateEmprunt.Size = new Size(190, 31);
            dtpDateEmprunt.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 125);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 5;
            label3.Text = "Date emprunt";
            // 
            // cmbLivres
            // 
            cmbLivres.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLivres.Location = new Point(210, 77);
            cmbLivres.Name = "cmbLivres";
            cmbLivres.Size = new Size(190, 33);
            cmbLivres.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 80);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 7;
            label2.Text = "Livre";
            // 
            // txtNomEmprunteur
            // 
            txtNomEmprunteur.Location = new Point(210, 32);
            txtNomEmprunteur.Name = "txtNomEmprunteur";
            txtNomEmprunteur.Size = new Size(190, 31);
            txtNomEmprunteur.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 35);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 9;
            label1.Text = "Nom emprunteur";
            // 
            // btnEmprunter
            // 
            btnEmprunter.Location = new Point(12, 372);
            btnEmprunter.Name = "btnEmprunter";
            btnEmprunter.Size = new Size(112, 34);
            btnEmprunter.TabIndex = 1;
            btnEmprunter.Text = "Emprunter";
            btnEmprunter.UseVisualStyleBackColor = true;
            // 
            // btnRetourner
            // 
            btnRetourner.Location = new Point(144, 372);
            btnRetourner.Name = "btnRetourner";
            btnRetourner.Size = new Size(112, 34);
            btnRetourner.TabIndex = 2;
            btnRetourner.Text = "Retourner";
            btnRetourner.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(275, 372);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(112, 34);
            btnFermer.TabIndex = 3;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += btnFermer_Click;
            // 
            // dgvEmprunts
            // 
            dgvEmprunts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmprunts.Dock = DockStyle.Right;
            dgvEmprunts.Location = new Point(564, 0);
            dgvEmprunts.Name = "dgvEmprunts";
            dgvEmprunts.ReadOnly = true;
            dgvEmprunts.RowHeadersWidth = 62;
            dgvEmprunts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmprunts.Size = new Size(724, 450);
            dgvEmprunts.TabIndex = 4;
            // 
            // FrmEmprunts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 450);
            Controls.Add(dgvEmprunts);
            Controls.Add(btnFermer);
            Controls.Add(btnRetourner);
            Controls.Add(btnEmprunter);
            Controls.Add(grpEmprunt);
            Name = "FrmEmprunts";
            Text = "Gestion des emprunts";
            grpEmprunt.ResumeLayout(false);
            grpEmprunt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmprunts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmprunt;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.TextBox txtNomEmprunteur;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.ComboBox cmbLivres;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.DateTimePicker dtpDateEmprunt;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.DateTimePicker dtpDateRetourPrevue;
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.DateTimePicker dtpDateRetourReelle;
        private TextBox txtPenalite;
        private Label label6;
        private Button btnEmprunter;
        private Button btnRetourner;
        private Button btnFermer;
        private DataGridView dgvEmprunts;
    }
    }
   
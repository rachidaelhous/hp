using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBibliotheque.UI.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

       

        private void btnAuteurs_Click(object sender, EventArgs e)
        {
            FrmAuteurs f = new FrmAuteurs();
            f.ShowDialog();
        }

        private void btnEmprunts_Click(object sender, EventArgs e)
        {
            FrmEmprunts f = new FrmEmprunts();
            f.ShowDialog();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLivres_Click_1(object sender, EventArgs e)
        {
            FrmLivres f = new FrmLivres();
            f.ShowDialog();
        }
    }
}

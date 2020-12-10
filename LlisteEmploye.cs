using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATABU_Barnabas
{
    public partial class LlisteEmploye : Form
    {
        public LlisteEmploye()
        {
            InitializeComponent();
        }

        private void LlisteEmploye_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'mydbDataSet.person'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.personTableAdapter.Fill(this.mydbDataSet.person);

        }

        private void insertionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertion insert = new insertion();
            LlisteEmploye.ActiveForm.Hide();
            insert.Show();
        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void editerDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edition edit = new Edition();
            LlisteEmploye.ActiveForm.Hide();
            edit.Show();
        }

        private void supprimerDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supprimer sup = new Supprimer();
            LlisteEmploye.ActiveForm.Hide();
            sup.Show();
        }
    }
}

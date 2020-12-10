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
    public partial class Edition : Form
    {
        public Edition()
        {
            InitializeComponent();
        }

        private void Edition_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'mydbDataSet1.employe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employeTableAdapter.Fill(this.mydbDataSet1.employe);
            // TODO: cette ligne de code charge les données dans la table 'mydbDataSet1.person'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.personTableAdapter.Fill(this.mydbDataSet1.person);

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void insertionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertion insert = new insertion();
            Edition.ActiveForm.Hide();
            insert.Show();
        }

        private void listeDesEmployésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LlisteEmploye liste = new LlisteEmploye();
            Edition.ActiveForm.Hide();
            liste.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

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
    public partial class insertion : Form
    {
        public insertion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'mydbDataSet1.employe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employeTableAdapter.Fill(this.mydbDataSet1.employe);

        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void insertionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listeDesEmployésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LlisteEmploye liste = new LlisteEmploye();
            insertion.ActiveForm.Hide();
            liste.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var matriculeField = mat.Text;
            var nameField = nom.Text;
            var surnameField = pnom.Text;
            var adresseField = ad.Text;
            var salaireField = sal.Text;
            var primeField = prime.Text;

            

            LlisteEmploye liste = new LlisteEmploye();
            insertion.ActiveForm.Hide();
            liste.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void editerDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edition edit = new Edition();
            insertion.ActiveForm.Hide();
            edit.Show();
        }

        private void supprimerDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supprimer sup = new Supprimer();
            insertion.ActiveForm.Hide();
            sup.Show();
        }
    }
}

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
    public partial class Supprimer : Form
    {
        public Supprimer()
        {
            InitializeComponent();
        }

        private void insertionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertion ins = new insertion();
            Supprimer.ActiveForm.Hide();
            ins.Show();
        }

        private void listeDesEmployésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LlisteEmploye list = new LlisteEmploye();
            Supprimer.ActiveForm.Hide();
            list.Show();
        }

        private void editerDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edition edit = new Edition();
            Supprimer.ActiveForm.Hide();
            edit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

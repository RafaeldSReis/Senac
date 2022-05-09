using System;
using System.Windows.Forms;

namespace Crud
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void agendaCSQLServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgenda frm = new frmAgenda();
            frm.ShowDialog();
        }

        private void aPIViaCepCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViaCep frm = new frmViaCep();
            frm.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

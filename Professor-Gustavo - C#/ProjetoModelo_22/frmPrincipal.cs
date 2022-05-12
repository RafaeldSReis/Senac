using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModelo_22
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lógica1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogica1 frm = new frmLogica1();
            frm.ShowDialog();
        }

        private void lógica2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogica2 frm = new frmLogica2();
            frm.ShowDialog();
        }

        private void lógica3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogica3 frm = new frmLogica3();
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLogica4 frm = new frmLogica4();
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmLogica5 frm = new frmLogica5();
            frm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmLogica6 frm = new frmLogica6();
            frm.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmLogica7 frm = new frmLogica7();
            frm.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmLogica8 frm = new frmLogica8();
            frm.ShowDialog();
        }

        private void bancoDeDados1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanco1 frm = new frmBanco1();
            frm.ShowDialog();
        }

        private void bancoDeDados2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanco2 frm = new frmBanco2();
            frm.ShowDialog();
        }
    }
}

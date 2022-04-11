using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Modelo
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
            /* MessageBox.Show("Módulo em produção...", "Faz o PIX que fica pronto", 
                 MessageBoxButtons.OK, MessageBoxIcon.Information);*/

            // crindo um objeto da classe frmLogica 1
            frmLogica1 frm = new frmLogica1();
            // chamando o método que mostra o objeto na tela
           
            // frm.Show();
            frm.ShowDialog();

        }

        private void lógica2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogica2 frm = new frmLogica2();
            frm.ShowDialog();
        }
    }
}
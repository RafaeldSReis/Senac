using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque_Chico
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void cadastroFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCFornecedores frm = new frmCFornecedores();
            frm.ShowDialog();
        }

        private void cadastroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCliente frm = new frmCadCliente();
            frm.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_modelo_22
{
    public partial class frmParImpar : Form
    {
        public frmParImpar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1;
            n1 = int.Parse(txtN1.Text);
            if (n1 % 2 == 0)
            {
                lblResult.Text = n1 + " é um numero Par";
            }
            else
            {
                lblResult.Text = n1 + " é um numero Ímpar";
            }
        }
    }
}

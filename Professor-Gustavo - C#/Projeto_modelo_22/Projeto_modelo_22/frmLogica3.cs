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
    public partial class frmLogica3 : Form
    {
        public frmLogica3()
        {
            InitializeComponent();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0, media = 0;
            n1 = int.Parse(txtV1.Text);
            n2 = int.Parse(txtV2.Text);

            media = n1 + n2;
            lblResult.Text = "Resultado da soma " + txtV1.Text + " + " + txtV2.Text + " = " + media;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0, media = 0;
            n1 = int.Parse(txtV1.Text);
            n2 = int.Parse(txtV2.Text);

            media = n1 - n2;
            lblResult.Text = "Resultado da subtração " + txtV1.Text + " - " + txtV2.Text + " = " + media;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0, media = 0;
            n1 = int.Parse(txtV1.Text);
            n2 = int.Parse(txtV2.Text);

            media = n1 / n2;
            lblResult.Text = "Resultado da divisão " + txtV1.Text + " / " + txtV2.Text + " = " + media;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0, media = 0;
            n1 = int.Parse(txtV1.Text);
            n2 = int.Parse(txtV2.Text);

            media = n1 * n2;
            lblResult.Text = "Resultado da Multiplicação " + txtV1.Text + " * " + txtV2.Text + " = " + media;
        }
    }
}

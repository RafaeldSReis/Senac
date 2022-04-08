using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Modelo
{
    public partial class frmTestes : Form
    {
        public frmTestes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double N1, N2, N3, N4, Media;

            // Entrada
            N1 = double.Parse(txtN1.Text);
            N2 = double.Parse(txtN2.Text);
            N3 = double.Parse(txtN3.Text);
            N4 = double.Parse(txtN4.Text);

            // Processamento
            Media = (N1 + N2 + N3 + N4) / 4;

            // Saida
            lblResultado.Text = "A média das notas é : " + Media.ToString("N2");
        }
    }
}

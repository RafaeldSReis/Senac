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
    public partial class frmLogica2 : Form
    {
        public frmLogica2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Variáveis
            double n1=0, n2=0, media=0;
            
            // Entrada
            n1 = int.Parse(txtKm.Text);
            n2 = int.Parse(txtHr.Text);
            // Processamento
            media = (n1 / n2);
            // Sair
            MessageBox.Show("Media de Velocidade é: " + media +"KM/Hora");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHr.Clear();
            txtKm.Clear();
        }
    }
}

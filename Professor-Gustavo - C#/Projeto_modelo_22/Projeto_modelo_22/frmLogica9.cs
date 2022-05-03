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
    public partial class frmLogica9 : Form
    {
        public frmLogica9()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int soma = 0;
            lstResult.Items.Clear();
            for(int i = 1; i <= n1; i++)
            {
                soma = soma + i;
                lstResult.Items.Add("Somando... " + soma.ToString());
            }
        }

        private void btnSoma2_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int total = 0;
            lstResult.Items.Clear();

            total = (1 + n1) * (n1 / 2);
            lstResult.Items.Add("Somando... " + total.ToString());
        }
    }
}

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
            int n1 = int.Parse(txtNumeroFinal.Text);
            int soma = 0;
            for (int i = 1; i <= n1; i++)
            {
                soma = i + soma;
                listSoma.Items.Add("Somando... " + soma);
            }
        }
    }
}

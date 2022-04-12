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
    public partial class frmLogica1 : Form
    {
        public frmLogica1()
        {
            InitializeComponent();
        }

        private void frmLogica1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0, n3 = 0, n4 = 0, media = 0; // Variaveis

            // convertendo string para number
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            n3 = double.Parse(txtN3.Text);
            n4 = Convert.ToDouble(txtN4.Text);
            media = (n1 + n2 + n3 + n4) / 4;

            lblName.Text = txtName.Text;
            lblResult.Text = "Sua média é: " + Convert.ToString(media); // Resultado da média
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            /* Limpando campos */
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtN4.Clear();

            txtName.Text = "";
            lblResult.Text = "";
            lblName.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Sair
            this.Close();
        }
    }
}

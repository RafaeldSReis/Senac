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
    public partial class frmCalcIMC : Form
    {
        public frmCalcIMC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1=0, n2=0, result=0;

            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);

            result = n1 / (n2 * n2);

            txtIMC.Text = result.ToString("N2");


            if(result < 18.5)
            {
                lblResult.Text = "Peso baixo";
            }
            if(result >= 18.5 && result < 24.9 )
            {
                lblResult.Text = "Peso normal";
            }
            if( result >= 25 && result < 29.9)
            {
                lblResult.Text = "Sobrepeso";
            }
            if (result >= 30 && result < 34.9)
            {
                lblResult.Text = "Obesidade (Grau I)";
            }
            if (result >= 35 && result < 39.9)
            {
                lblResult.Text = "Obesidade Severa (Grau II)";
            }
            if (result >= 40 )
            {
                lblResult.Text = "Obesidade Morbida (Grau III)";
            }
        }
       
    }
}

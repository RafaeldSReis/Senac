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


            
        }
    }
}

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
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n1 = int.Parse(txtN1.Text);
            for(int i = 1; i <= 10; i++)
            {
                listResult.Items.Add(n1 + "x" + i + " = " + (n1 * i));               
            }
            
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();
        }
    }
}

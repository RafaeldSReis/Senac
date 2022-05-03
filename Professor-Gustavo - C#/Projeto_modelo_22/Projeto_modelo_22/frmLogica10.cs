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
    public partial class frmLogica10 : Form
    {
        public frmLogica10()
        {
            InitializeComponent();
        }

        private void btnRodar_Click(object sender, EventArgs e)
        {
            int n1,n2,n3;

            
            for(n1 = 0; n1 <= 9; n1++)
                for(n2 = 0; n2 <= 9; n2++)
                    for(n3 = 0; n3 <= 9; n3++)
                    {
                        txtUnidade.Text = (n3.ToString());
                        txtDezena.Text = (n2.ToString());
                        txtCentena.Text = (n1.ToString());
                        MessageBox.Show("STOP");
                    }

        }
    }
}

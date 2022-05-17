using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModelo_22
{
    public partial class frmLogica7 : Form
    {
        public frmLogica7()
        {
            InitializeComponent();
        }

        private void btnRodar_Click(object sender, EventArgs e)
        {
            for (int c = 0; c <= 9; c++)
            {
                for (int d = 0; d <= 9; d++)
                {
                    for (int u = 0; u <= 9; u++)
                    {

                        txtCentena.Text = c.ToString();
                        txtDezena.Text = d.ToString();
                        txtUnidade.Text = u.ToString();
                        //MessageBox.Show("Parando passo a passo");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int c = 0; c <= 9; c++)
            {
                for (int d = 0; d <= 9; d++)
                {
                    for (int u = 0; u <= 9; u++)
                    {

                        txtCentena.Text = c.ToString();
                        txtDezena.Text = d.ToString();
                        txtUnidade.Text = u.ToString();

                        if (txtNumero.Text == txtCentena.Text + txtDezena.Text + txtUnidade.Text)
                        {
                            return;
                        }

                    }
                }
            }
        }
    }
}

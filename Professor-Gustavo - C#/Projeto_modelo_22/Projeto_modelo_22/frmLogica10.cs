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
            int c, d, u;
            
            for(c = 0; c <= 9; c++)
                for(d = 0; d <= 9; d++)
                    for(u = 0; u <= 9; u++)
                    {
                        txtUnidade.Text = (c.ToString());
                        txtDezena.Text = (d.ToString());
                        txtCentena.Text = (u.ToString());
                        MessageBox.Show("STOP");
                    }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            int c, d, u;
            for (c = 0; c <= 9; c++)
                for (d = 0; d <= 9; d++)
                    for (u = 0; u <= 9; u++)
                    {
                        txtUnidade.Text = (c.ToString());
                        txtDezena.Text = (d.ToString());
                        txtCentena.Text = (u.ToString());                        
                    }
        }
    }
}

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
    public partial class frmAltoBaixo : Form
    {
        public frmAltoBaixo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            double alt = double.Parse(txtAlt.Text);

            listName.Items.Add("Nome: " + name);
            listAlt.Items.Add(alt);
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
                      
        }
    }
}

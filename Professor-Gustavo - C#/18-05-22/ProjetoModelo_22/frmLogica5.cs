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
    public partial class frmLogica5 : Form
    {
        public frmLogica5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // while
            //int i = 1;
            //while (i <= 10)
            //{
            //    listBox1.Items.Add(i + " x " + txtTabuada.Text + " = " + i * int.Parse(txtTabuada.Text));
            //    i++;
            //}

            // for

            for(int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i + " x " + txtTabuada.Text + " = " + i * int.Parse(txtTabuada.Text));
            }
        }
    }
}


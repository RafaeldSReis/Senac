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
    public partial class frmIdade : Form
    {
        public frmIdade()
        {
            InitializeComponent();
        }        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);

            listBox.Items.Add("Nome: " + name );
            listAge.Items.Add(age);            
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach(int item in listAge.Items)
            {               
               if(item > 18)
                {
                    count++;
                    lblText.Text = ("Pessoas com mais de 18 anos: " + count);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            listAge.Items.Clear();
            lblText.Text = "--------------";
        }

        private void frmIdade_Load(object sender, EventArgs e)
        {

        }
    }
}

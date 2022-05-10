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
    public partial class frmLogica8 : Form
    {
        int qtd;
        double preco, subtotal, total;

        private void frmLogica8_Load(object sender, EventArgs e)
        {
            lstItens.Items.Add("Produto --- Preço --- Qtd --- Subtotal");
            lstItens.Items.Add("");
        }

        public frmLogica8()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            qtd = int.Parse(numQuantidade.Value.ToString());
            preco = double.Parse(txtPreco.Text);
            subtotal = preco * qtd;
            lstItens.Items.Add(cboProdutos.SelectedItem.ToString() + " --- " 
                + preco.ToString("N2") + " --- " + qtd.ToString() + " --- " + subtotal.ToString("N2"));
            total = total + subtotal;
            txtTotal.Text = total.ToString("N2");


        }
    }
}

using System;
using System.Windows.Forms;
/*
 -- Criar uma Referencia de Serviço usando a url = https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente?wsdl da API
 -- Verifica se o campo não esta vazio
 -- Estanciar uma Referencia do WebService
 -- Exibir para o Usuario 
*/
namespace Crud
{
    public partial class frmViaCep : Form
    {
        public frmViaCep()
        {
            InitializeComponent();
        }
        // Usando API Correios
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            // Verifica se o campo não esta vazio
            if(!string.IsNullOrWhiteSpace(txtCep.Text))
            {
                // Referencia do WebService
                using (var ws = new WScorreios.AtendeClienteClient())
                {
                    // Conectando a API
                    try
                    {
                        var endereco = ws.consultaCEP(txtCep.Text.Trim());
                       
                        txtEs.Text = endereco.uf;
                        txtCit.Text = endereco.cidade;
                        txtBairro.Text = endereco.bairro;
                        txtRua.Text = endereco.end;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("Informe um CEP válido...", this.Text, MessageBoxButtons.OK);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCep.Clear();
            txtBairro.Clear();
            txtCit.Clear();
            txtEs.Clear();
            txtRua.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}

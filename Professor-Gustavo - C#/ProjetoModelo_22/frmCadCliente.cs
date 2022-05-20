using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// importando as classes para usar o banco de dados SQL Server
using System.Data.SqlClient;
// importanto as classes para acessar o arquivo App.Config
using System.Configuration;

namespace ProjetoModelo_22
{
    public partial class frmCadCliente : Form
    {
        // criando a variável string que tem a conexão com o banco de dados
        // 1 é o Northwind e 2 é o banco chicó )
        private string connectionString =
    ConfigurationManager.ConnectionStrings[2].ConnectionString;

        public frmCadCliente()
        {
            InitializeComponent();
        }

        // método que reseta a tela para começar a operar sem sujeiras e travas no código
        private void resetaTela()
        {
            // somente o botão Adicionar pode ser clicado
            btnAdicionar.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;

            // limpando todas as caixas de texto 
            lblCodigo.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtCpf.Text = String.Empty;
            txtRg.Text = String.Empty;
            txtCep.Text = String.Empty;
            txtEstado.Text = String.Empty;
            txtCidade.Text = String.Empty;
            txtBairro.Text = String.Empty;
            txtRua.Text = String.Empty;
            txtTelefone.Text = String.Empty;

            // desabilitando todas as caixas de texto
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtRg.Enabled = false;
            txtCep.Enabled = false;
            txtEstado.Enabled = false;
            txtCidade.Enabled = false;
            txtBairro.Enabled = false;
            txtRua.Enabled = false;
            txtTelefone.Enabled = false;
        }

        // método que carrega a grid com base na instrução SQL 
        private void carregaGrid()
        {

            // Sql que filtra com a cláusula LIKE - Aula do Fábio
            string sql = "SELECT codcli, nome ,cpf ,rg, rua, telefone, cidade, cep, bairro, estado " +
"FROM Clientes WHERE (nome + cpf + rg + rua + telefone + cidade + cep + bairro + estado " +
"LIKE '%' + @PESQUISA + '%')";

            // cria objeto da classe de Conexão com o BD
            SqlConnection con = new SqlConnection(connectionString);
            // cria objeto da classe de Comandos ( executa comandos SQL no BD )
            SqlCommand cmd = new SqlCommand(sql, con);
            // adiciona paramento requerido na SQL criada, e o parametro vem do que foi digitado na Pesquisa
            cmd.Parameters.AddWithValue("@PESQUISA", txtPesquisa.Text);
            // configura o tipo de comando para texto
            cmd.CommandType = CommandType.Text;
            // abre conexão com o BD
            con.Open();
            try
            {
                // cria objeto clone de tabela do BD
                DataTable table = new DataTable();
                // carrega o objeto com o Select que a SQL pediu para o BD
                table.Load(cmd.ExecuteReader());
                // associa a tabela gerada ao datagrid
                dgvDados.DataSource = table;
            }
            catch (Exception ex)
            {
                // só passa por aqui se der erro no bloco do Try acima
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                // incondicionamente passa por aqui para fechar a conexão com o BD
                con.Close();
                //novo = false;
            }
        }

        // método executado quando a tela de clientes é carregada na memória
        private void frmCadCliente_Load(object sender, EventArgs e)
        {

            resetaTela();
            carregaGrid();
        }

        // método executado quando o botão Adicionar é clicado
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Ajustes de botões ligado/desligado
            btnAdicionar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            // Habilitar as caixas de texto
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtRg.Enabled = true;
            txtCep.Enabled = true;
            txtEstado.Enabled = true;
            txtCidade.Enabled = true;
            txtBairro.Enabled = true;
            txtRua.Enabled = true;
            txtTelefone.Enabled = true;

            // Posiciona o cursor na caixa de texto indicada
            txtNome.Focus();
        }

        // método executado quando o botão Cancelar é clicado
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetaTela();
        }

        // método executado quando alguma célula da grid é clicada
        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ajustes de botões ligado/desligado
            btnAdicionar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = true;

            // Habilitar as caixas de texto
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtRg.Enabled = true;
            txtCep.Enabled = true;
            txtEstado.Enabled = true;
            txtCidade.Enabled = true;
            txtBairro.Enabled = true;
            txtRua.Enabled = true;
            txtTelefone.Enabled = true;

            // Posiciona o cursor na caixa de texto indicada
            txtNome.Focus();

            // captura cada coluna da grid e passa o valor convertido em texto para a caixa de texto da esquerda
            lblCodigo.Text = dgvDados.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvDados.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCpf.Text = dgvDados.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRg.Text = dgvDados.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtRua.Text = dgvDados.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTelefone.Text = dgvDados.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtCidade.Text = dgvDados.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtCep.Text = dgvDados.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtBairro.Text = dgvDados.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtEstado.Text = dgvDados.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        // método executado quando o texto digitado na caixa de pesquisa é alterado ( tempo real )
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            carregaGrid();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ProjetoModelo_22
{
    public partial class frmCadCliente : Form
    {
        private string connectionString =
    ConfigurationManager.ConnectionStrings[2].ConnectionString;

        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void resetaTela()
        {
            btnAdicionar.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;

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

        private void carregaGrid()
        {
            string sql = "SELECT * FROM Clientes";


            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.Parameters.AddWithValue("@PESQUISA", txtPesquisa.Text);
            //cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgvDados.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
                //novo = false;
            }
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            resetaTela();
            carregaGrid();
        }

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetaTela();
        }
    }
}

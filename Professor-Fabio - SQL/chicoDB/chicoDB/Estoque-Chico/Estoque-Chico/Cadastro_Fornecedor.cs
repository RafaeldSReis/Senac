using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Estoque_Chico
{
    public partial class frmCFornecedores : Form
    {

        private string conexao =
        ConfigurationManager.ConnectionStrings[1].ConnectionString;
        public frmCFornecedores()
        {
            InitializeComponent();
        }

        private void carregaGrid()
        {
            string sql = "SELECT * FROM  Fornecedores";

            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.CommandType = CommandType.Text;
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
            }
        }       

        private void frmHome_Load(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void adicionarFornecedores()
        {
            try
            {
                string sql =
                "INSERT INTO Fornecedores (razaosocial,nomefab,cnpj,cep,rua,bairro,cidade,estado,telefone,email)" +
                " VALUES (@RAZAO,@NAMEFAN,@CNPJ,@CEP,@RUA,@BAIRRO,@CIDADE,@ESTADO,@TELEFONE,@EMAIL)";

                SqlConnection con = new SqlConnection(conexao);
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@RAZAO", txtRazao.Text);
                cmd.Parameters.AddWithValue("@NAMEFAN", txtNomefan.Text);
                cmd.Parameters.AddWithValue("@CNPJ", txtCnpj.Text);
                cmd.Parameters.AddWithValue("@CEP", txtCep.Text);
                cmd.Parameters.AddWithValue("@RUA", txtRua.Text);
                cmd.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
                cmd.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
                cmd.Parameters.AddWithValue("@ESTADO", txtEs.Text);
                cmd.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Adiconado com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            adicionarFornecedores();
            carregaGrid();
        }
    }
}
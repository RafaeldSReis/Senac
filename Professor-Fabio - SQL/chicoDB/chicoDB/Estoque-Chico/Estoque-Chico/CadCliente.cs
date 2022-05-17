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
    public partial class frmCadCliente : Form
    {
        private string conexao =
        ConfigurationManager.ConnectionStrings[1].ConnectionString;

        public frmCadCliente()
        {
            InitializeComponent();
        }
        
        private void carregaGrid()
        {
            string sql = "SELECT * FROM Clientes";

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

        

        private void adicionarCliente()
        {
            try
            {
                string sql =
                "INSERT INTO Clientes(nome, cfp, rg, cep, rua, bairro, cidade, estado, telefone)" +
                " VALUES (@NOME,@CPF,@RG,@CEP,@RUA,@BAIRRO,@CIDADE,@ESTADO,@TELEFONE)";

                SqlConnection con = new SqlConnection(conexao);
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@NOME", txtNome.Text);
                cmd.Parameters.AddWithValue("@CPF", txtCpf.Text);
                cmd.Parameters.AddWithValue("@RG", txtRg.Text);
                cmd.Parameters.AddWithValue("@CEP", txtCep.Text);
                cmd.Parameters.AddWithValue("@RUA", txtRua.Text);
                cmd.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
                cmd.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
                cmd.Parameters.AddWithValue("@ESTADO", txtEstado.Text);
                cmd.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                

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

        private void editarCliente()
        {
            try
            {
                string sql =
                "UPDATE Clientes SET nome = @NOME, cpf = @CPF, rg = @RG, cep = @CEP, rua = @RUA, bairro = @BAIRRO," +
                "cidade = @CIDADE, estado = @ESTADO, telefone = @TELEFONE WHERE  codcli = @ID";

                SqlConnection con = new SqlConnection(conexao);
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@ID", txtID.Text);
                cmd.Parameters.AddWithValue("@NOME", txtNome.Text);
                cmd.Parameters.AddWithValue("@CPF", txtCpf.Text);
                cmd.Parameters.AddWithValue("@RG", txtRg.Text);
                cmd.Parameters.AddWithValue("@CEP", txtCep.Text);
                cmd.Parameters.AddWithValue("@RUA", txtRua.Text);
                cmd.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
                cmd.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
                cmd.Parameters.AddWithValue("@ESTADO", txtEstado.Text);
                cmd.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
              
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Editado com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

       
      /*  private void buscaID()
        {
            try
            {
                string sql = "SELECT * FROM  Fornecedores WHERE codfor = @ID";

                SqlConnection con = new SqlConnection(conexao);
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@ID", txtID.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txtNome.Text = (string)dr["nome"];
                    txtCpf.Text = (string)dr["cpf"];
                    txtRg.Text = (string)dr["rg"];
                    txtCep.Text = (string)dr["cep"];
                    txtRua.Text = (string)dr["rua"];
                    txtBairro.Text = (string)dr["bairro"];
                    txtCidade.Text = (string)dr["cidade"];
                    txtEstado.Text = (string)dr["estado"];
                    txtTelefone.Text = (string)dr["telefone"];                   
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscaID();
        }

       /* private void deleteFornecedor()
        {
            string sql = "DELETE FROM Fornecedores WHERE codfor = @ID";

            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@ID", txtID.Text);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            deleteFornecedor();
            carregaGrid();
        }*/       
        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            adicionarCliente();
            carregaGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editarCliente();
        }
    }
}

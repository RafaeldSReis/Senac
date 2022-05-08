using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class frmAgenda : Form
    {
        // SQL Comandos
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        string strSQL; // string de comandos

        public frmAgenda()
        {
            InitializeComponent();
        }
        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-KRLKM9V\SQLEXPRESS;Database=csharp;User id=sa;password=senac");

                strSQL = "INSERT INTO contact (name, phone) VALUES (@NAME, @PHONE)";

                comando = new SqlCommand(strSQL, conexao);

                // Adicionando os parametros
                comando.Parameters.AddWithValue("@NAME", txtNome.Text);
                comando.Parameters.AddWithValue("@PHONE", txtTelefone.Text);

                // Abrindo conexão e executando comando
                conexao.Open();
                if (txtNome.Text != "" && txtTelefone.Text != "")
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Adicionado com Sucesso");
                    txtNome.Clear();
                    txtTelefone.Clear();
                }
                else
                {
                    MessageBox.Show("Preencha os Campos!!");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
            carregaGrid();
        }
        void carregaGrid()
        {
            try
            {
                string nome = txtNome.Text;
                string telefone = txtTelefone.Text;

                conexao = new SqlConnection(@"Server=DESKTOP-KRLKM9V\SQLEXPRESS;Database=csharp;User id=sa;password=senac");

                strSQL = "SELECT * FROM contact";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                da.Fill(ds, "contact");

                dgvDados.DataSource = ds.Tables["contact"];

                foreach (DataGridViewColumn column in dgvDados.Columns)
                {
                    if (column.DataPropertyName == "ID")
                        column.Width = 20;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    if (column.DataPropertyName == "name")
                        column.Width = 80;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    if (column.DataPropertyName == "phone")
                        column.Width = 80;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void frmCrud_Load(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregaGrid();
            string id = dgvDados.CurrentRow.Cells["ID"].Value.ToString();
            string name = dgvDados.CurrentRow.Cells["name"].Value.ToString();
            string phone = dgvDados.CurrentRow.Cells["phone"].Value.ToString();
            if (id != "")
            {
                txtID.Text = id;
                txtNome.Text = name;
                txtTelefone.Text = phone;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {

                conexao = new SqlConnection(@"Server=DESKTOP-KRLKM9V\SQLEXPRESS;Database=csharp;User id=sa;password=senac");

                strSQL = "UPDATE contact SET name = @NAME, phone = @PHONE  WHERE name = @NAME";

                comando = new SqlCommand(strSQL, conexao);

                // Adicionando os parametros
                comando.Parameters.AddWithValue("@NAME", txtNome.Text);
                comando.Parameters.AddWithValue("@PHONE", txtTelefone.Text);

                // Abrindo conexão e executando comando
                conexao.Open();
                if (txtNome.Text != "" && txtTelefone.Text != "")
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Alterado com Sucesso");
                }
                else
                {
                    MessageBox.Show("2 Clique no Telefone!!");
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
            carregaGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-KRLKM9V\SQLEXPRESS;Database=csharp;User id=sa;password=senac");

                strSQL = "DELETE FROM contact  WHERE name = @NAME";

                comando = new SqlCommand(strSQL, conexao);

                // Adicionando os parametros
                comando.Parameters.AddWithValue("@NAME", txtNome.Text);
                
                // Abrindo conexão e executando comando
                conexao.Open();
                if (txtNome.Text != "" && txtTelefone.Text != "")
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Exluido com Sucesso");
                    txtNome.Clear();
                    txtTelefone.Clear();
                }
                else
                {
                    MessageBox.Show("2 Clique no Telefone!!");
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
            carregaGrid();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

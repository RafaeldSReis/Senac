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
    public partial class frmLogin : Form
    {
        // SQL Comandos
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        string strSQL; // string de comandos
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-KRLKM9V\SQLEXPRESS;Database=csharp;User id=sa;password=senac");

                strSQL = "INSERT INTO users (name, passwd) VALUES (@USER, @PASSWD)";

                comando = new SqlCommand(strSQL, conexao);

                // Adicionando os parametros
                comando.Parameters.AddWithValue("@USER", txtUsuario.Text);
                comando.Parameters.AddWithValue("@PASSWD", txtSenha.Text);

                // Abrindo conexão
                conexao.Open();

                // verificação
                if (txtUsuario.Text != "" && txtSenha.Text != "")
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Adicionado com Sucesso");
                    txtUsuario.Clear();
                    txtSenha.Clear();
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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {                
                string name = txtUsuario.Text;
                string passwd = txtSenha.Text;

                conexao = new SqlConnection(@"Server=DESKTOP-KRLKM9V\SQLEXPRESS;Database=csharp;User id=sa;password=senac");

                strSQL = "SELECT * FROM users WHERE name = @USUARIO AND passwd = @PASSWD";
              
                comando = new SqlCommand (strSQL, conexao);
                comando.Parameters.AddWithValue("@USUARIO", name);
                comando.Parameters.AddWithValue("@PASSWD", passwd);
                
                conexao.Open();
                comando.ExecuteNonQuery();

                da = new SqlDataAdapter(comando);

                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    frmHome frm = new frmHome();
                    this.Hide(); // fecha a tela login
                    frm.ShowDialog();                    
                }
                else
                {
                    MessageBox.Show("Usuario não encontrado");
                    conexao.Close();
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

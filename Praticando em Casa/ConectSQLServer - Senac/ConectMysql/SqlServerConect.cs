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

namespace ConectMysql
{
    public partial class frmConnect : Form
    {        
        private SqlConnection conexao;
        private string strSQL;
        private SqlCommand command;

        public frmConnect()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Botão cadastro
        private void btnConect_Click(object sender, EventArgs e)
        {
            try
            {        
                //Criar conexão com SQLServer               
                SqlConnection conexao = new SqlConnection(@"Data Source=.;Initial Catalog=csharp;User ID=sa;Password=senac");

                // Inserindo usuario
                strSQL = "INSERT INTO users (name, passwd) VALUES (@NAME, @PASSWD)";
                command = new SqlCommand(strSQL, conexao);
                command.Parameters.AddWithValue("@NAME", txtName.Text);
                command.Parameters.AddWithValue("@PASSWD", txtPasswd.Text);
                // abrindo conexao e executando o comando
                conexao.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com Sucesso!!!");                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }
            finally
            {        
                conexao = null;
                command = null;
            }
          
        }

        private object SqlCommand(string query, SqlConnection cnn)
        {
            throw new NotImplementedException();
        }

        // Botão Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Criar conexão com SQLServer               
                SqlConnection conexao = new SqlConnection(@"Data Source=.;Initial Catalog=csharp;User ID=sa;Password=senac");
                conexao.Open();

                // Busca no banco de dados
                string query = "SELECT * FROM users WHERE name = '" + txtName.Text + "' AND passwd = '" + txtPasswd.Text + "'";
                SqlDataAdapter dp = new SqlDataAdapter(query, conexao);
                DataTable dt = new DataTable();
                dp.Fill(dt);

                // Verifica se existe no BD
                if (dt.Rows.Count > 0)
                {
                   frmHome frm = new frmHome();
                   frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario nao Cadstrado");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }

        }
        // Botão Sair
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }
}

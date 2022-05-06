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
    public partial class frmHome : Form
    {
        private SqlConnection conexao;
        private string strSQL;
        private SqlCommand command;
        private SqlDataReader reader;

        public frmHome()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Criar conexão com SQLServer               
                conexao = new SqlConnection(@"Data Source=.;Initial Catalog=csharp;User ID=sa;Password=senac");

                // Inserindo usuario
                strSQL = "INSERT INTO contact (name, phone) VALUES (@NAME, @PHONE)";
                command = new SqlCommand(strSQL, conexao);
                command.Parameters.AddWithValue("@NAME", txtName.Text);
                command.Parameters.AddWithValue("@PHONE", txtPhone.Text);
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
            carregargrid();
        }
        // metodo que n retorna nada "void"
        void carregargrid()
        {

            try
            {
                string nome = txtName.Text;
                string phone = txtPhone.Text;
                conexao = new SqlConnection(@"Data Source=.;Initial Catalog=csharp;User ID=sa;Password=senac");
                conexao.Open();
                string query = "SELECT * FROM contact";
                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                cmd.Parameters.AddWithValue("@phone", "%" + phone + "%");
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "contact");
                dgvList.DataSource = ds.Tables["contact"];
                foreach (DataGridViewColumn column in dgvList.Columns)
                {
                    if (column.DataPropertyName == "ID")
                        column.Width = 10;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    if (column.DataPropertyName == "name")
                        column.Width = 80;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    if (column.DataPropertyName == "phone")
                        column.Width = 100;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            carregargrid();
        }
    }
}

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
                conexao = new SqlConnection(@"Data Source=DESKTOP-KRLKM9V\SQLEXPRESS;Initial Catalog=csharp;User ID=sa;Password=senac");

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
                conexao.Close();
                command.Clone();
                conexao = null;
                command = null;
            }
        }
       
        private void ltsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexao = new SqlConnection(@"Data Source=DESKTOP-KRLKM9V\SQLEXPRESS;Initial Catalog=csharp;User ID=sa;Password=senac");


            string query = "SELECT * FROM contact";
            SqlCommand dt = new SqlCommand(query, conexao);            

            try
            {
                conexao.Open();
                reader = dt.ExecuteReader();

                while (reader.Read())
                {

                    string name = reader.GetString("name");
                    ltsList.Items.Add(name);

                }
                conexao.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}

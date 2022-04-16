using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConectMysql
{
    public partial class frmConnect : Form
    {
        MySqlConnection Conexao;
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
                //Criar conexão com Mysql
                string data_source = "datasource=localhost;username=root;password=admin;database=csharp";               
                Conexao = new MySqlConnection(data_source);

                // Inserindo usuario
                string sql = "INSERT INTO users (email,passwd) VALUES " + "('" + txtEmail.Text + "', '" + txtPasswd.Text + "')";

                // Executando o comando
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Cadastrado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: "+ex.Message);
            } finally
            {
                // Encerra a conexão
                Conexao.Close();
            }
        }
        // Botão Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Criar conexão com Mysql
                string data_source = "datasource=localhost;username=root;password=admin;database=csharp";
                Conexao = new MySqlConnection(data_source);
                var comand = Conexao.CreateCommand();

                // Busca no banco de dados
                MySqlCommand query = new MySqlCommand("SELECT COUNT(*) FROM users WHERE email = '"+ txtEmail.Text + "'and passwd = '"+ txtPasswd.Text + "'", Conexao);
                Conexao.Open();

                // Convertento
                DataTable dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query);
                dataAdapter.Fill(dataTable);

                // Validando Conexão
                foreach(DataRow list in dataTable.Rows)
                {
                    if(Convert.ToInt32(list.ItemArray[0]) > 0){
                        frmHome frm = new frmHome();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario não Cadastrado");                        
                    }
                }
                
              
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }
            // Fechando Conexão
            {
                Conexao.Clone();
            }
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

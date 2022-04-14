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

        private void btnConect_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=admin;database=csharp";
                //Criar conexão com Mysql
                Conexao = new MySqlConnection(data_source);                
                string sql = "INSERT INTO users (email,passwd) VALUES " + "('" + txtEmail.Text + "', '" + txtPasswd.Text + "')";

                // Inserindo usuario
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Deu tudo Certo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: "+ex.Message);
            } finally
            {
                Conexao.Close();
            }
        }
    }
}

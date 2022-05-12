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

namespace ProjetoModelo_22
{
    public partial class frmBanco2 : Form
    {

        private string conexao =
ConfigurationManager.ConnectionStrings[1].ConnectionString;
        public frmBanco2()
        {
            InitializeComponent();
        }

        private void carregaGrid()
        {
            string sql = "SELECT ProductID 'Código',ProductName 'Produto',UnitPrice 'Preço',UnitsInStock 'Estoque' FROM Products WHERE categoryID = " + cboCategorias.SelectedValue;

            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgvProdutos.DataSource = table;
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

        private void carregaCombo()
        {
            SqlConnection con = new SqlConnection(conexao);
            con.Open();
            SqlCommand sql = new SqlCommand();
            sql.Connection = con;
            sql.CommandText = "SELECT CategoryID 'Código', CategoryName 'Categoria' FROM Categories";
            SqlDataReader dr = sql.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);

            cboCategorias.DisplayMember = "Categoria";
            cboCategorias.ValueMember = "Código";
            cboCategorias.DataSource = tb;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void frmBanco2_Load(object sender, EventArgs e)
        {
            carregaCombo();
        }
    }
}

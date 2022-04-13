namespace Projeto_modelo_22
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();        }

       
        private void logica1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* MessageBox.Show("Módulo em produção...", "Faz o PIX que fica pronto", 
              MessageBoxButtons.OK, MessageBoxIcon.Information);*/

            // crindo um objeto da classe frmLogica 1
            frmLogica1 frm = new frmLogica1();
            // chamando o método que mostra o objeto na tela

            // frm.Show();
            frm.ShowDialog();
        }

        private void logica2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmLogica2 frm = new frmLogica2();
            

            // frm.Show();
            frm.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
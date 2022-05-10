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

        private void logica3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcBasic frm = new CalcBasic();


            // frm.Show();
            frm.ShowDialog();
        }

        private void logica4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalcIMC frm = new frmCalcIMC();


            // frm.Show();
            frm.ShowDialog();
        }

        private void logica5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTabuada frm = new frmTabuada();


            // frm.Show();
            frm.ShowDialog();
        }

        private void logica6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmParImpar  frm = new frmParImpar();


            // frm.Show();
            frm.ShowDialog();
        }

        private void logica7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIdade frm = new frmIdade();


            // frm.Show();
            frm.ShowDialog();
        }

        private void logica8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltoBaixo frm = new frmAltoBaixo();

            frm.ShowDialog();
        }
        private void logica9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogica9 frm = new frmLogica9();
            frm.ShowDialog();
        }

        private void logica10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogica10 frm = new frmLogica10();
            frm.ShowDialog();
        }

        private void banco1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanco1 frm = new frmBanco1();
            frm.ShowDialog();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_modelo_22
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var name = "Rafael";
            var passwd = "admin";

            if(txtPassWord.Text == passwd && txtUser.Text == name)
            {
                frmMenu frm = new frmMenu();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario não Existe!");
            }
        }
    }
}

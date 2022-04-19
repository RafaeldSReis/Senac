namespace Projeto_modelo_22
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exerciciosDeLógicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logica1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logica2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logica3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosSQLServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exerciciosDeLógicaToolStripMenuItem,
            this.bancoDeDadosSQLServerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exerciciosDeLógicaToolStripMenuItem
            // 
            this.exerciciosDeLógicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logica1ToolStripMenuItem,
            this.logica2ToolStripMenuItem,
            this.logica3ToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.exerciciosDeLógicaToolStripMenuItem.Name = "exerciciosDeLógicaToolStripMenuItem";
            this.exerciciosDeLógicaToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.exerciciosDeLógicaToolStripMenuItem.Text = "Exercicios de Lógica";
            // 
            // logica1ToolStripMenuItem
            // 
            this.logica1ToolStripMenuItem.Name = "logica1ToolStripMenuItem";
            this.logica1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logica1ToolStripMenuItem.Text = "Logica 1";
            this.logica1ToolStripMenuItem.Click += new System.EventHandler(this.logica1ToolStripMenuItem_Click);
            // 
            // logica2ToolStripMenuItem
            // 
            this.logica2ToolStripMenuItem.Name = "logica2ToolStripMenuItem";
            this.logica2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logica2ToolStripMenuItem.Text = "Logica 2";
            this.logica2ToolStripMenuItem.Click += new System.EventHandler(this.logica2ToolStripMenuItem_Click);
            // 
            // logica3ToolStripMenuItem
            // 
            this.logica3ToolStripMenuItem.Name = "logica3ToolStripMenuItem";
            this.logica3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logica3ToolStripMenuItem.Text = "Logica 3";
            this.logica3ToolStripMenuItem.Click += new System.EventHandler(this.logica3ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // bancoDeDadosSQLServerToolStripMenuItem
            // 
            this.bancoDeDadosSQLServerToolStripMenuItem.Name = "bancoDeDadosSQLServerToolStripMenuItem";
            this.bancoDeDadosSQLServerToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
            this.bancoDeDadosSQLServerToolStripMenuItem.Text = "Banco de dados SQL Server";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 364);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem exerciciosDeLógicaToolStripMenuItem;
        private ToolStripMenuItem logica1ToolStripMenuItem;
        private ToolStripMenuItem logica2ToolStripMenuItem;
        private ToolStripMenuItem logica3ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem bancoDeDadosSQLServerToolStripMenuItem;
    }
}
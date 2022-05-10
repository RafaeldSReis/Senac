namespace Crud
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasPraticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaCSQLServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPIViaCepCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPICotaçãoCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasPraticaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasPraticaToolStripMenuItem
            // 
            this.programasPraticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaCSQLServerToolStripMenuItem,
            this.aPIViaCepCToolStripMenuItem,
            this.aPICotaçãoCToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.programasPraticaToolStripMenuItem.Name = "programasPraticaToolStripMenuItem";
            this.programasPraticaToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.programasPraticaToolStripMenuItem.Text = "Programas - Pratica";
            // 
            // agendaCSQLServerToolStripMenuItem
            // 
            this.agendaCSQLServerToolStripMenuItem.Name = "agendaCSQLServerToolStripMenuItem";
            this.agendaCSQLServerToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.agendaCSQLServerToolStripMenuItem.Text = "Agenda C# - SQLServer";
            this.agendaCSQLServerToolStripMenuItem.Click += new System.EventHandler(this.agendaCSQLServerToolStripMenuItem_Click);
            // 
            // aPIViaCepCToolStripMenuItem
            // 
            this.aPIViaCepCToolStripMenuItem.Name = "aPIViaCepCToolStripMenuItem";
            this.aPIViaCepCToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.aPIViaCepCToolStripMenuItem.Text = "API ViaCep C#";
            this.aPIViaCepCToolStripMenuItem.Click += new System.EventHandler(this.aPIViaCepCToolStripMenuItem_Click);
            // 
            // aPICotaçãoCToolStripMenuItem
            // 
            this.aPICotaçãoCToolStripMenuItem.Name = "aPICotaçãoCToolStripMenuItem";
            this.aPICotaçãoCToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.aPICotaçãoCToolStripMenuItem.Text = "API Cotação C#";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHome";
            this.Text = "Home Pratica";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasPraticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaCSQLServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPIViaCepCToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPICotaçãoCToolStripMenuItem;
    }
}
namespace ProjetoModelo_22
{
    partial class frmBanco2
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
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.btnCarregarDados = new System.Windows.Forms.Button();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProdutos
            // 
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutos.Location = new System.Drawing.Point(12, 35);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.RowTemplate.Height = 25;
            this.gridProdutos.Size = new System.Drawing.Size(766, 291);
            this.gridProdutos.TabIndex = 0;
            // 
            // btnCarregarDados
            // 
            this.btnCarregarDados.Location = new System.Drawing.Point(183, 6);
            this.btnCarregarDados.Name = "btnCarregarDados";
            this.btnCarregarDados.Size = new System.Drawing.Size(131, 23);
            this.btnCarregarDados.TabIndex = 1;
            this.btnCarregarDados.Text = "Carregar Dados";
            this.btnCarregarDados.UseVisualStyleBackColor = true;
            this.btnCarregarDados.Click += new System.EventHandler(this.btnCarregarDados_Click);
            // 
            // cboCategorias
            // 
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Location = new System.Drawing.Point(12, 7);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(165, 23);
            this.cboCategorias.TabIndex = 2;
            // 
            // frmBanco2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 351);
            this.Controls.Add(this.cboCategorias);
            this.Controls.Add(this.btnCarregarDados);
            this.Controls.Add(this.gridProdutos);
            this.Name = "frmBanco2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício de Banco de Dados 2";
            this.Load += new System.EventHandler(this.frmBanco2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView gridProdutos;
        private Button btnCarregarDados;
        private ComboBox cboCategorias;
    }
}
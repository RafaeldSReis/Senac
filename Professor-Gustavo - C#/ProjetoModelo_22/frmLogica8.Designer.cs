namespace ProjetoModelo_22
{
    partial class frmLogica8
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboProdutos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lstItens = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listagem de Produtos";
            // 
            // cboProdutos
            // 
            this.cboProdutos.FormattingEnabled = true;
            this.cboProdutos.Items.AddRange(new object[] {
            "Suco Del Valle",
            "Arroz Vasconcelos",
            "Café 3 Corações",
            "Feijão Tio Nobre",
            "Nutella",
            "Açucar Guarani",
            "Coca Cola Lata",
            "Filé Mignon 1kg"});
            this.cboProdutos.Location = new System.Drawing.Point(28, 38);
            this.cboProdutos.Name = "cboProdutos";
            this.cboProdutos.Size = new System.Drawing.Size(193, 23);
            this.cboProdutos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço Unitário";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(28, 92);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 23);
            this.txtPreco.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade";
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(28, 148);
            this.numQuantidade.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(105, 23);
            this.numQuantidade.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(28, 191);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "+";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lstItens
            // 
            this.lstItens.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstItens.FormattingEnabled = true;
            this.lstItens.ItemHeight = 15;
            this.lstItens.Location = new System.Drawing.Point(259, 12);
            this.lstItens.Name = "lstItens";
            this.lstItens.Size = new System.Drawing.Size(380, 229);
            this.lstItens.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(539, 247);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 9;
            // 
            // frmLogica8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 289);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstItens);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboProdutos);
            this.Controls.Add(this.label1);
            this.Name = "frmLogica8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício de Lógica 8";
            this.Load += new System.EventHandler(this.frmLogica8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cboProdutos;
        private Label label2;
        private TextBox txtPreco;
        private Label label3;
        private NumericUpDown numQuantidade;
        private Button btnAdicionar;
        private ListBox lstItens;
        private Label label4;
        private TextBox txtTotal;
    }
}
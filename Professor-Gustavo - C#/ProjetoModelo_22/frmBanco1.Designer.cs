namespace ProjetoModelo_22
{
    partial class frmBanco1
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
            this.gridDados = new System.Windows.Forms.DataGridView();
            this.btnCarregarDados = new System.Windows.Forms.Button();
            this.cboTabelas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDados
            // 
            this.gridDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDados.Location = new System.Drawing.Point(23, 18);
            this.gridDados.Name = "gridDados";
            this.gridDados.RowTemplate.Height = 25;
            this.gridDados.Size = new System.Drawing.Size(613, 278);
            this.gridDados.TabIndex = 0;
            // 
            // btnCarregarDados
            // 
            this.btnCarregarDados.Location = new System.Drawing.Point(176, 302);
            this.btnCarregarDados.Name = "btnCarregarDados";
            this.btnCarregarDados.Size = new System.Drawing.Size(134, 23);
            this.btnCarregarDados.TabIndex = 1;
            this.btnCarregarDados.Text = "Carregar Dados";
            this.btnCarregarDados.UseVisualStyleBackColor = true;
            this.btnCarregarDados.Click += new System.EventHandler(this.btnCarregarDados_Click);
            // 
            // cboTabelas
            // 
            this.cboTabelas.FormattingEnabled = true;
            this.cboTabelas.Items.AddRange(new object[] {
            "Categories",
            "Employees",
            "Suppliers",
            "Shippers",
            "Customers"});
            this.cboTabelas.Location = new System.Drawing.Point(23, 302);
            this.cboTabelas.Name = "cboTabelas";
            this.cboTabelas.Size = new System.Drawing.Size(147, 23);
            this.cboTabelas.TabIndex = 2;
            this.cboTabelas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmBanco1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 346);
            this.Controls.Add(this.cboTabelas);
            this.Controls.Add(this.btnCarregarDados);
            this.Controls.Add(this.gridDados);
            this.Name = "frmBanco1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício de Banco de Dados 1";
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView gridDados;
        private Button btnCarregarDados;
        private ComboBox cboTabelas;
    }
}
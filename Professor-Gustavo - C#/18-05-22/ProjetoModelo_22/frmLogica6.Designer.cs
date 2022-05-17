namespace ProjetoModelo_22
{
    partial class frmLogica6
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
            this.txtNumeroFinal = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.lstSoma = new System.Windows.Forms.ListBox();
            this.btnSomar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Somatória de 1 até :";
            // 
            // txtNumeroFinal
            // 
            this.txtNumeroFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtNumeroFinal.Location = new System.Drawing.Point(140, 40);
            this.txtNumeroFinal.Name = "txtNumeroFinal";
            this.txtNumeroFinal.Size = new System.Drawing.Size(58, 23);
            this.txtNumeroFinal.TabIndex = 1;
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(23, 88);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(175, 23);
            this.btnSomar.TabIndex = 2;
            this.btnSomar.Text = "Somar o intervalo (FOR)";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // lstSoma
            // 
            this.lstSoma.ForeColor = System.Drawing.Color.Navy;
            this.lstSoma.FormattingEnabled = true;
            this.lstSoma.ItemHeight = 15;
            this.lstSoma.Location = new System.Drawing.Point(218, 40);
            this.lstSoma.Name = "lstSoma";
            this.lstSoma.Size = new System.Drawing.Size(336, 274);
            this.lstSoma.TabIndex = 3;
            // 
            // btnSomar2
            // 
            this.btnSomar2.Location = new System.Drawing.Point(23, 127);
            this.btnSomar2.Name = "btnSomar2";
            this.btnSomar2.Size = new System.Drawing.Size(175, 23);
            this.btnSomar2.TabIndex = 4;
            this.btnSomar2.Text = "Somar o intervalo (GAUSS)";
            this.btnSomar2.UseVisualStyleBackColor = true;
            this.btnSomar2.Click += new System.EventHandler(this.btnSomar2_Click);
            // 
            // frmLogica6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 328);
            this.Controls.Add(this.btnSomar2);
            this.Controls.Add(this.lstSoma);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txtNumeroFinal);
            this.Controls.Add(this.label1);
            this.Name = "frmLogica6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício de Lógica 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNumeroFinal;
        private Button btnSomar;
        private ListBox lstSoma;
        private Button btnSomar2;
    }
}
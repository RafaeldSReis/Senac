namespace Projeto_modelo_22
{
    partial class frmLogica9
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
            this.listSoma = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Somatoria de 1 até: ";
            // 
            // txtNumeroFinal
            // 
            this.txtNumeroFinal.Location = new System.Drawing.Point(193, 38);
            this.txtNumeroFinal.Name = "txtNumeroFinal";
            this.txtNumeroFinal.Size = new System.Drawing.Size(166, 23);
            this.txtNumeroFinal.TabIndex = 1;
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(385, 38);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(128, 23);
            this.btnSomar.TabIndex = 2;
            this.btnSomar.Text = "Somar o intervalo";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // listSoma
            // 
            this.listSoma.FormattingEnabled = true;
            this.listSoma.ItemHeight = 15;
            this.listSoma.Location = new System.Drawing.Point(385, 80);
            this.listSoma.Name = "listSoma";
            this.listSoma.Size = new System.Drawing.Size(142, 184);
            this.listSoma.TabIndex = 3;
            // 
            // frmLogica9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 307);
            this.Controls.Add(this.listSoma);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txtNumeroFinal);
            this.Controls.Add(this.label1);
            this.Name = "frmLogica9";
            this.Text = "frmLogica9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNumeroFinal;
        private Button btnSomar;
        private ListBox listSoma;
    }
}
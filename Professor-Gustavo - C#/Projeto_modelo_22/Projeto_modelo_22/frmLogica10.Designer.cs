namespace Projeto_modelo_22
{
    partial class frmLogica10
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
            this.txtCentena = new System.Windows.Forms.TextBox();
            this.txtDezena = new System.Windows.Forms.TextBox();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.btnRodar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCentena
            // 
            this.txtCentena.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCentena.Location = new System.Drawing.Point(64, 106);
            this.txtCentena.Name = "txtCentena";
            this.txtCentena.Size = new System.Drawing.Size(100, 34);
            this.txtCentena.TabIndex = 0;
            // 
            // txtDezena
            // 
            this.txtDezena.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDezena.Location = new System.Drawing.Point(182, 106);
            this.txtDezena.Name = "txtDezena";
            this.txtDezena.Size = new System.Drawing.Size(100, 34);
            this.txtDezena.TabIndex = 1;
            // 
            // txtUnidade
            // 
            this.txtUnidade.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUnidade.Location = new System.Drawing.Point(299, 106);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(100, 34);
            this.txtUnidade.TabIndex = 2;
            // 
            // btnRodar
            // 
            this.btnRodar.Location = new System.Drawing.Point(157, 202);
            this.btnRodar.Name = "btnRodar";
            this.btnRodar.Size = new System.Drawing.Size(165, 23);
            this.btnRodar.TabIndex = 3;
            this.btnRodar.Text = "Rodar";
            this.btnRodar.UseVisualStyleBackColor = true;
            this.btnRodar.Click += new System.EventHandler(this.btnRodar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(110, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Odômetro de 3 casas";
            // 
            // frmLogica10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 295);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRodar);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.txtDezena);
            this.Controls.Add(this.txtCentena);
            this.Name = "frmLogica10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogica10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCentena;
        private TextBox txtDezena;
        private TextBox txtUnidade;
        private Button btnRodar;
        private Label label1;
    }
}
namespace ProjetoModelo_22
{
    partial class frmLogica7
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
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.txtDezena = new System.Windows.Forms.TextBox();
            this.txtCentena = new System.Windows.Forms.TextBox();
            this.btnRodar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUnidade
            // 
            this.txtUnidade.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUnidade.Location = new System.Drawing.Point(155, 48);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(41, 34);
            this.txtUnidade.TabIndex = 0;
            // 
            // txtDezena
            // 
            this.txtDezena.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDezena.Location = new System.Drawing.Point(108, 48);
            this.txtDezena.Name = "txtDezena";
            this.txtDezena.Size = new System.Drawing.Size(41, 34);
            this.txtDezena.TabIndex = 1;
            // 
            // txtCentena
            // 
            this.txtCentena.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCentena.Location = new System.Drawing.Point(61, 48);
            this.txtCentena.Name = "txtCentena";
            this.txtCentena.Size = new System.Drawing.Size(41, 34);
            this.txtCentena.TabIndex = 2;
            // 
            // btnRodar
            // 
            this.btnRodar.Location = new System.Drawing.Point(61, 92);
            this.btnRodar.Name = "btnRodar";
            this.btnRodar.Size = new System.Drawing.Size(135, 34);
            this.btnRodar.TabIndex = 3;
            this.btnRodar.Text = "Rodar";
            this.btnRodar.UseVisualStyleBackColor = true;
            this.btnRodar.Click += new System.EventHandler(this.btnRodar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(51, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Odômetro de 3 casas";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero.Location = new System.Drawing.Point(93, 192);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(68, 34);
            this.txtNumero.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Rodar e Parar em ...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLogica7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRodar);
            this.Controls.Add(this.txtCentena);
            this.Controls.Add(this.txtDezena);
            this.Controls.Add(this.txtUnidade);
            this.Name = "frmLogica7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício de Lógica 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUnidade;
        private TextBox txtDezena;
        private TextBox txtCentena;
        private Button btnRodar;
        private Label label1;
        private TextBox txtNumero;
        private Button button1;
    }
}
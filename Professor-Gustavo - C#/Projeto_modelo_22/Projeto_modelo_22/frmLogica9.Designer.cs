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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.btnSoma2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Somatória de 1 até: ";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(176, 32);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 23);
            this.txtN1.TabIndex = 1;
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(46, 94);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(148, 23);
            this.btnSomar.TabIndex = 2;
            this.btnSomar.Text = "Somar o intervalo FOR";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 15;
            this.lstResult.Location = new System.Drawing.Point(335, 35);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(155, 214);
            this.lstResult.TabIndex = 3;
            // 
            // btnSoma2
            // 
            this.btnSoma2.Location = new System.Drawing.Point(46, 152);
            this.btnSoma2.Name = "btnSoma2";
            this.btnSoma2.Size = new System.Drawing.Size(166, 23);
            this.btnSoma2.TabIndex = 4;
            this.btnSoma2.Text = "Somar o intervalo (GAUSS)";
            this.btnSoma2.UseVisualStyleBackColor = true;
            this.btnSoma2.Click += new System.EventHandler(this.btnSoma2_Click);
            // 
            // frmLogica9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 327);
            this.Controls.Add(this.btnSoma2);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label1);
            this.Name = "frmLogica9";
            this.Text = "frmLogica9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtN1;
        private Button btnSomar;
        private ListBox lstResult;
        private Button btnSoma2;
    }
}
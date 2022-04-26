namespace Projeto_modelo_22
{
    partial class frmAltoBaixo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this.listName = new System.Windows.Forms.ListBox();
            this.listAlt = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMeAlt = new System.Windows.Forms.Label();
            this.lblMaAlt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do aluno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura do aluno:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 23);
            this.txtName.TabIndex = 2;
            // 
            // txtAlt
            // 
            this.txtAlt.Location = new System.Drawing.Point(111, 60);
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.Size = new System.Drawing.Size(215, 23);
            this.txtAlt.TabIndex = 3;
            // 
            // listName
            // 
            this.listName.FormattingEnabled = true;
            this.listName.ItemHeight = 15;
            this.listName.Location = new System.Drawing.Point(12, 125);
            this.listName.Name = "listName";
            this.listName.Size = new System.Drawing.Size(120, 169);
            this.listName.TabIndex = 4;
            // 
            // listAlt
            // 
            this.listAlt.FormattingEnabled = true;
            this.listAlt.ItemHeight = 15;
            this.listAlt.Location = new System.Drawing.Point(138, 125);
            this.listAlt.Name = "listAlt";
            this.listAlt.Size = new System.Drawing.Size(34, 169);
            this.listAlt.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(178, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.Location = new System.Drawing.Point(278, 125);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(75, 23);
            this.btnAlt.TabIndex = 7;
            this.btnAlt.Text = "Altura";
            this.btnAlt.UseVisualStyleBackColor = true;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(373, 125);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Alt:";
            // 
            // lblMeAlt
            // 
            this.lblMeAlt.AutoSize = true;
            this.lblMeAlt.Location = new System.Drawing.Point(189, 188);
            this.lblMeAlt.Name = "lblMeAlt";
            this.lblMeAlt.Size = new System.Drawing.Size(67, 15);
            this.lblMeAlt.TabIndex = 11;
            this.lblMeAlt.Text = "------------";
            // 
            // lblMaAlt
            // 
            this.lblMaAlt.AutoSize = true;
            this.lblMaAlt.Location = new System.Drawing.Point(189, 236);
            this.lblMaAlt.Name = "lblMaAlt";
            this.lblMaAlt.Size = new System.Drawing.Size(67, 15);
            this.lblMaAlt.TabIndex = 12;
            this.lblMaAlt.Text = "------------";
            // 
            // frmAltoBaixo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 324);
            this.Controls.Add(this.lblMaAlt);
            this.Controls.Add(this.lblMeAlt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAlt);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listAlt);
            this.Controls.Add(this.listName);
            this.Controls.Add(this.txtAlt);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAltoBaixo";
            this.Text = "frmAltoBaixo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtAlt;
        private ListBox listName;
        private ListBox listAlt;
        private Button btnAdd;
        private Button btnAlt;
        private Button btnClear;
        private Label label3;
        private Label label4;
        private Label lblMeAlt;
        private Label lblMaAlt;
    }
}
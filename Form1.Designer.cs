namespace valores
{
    partial class frmTrocaDeValores
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.valor1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrimeiroValor = new System.Windows.Forms.TextBox();
            this.txtSegundoValor = new System.Windows.Forms.TextBox();
            this.btn_trocar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valor1
            // 
            this.valor1.AutoSize = true;
            this.valor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.valor1.Location = new System.Drawing.Point(13, 27);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(66, 20);
            this.valor1.TabIndex = 0;
            this.valor1.Text = "Valor 1:";
            this.valor1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(158, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "valor 2:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPrimeiroValor
            // 
            this.txtPrimeiroValor.Location = new System.Drawing.Point(85, 27);
            this.txtPrimeiroValor.Multiline = true;
            this.txtPrimeiroValor.Name = "txtPrimeiroValor";
            this.txtPrimeiroValor.Size = new System.Drawing.Size(70, 20);
            this.txtPrimeiroValor.TabIndex = 2;
            this.txtPrimeiroValor.TextChanged += new System.EventHandler(this.txtPrimeiroValor_TextChanged);
            // 
            // txtSegundoValor
            // 
            this.txtSegundoValor.Location = new System.Drawing.Point(227, 27);
            this.txtSegundoValor.Multiline = true;
            this.txtSegundoValor.Name = "txtSegundoValor";
            this.txtSegundoValor.Size = new System.Drawing.Size(70, 20);
            this.txtSegundoValor.TabIndex = 4;
            // 
            // btn_trocar
            // 
            this.btn_trocar.Location = new System.Drawing.Point(85, 72);
            this.btn_trocar.Name = "btn_trocar";
            this.btn_trocar.Size = new System.Drawing.Size(75, 30);
            this.btn_trocar.TabIndex = 5;
            this.btn_trocar.Text = "Trocar";
            this.btn_trocar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trocar.UseVisualStyleBackColor = true;
            this.btn_trocar.Click += new System.EventHandler(this.btn_trocar_Click);
            // 
            // frmTrocaDeValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1157, 560);
            this.Controls.Add(this.btn_trocar);
            this.Controls.Add(this.txtSegundoValor);
            this.Controls.Add(this.txtPrimeiroValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valor1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "frmTrocaDeValores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valor1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrimeiroValor;
        private System.Windows.Forms.TextBox txtSegundoValor;
        private System.Windows.Forms.Button btn_trocar;
    }
}


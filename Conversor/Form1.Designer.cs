namespace Conversor
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnCalcular2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtBinario = new System.Windows.Forms.MaskedTextBox();
			this.txtInteiro = new System.Windows.Forms.MaskedTextBox();
			this.txtBinario2 = new System.Windows.Forms.MaskedTextBox();
			this.txtInteiro2 = new System.Windows.Forms.MaskedTextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(45, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(409, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "CONVERSOR DE NÚMEROS INTEIROS EM BINÁRIO";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 292);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Valor Inteiro :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Valor Binário :";
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(213, 347);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(150, 47);
			this.btnLimpar.TabIndex = 7;
			this.btnLimpar.Text = "Limpar Campos";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnCalcular2
			// 
			this.btnCalcular2.Location = new System.Drawing.Point(353, 176);
			this.btnCalcular2.Name = "btnCalcular2";
			this.btnCalcular2.Size = new System.Drawing.Size(234, 47);
			this.btnCalcular2.TabIndex = 12;
			this.btnCalcular2.Text = "Calcular";
			this.btnCalcular2.UseVisualStyleBackColor = true;
			this.btnCalcular2.Click += new System.EventHandler(this.btnCalcular2_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(347, 285);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Valor Binário :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(350, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Valor Inteiro :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(11, 240);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 20);
			this.label6.TabIndex = 13;
			this.label6.Text = "RESPOSTA:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(349, 240);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(99, 20);
			this.label7.TabIndex = 14;
			this.label7.Text = "RESPOSTA:";
			// 
			// txtBinario
			// 
			this.txtBinario.Location = new System.Drawing.Point(110, 117);
			this.txtBinario.Mask = "00000000";
			this.txtBinario.Name = "txtBinario";
			this.txtBinario.Size = new System.Drawing.Size(77, 20);
			this.txtBinario.TabIndex = 15;
			// 
			// txtInteiro
			// 
			this.txtInteiro.Location = new System.Drawing.Point(110, 289);
			this.txtInteiro.Mask = "000";
			this.txtInteiro.Name = "txtInteiro";
			this.txtInteiro.Size = new System.Drawing.Size(77, 20);
			this.txtInteiro.TabIndex = 16;
			// 
			// txtBinario2
			// 
			this.txtBinario2.Location = new System.Drawing.Point(425, 282);
			this.txtBinario2.Mask = "00000000";
			this.txtBinario2.Name = "txtBinario2";
			this.txtBinario2.Size = new System.Drawing.Size(77, 20);
			this.txtBinario2.TabIndex = 17;
			// 
			// txtInteiro2
			// 
			this.txtInteiro2.Location = new System.Drawing.Point(425, 117);
			this.txtInteiro2.Mask = "000";
			this.txtInteiro2.Name = "txtInteiro2";
			this.txtInteiro2.Size = new System.Drawing.Size(77, 20);
			this.txtInteiro2.TabIndex = 18;
			// 
			// btnCalcular
			// 
			this.btnCalcular.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCalcular.Location = new System.Drawing.Point(18, 172);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(234, 47);
			this.btnCalcular.TabIndex = 5;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(620, 450);
			this.Controls.Add(this.txtInteiro2);
			this.Controls.Add(this.txtBinario2);
			this.Controls.Add(this.txtInteiro);
			this.Controls.Add(this.txtBinario);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnCalcular2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Conversor";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MaskedTextBox txtBinario;
		private System.Windows.Forms.MaskedTextBox txtInteiro;
		private System.Windows.Forms.MaskedTextBox txtBinario2;
		private System.Windows.Forms.MaskedTextBox txtInteiro2;
		private System.Windows.Forms.Button btnCalcular;
	}
}

